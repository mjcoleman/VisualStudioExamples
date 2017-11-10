//****158.212 Assignment 5 by Michael Coleman 07315554****\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.IO;
using StudentManagementSystem;


namespace StudentManagementSystem {
    public partial class Form1 : Form {
        //Uni Object to hold all the appropriate data.
        University _uni;
        public Form1() {
            InitializeComponent();
        }

        
       //***FORM METHODS***\\
        private void NewPaperForm() {
            //Set up and show the form to add a new paper.
            PaperAddForm paperAdd = new PaperAddForm(this);
            paperAdd.Show();
        }

        private void NewStudentForm() {
            //Set up and show the form to add a new student.
            StudentAddForm studentAdd = new StudentAddForm(this);
            studentAdd.Show();
        }

        public void AddNewPaper(string name, int id, string coordinator) {
            //Add the paper to the uni object if its id or name doesn't already exist.
            if (_uni.CheckIfPaperAlreadyExists(id, name)) {
                DialogResult result = MessageBox.Show(String.Format("Error, A Paper With ID: {0} Already Exists.", id), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry) {
                    NewPaperForm();
                }
            } else {
                Paper p = new Paper(name, id, coordinator);
                _uni.AddNewPaper(p);
                BindPaperData();
            }
        }

        public void AddNewStudent(string name, int id, DateTime dob) {
            //Add the student to the uni object if their id doesn't already exist.
            if (_uni.CheckIfStudentAlreadyExists(id)) {
                DialogResult result = MessageBox.Show(String.Format("Error, A Student With ID: {0} Already Exists.", id), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry) {
                    NewStudentForm();
                } 
            } else {
                Student s = new Student(name, id, dob);
                _uni.AddNewStudent(s);
                BindStudentData();  
            }
        }
    
      

        //***FILE IO***\\
        private void WriteUniversityToFile() {
            //Open a file dialog, and as long as the file chosen was correct, pass it to the Uni object to save.
            SaveFileDialog dialog;
            dialog = new SaveFileDialog();
            dialog.Filter = "Uni File|*.uni";
            DialogResult result;
            result = dialog.ShowDialog();
            
            if (result == DialogResult.OK) {
                FileStream fs;
                fs = (FileStream)dialog.OpenFile();
                bool isWriteSuccessful = _uni.WriteDataToFile(fs);
            
                if (isWriteSuccessful) {
                    MessageBox.Show(String.Format("University: {0} has been saved.", _uni.UniName));
                } else {
                    MessageBox.Show("Error, could not save University File", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }


        private void ReadUniversityFromFile() {
            //Open a file dialog, and as long as the file chosen was correct, pass it to the Uni object to read.
            OpenFileDialog dialog;
            dialog = new OpenFileDialog();
            dialog.Filter = "Uni Files|*.uni";
            DialogResult result;
            result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                _uni = new University();

                FileStream fs;
                fs = (FileStream)dialog.OpenFile();
                bool wasFileReadSuccessful = _uni.ReadUniversityFromFile(fs);

                if (wasFileReadSuccessful) {
                    SetUpUI();
                    BindStudentData();
                    BindPaperData();
                } else {
                    MessageBox.Show("Error, could not read uni File", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
             }   
        }
        
        private void EnrollAStudentInAPaper(Student s, Paper p) {
            //Take the passed Student and Paper and enroll them if there is not a conflict, otherwise, show an error.
            bool enrolled =  _uni.EnrollAStudentInAPaper(s, p);
           
            if (!enrolled) {
                MessageBox.Show(String.Format("{0} is already enrolled in {1}", s.Name, p.PaperName), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                BindPaperData();
                BindStudentData();
            }   
        }

        


        //***USER INTERFACE***\\
        private void SetUpUI() {
            //Initial setup of the UI so that all the prompts are appropriately hidden.
            TxtUniversityName.Visible = false;
            ButCreateUniversity.Visible = false;
            ButOpenUniFile.Visible = false;
            LabUniversityNamePrompt.Visible = false;
            LabUniversityOpenPrompt.Visible = false;
            LABUniversityName.Text = _uni.UniName;
            LABUniversityName.Visible = true;
            TabUniversityView.Visible = true;
            SaveMenuItem.Enabled = true;
            AddPaperMenuItem.Enabled = true;
            AddStudentMenuItem.Enabled = true;
            ComPaperList.SelectedIndex = 0;
            ComStudentList.SelectedIndex = 0;
        }

        private void BindEnrolledPapersData(Student s) {
            //Updating the UI So we  don't get any {Collection} showing in the ListBoxes.
            BindingSource enrolledPaperBind = new BindingSource();
            enrolledPaperBind.DataSource = s.EnrolledPapers;
            ListSelectedStudentPapers.DisplayMember = "Value";
            ListSelectedStudentPapers.DataSource = enrolledPaperBind;

            if (s.EnrolledPapers.Count > 0) {
                LabNoPapersByStudent.Hide();
                ListSelectedStudentPapers.Show();
            } else {
                LabNoPapersByStudent.Show();
                ListSelectedStudentPapers.Hide();
            }
        }

        private void BindEnrolledStudentsData(Paper p) {
            //Updating the UI So we  don't get any {Collection} showing in the ListBoxes.
            BindingSource enrolledStudentBind = new BindingSource();
            enrolledStudentBind.DataSource = p.StudentsInPaper;
            ListSelectedPaperStudents.DisplayMember = "Value";
            ListSelectedPaperStudents.DataSource = enrolledStudentBind;

            if (p.StudentsInPaper.Count > 0) {
                LabNoStudentsByPaper.Hide();
                ListSelectedPaperStudents.Show();
            } else {
                LabNoStudentsByPaper.Show();
                ListSelectedPaperStudents.Hide();
            }
        }


        private void BindStudentData() {
            //Updating the UI So we  don't get any {Collection} showing in the ListBoxes.
            BindingSource studentBind = new BindingSource();
            studentBind.DataSource = _uni.Students;
            StudentListBox.DisplayMember = "Value";
            StudentListBox.DataSource = studentBind;

            ComStudentList.DisplayMember = "Value";
            ComStudentList.DataSource = studentBind;
        }

        private void BindPaperData() {
            //Updating the UI So we  don't get any {Collection} showing in the ListBoxes.
            BindingSource paperBind = new BindingSource();
            paperBind.DataSource = _uni.Papers;
            PaperListBox.DisplayMember = "Value";
            PaperListBox.DataSource = paperBind;

            ComPaperList.DisplayMember = "Value";
            ComPaperList.DataSource = paperBind;
        }



        //***EVENT HANDLERS***\\
        private void AddStudentMenuItemClick(object sender, EventArgs e) {
            NewStudentForm();
        }

        private void AddPaperMenuItemClick(object sender, EventArgs e) {
            NewPaperForm();
        }

        private void OpenMenuItemClick(object sender, EventArgs e) {
            ReadUniversityFromFile();
        }

        private void ButOpenUniFileClick(object sender, EventArgs e) {
            ReadUniversityFromFile();
        }

        private void ButEnrollStudentInSelectedPaperClick(object sender, EventArgs e) {
            //Set the paper and student to a dictionary readable type and enroll them.
            KeyValuePair<int, Student> selectedStudent = (KeyValuePair<int, Student>)ComStudentList.SelectedItem;
            KeyValuePair<int, Paper> selectedPaper = (KeyValuePair<int, Paper>)PaperListBox.SelectedItem;
            Student s = _uni.Students[selectedStudent.Key];
            Paper p = _uni.Papers[selectedPaper.Key];
            EnrollAStudentInAPaper(s, p);
        }

        private void PaperListBoxSelectedIndexChanged(object sender, EventArgs e) {
            //Update the UI when the paper List Box selection changes.
            KeyValuePair<int, Paper> selected = (KeyValuePair<int, Paper>)PaperListBox.SelectedItem;
            LabSelectedPaperName.Text = selected.Value.PaperName;
            LabSelectedPaperID.Text = selected.Value.PaperID.ToString();
            LabSelectedPaperCoordinator.Text = selected.Value.PaperCoordinator;

            BindEnrolledStudentsData(_uni.Papers[selected.Key]);

            LabPaperInfoHint.Visible = false;
            GBoxPaperInfo.Visible = true;

        }
        private void EnrollSelectedStudentButtonClick(object sender, EventArgs e) {
            //Set the paper and student to a dictionary readable type and enroll them.
            KeyValuePair<int, Student> selectedStudent = (KeyValuePair<int, Student>)StudentListBox.SelectedItem;
            KeyValuePair<int, Paper> selectedPaper = (KeyValuePair<int, Paper>)ComPaperList.SelectedItem;

            Student s = _uni.Students[selectedStudent.Key];
            Paper p = _uni.Papers[selectedPaper.Key];

            EnrollAStudentInAPaper(s, p);
        }

        private void ButAddPaperClick(object sender, EventArgs e) {
            //Show form for adding a new paper.
            NewPaperForm();
        }

        private void ButAddStudentClick(object sender, EventArgs e) {
            //Show form for adding a new student.
            NewStudentForm();
        }

        private void StudentListBoxSelectedIndexChanged(object sender, EventArgs e) {
            //Update details of ui when the ListBox Changes value.
            KeyValuePair<int, Student> selected = (KeyValuePair<int, Student>)StudentListBox.SelectedItem;
            LabSelectedStudentName.Text = selected.Value.Name;
            LabSelectedStudentID.Text = selected.Value.ID.ToString();
            LabSelectedStudentDOB.Text = selected.Value.Birthdate.ToShortDateString();

            BindEnrolledPapersData(_uni.Students[selected.Key]);

            LabStudentInfoHint.Visible = false;
            GBoxStudentInfo.Visible = true;
        }

        private void SaveMenuItemClick(object sender, EventArgs e) {
            WriteUniversityToFile();
        }

        private void ButCreateUniversityClick(object sender, EventArgs e) {
            //Create the university object so long as there is valid text.
            if (TxtUniversityName.Text == "") {
                MessageBox.Show("Error: No University Name Entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                _uni = new University(TxtUniversityName.Text);
                SetUpUI();
            }
        }

    }
}
