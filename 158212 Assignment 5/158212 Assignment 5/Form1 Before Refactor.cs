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


/* Still to do:
 * Input Validation for Files.
 * Fix UI (Papers enrolled students list)
 * Refactor
 * Unit Tests
 * Comments
 * If I get time, test appending data.
 */

namespace StudentManagementSystem {
    public partial class Form1 : Form {
        University _uni;
        public Form1() {
            InitializeComponent();
        }

        private void AddStudentMenuItemClick(object sender, EventArgs e) {
            NewStudentForm();
        }

        private void AddPaperMenuItemClick(object sender, EventArgs e) {
            NewPaperForm();
        }

        private void NewPaperForm() {
            PaperAddForm paperAdd = new PaperAddForm(this);
            paperAdd.Show();
        }

        private void NewStudentForm() {
            StudentAddForm studentAdd = new StudentAddForm(this);
            studentAdd.Show();
        }

        public void AddNewPaper(string name, int id, string coordinator) {
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


        private void BindStudentData() {
            BindingSource studentBind = new BindingSource();
            studentBind.DataSource = _uni.Students;
            StudentListBox.DisplayMember = "Value";
            StudentListBox.DataSource = studentBind;

            ComStudentList.DisplayMember = "Value";
            ComStudentList.DataSource = studentBind;
        }

        private void BindPaperData() {
            BindingSource paperBind = new BindingSource();
            paperBind.DataSource = _uni.Papers;
            PaperListBox.DisplayMember = "Value";
            PaperListBox.DataSource = paperBind;
            
            ComPaperList.DisplayMember = "Value";
            ComPaperList.DataSource = paperBind;
        }

      
    
      

        private void SaveMenuItemClick(object sender, EventArgs e) {
            WriteUniversityToFile();
        }

        private void WriteUniversityToFile() {

            SaveFileDialog dialog;
            dialog = new SaveFileDialog();
            dialog.Filter = "Uni File|*.uni";
            DialogResult result;
            result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                FileStream fs;
                fs = (FileStream)dialog.OpenFile();

                StreamWriter writer;
                writer = new StreamWriter(fs);

                writer.WriteLine(_uni.UniName);
                writer.WriteLine("<STUDENTS>");
                foreach (KeyValuePair<int, Student> s in _uni.Students) {
                    writer.WriteLine("<STUDENT>");
                    writer.WriteLine(s.Key);
                    writer.WriteLine(s.Value.Name);
                    writer.WriteLine(s.Value.Birthdate);
                    writer.WriteLine("</STUDENT>");
                }
                writer.WriteLine("</STUDENTS>");

                writer.WriteLine("<PAPERS>");
                foreach (KeyValuePair<int, Paper> p in _uni.Papers) {
                    writer.WriteLine("<PAPER>");
                    writer.WriteLine(p.Key);
                    writer.WriteLine(p.Value.PaperName);
                    writer.WriteLine(p.Value.PaperCoordinator);
                    writer.WriteLine("<ENROLLED>");
                    foreach (KeyValuePair<int, Student> s in p.Value.StudentsInPaper) {
                        writer.WriteLine("<ENROLLEDSTUDENT>");
                        writer.WriteLine(s.Key);
                        writer.WriteLine("</ENROLLEDSTUDENT>");
                    }
                    writer.WriteLine("</ENROLLED>");
                }

                writer.WriteLine("</PAPERS>");
                writer.Close();

                MessageBox.Show(String.Format("University: {0} has been saved.", _uni.UniName));

            }

            
        }


        private void ReadUniversityFromFile() {
          
            OpenFileDialog dialog;
            dialog = new OpenFileDialog();
            dialog.Filter = "Uni Files|*.uni";
            DialogResult result;
            result = dialog.ShowDialog();
            if (result == DialogResult.OK) {
                FileStream fs;
                fs = (FileStream)dialog.OpenFile();
                StreamReader reader;
                reader = new StreamReader(fs);
                
                //Uni Name
                string uniName = reader.ReadLine();
                _uni = new University(uniName);

                //Students
                if (reader.ReadLine() == "<STUDENTS>") {
                    while (reader.ReadLine() != "</STUDENTS>") {
                                int id = Convert.ToInt32(reader.ReadLine());
                                string name = reader.ReadLine();
                                DateTime dob = Convert.ToDateTime(reader.ReadLine());
                                Student s = new Student(name, id, dob);
                                _uni.Students.Add(s.ID, s);
                                reader.ReadLine();
                        
                    }
                }

                //Papers
                if (reader.ReadLine() == "<PAPERS>") {
                    while (reader.ReadLine() != "</PAPERS>") {
                                int paperID = Convert.ToInt32(reader.ReadLine());
                                string paperName = reader.ReadLine();
                                string paperCoordinator = reader.ReadLine();
                                Paper p = new Paper(paperName, paperID, paperCoordinator);
                                _uni.Papers.Add(p.PaperID, p);
                               if (reader.ReadLine() == "<ENROLLED>") {
                                    while (reader.ReadLine() != "</ENROLLED>") {
                                        int studentID = Convert.ToInt32(reader.ReadLine());
                                        _uni.Papers[p.PaperID].AddStudentToPaper(_uni.Students[studentID]);
                                        _uni.Students[studentID].AddPaperToStudent(_uni.Papers[p.PaperID]);
                                        BindStudentData();
                                        BindPaperData();
                                        reader.ReadLine();
                                    }
                                }
                    }
                }

                
                reader.Close();
                SetUpUI();
            }
        }
        private void ButCreateUniversityClick(object sender, EventArgs e) {
            if (TxtUniversityName.Text == "") {
                MessageBox.Show("Error: No University Name Entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                _uni = new University(TxtUniversityName.Text);
                SetUpUI();
            }
        }

        private void SetUpUI() {
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

        private void ButAddStudentClick(object sender, EventArgs e) {
            NewStudentForm();
        }

        private void StudentListBoxSelectedIndexChanged(object sender, EventArgs e) {
            //Update details of ui.
            KeyValuePair<int, Student> selected =(KeyValuePair<int, Student>)StudentListBox.SelectedItem;
            LabSelectedStudentName.Text = selected.Value.Name;
            LabSelectedStudentID.Text = selected.Value.ID.ToString();
            LabSelectedStudentDOB.Text = selected.Value.Birthdate.ToShortDateString();
            
            BindEnrolledPapersData(_uni.Students[selected.Key]);

            LabStudentInfoHint.Visible = false;
            GBoxStudentInfo.Visible = true;
            

        }

        private void ButAddPaperClick(object sender, EventArgs e) {
            NewPaperForm();
        }

      

        private void BindEnrolledPapersData(Student s) {
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

   

        private void EnrollSelectedStudentButtonClick(object sender, EventArgs e) {
            KeyValuePair<int, Student> selectedStudent = (KeyValuePair<int, Student>)StudentListBox.SelectedItem;
            KeyValuePair<int, Paper> selectedPaper = (KeyValuePair<int, Paper>)ComPaperList.SelectedItem;

            Student s = _uni.Students[selectedStudent.Key];
            Paper p = _uni.Papers[selectedPaper.Key];

            EnrollAStudentInAPaper(s, p);        
        }

        private void PaperListBoxSelectedIndexChanged(object sender, EventArgs e) {
            //Update details of ui.
            KeyValuePair<int, Paper> selected = (KeyValuePair<int, Paper>)PaperListBox.SelectedItem;
            LabSelectedPaperName.Text = selected.Value.PaperName;
            LabSelectedPaperID.Text = selected.Value.PaperID.ToString();
            LabSelectedPaperCoordinator.Text = selected.Value.PaperCoordinator;

            BindEnrolledStudentsData(_uni.Papers[selected.Key]);

            LabPaperInfoHint.Visible = false;
            GBoxPaperInfo.Visible = true;
            
        }

        private void BindEnrolledStudentsData(Paper p) {
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

        private void ButEnrollStudentInSelectedPaperClick(object sender, EventArgs e) {
            KeyValuePair<int, Student> selectedStudent = (KeyValuePair<int, Student>)ComStudentList.SelectedItem;
            KeyValuePair<int, Paper> selectedPaper = (KeyValuePair<int, Paper>)PaperListBox.SelectedItem;
            Student s = _uni.Students[selectedStudent.Key];
            Paper p = _uni.Papers[selectedPaper.Key];
            EnrollAStudentInAPaper(s, p);
        }

        private void EnrollAStudentInAPaper(Student s, Paper p) {
            if (s.CanAddPaperToStudent(p)) {
                p.AddStudentToPaper(s);
                s.AddPaperToStudent(p);
                BindEnrolledStudentsData(p);
                BindEnrolledPapersData(s);
            } else {
                MessageBox.Show(String.Format("{0} is already enrolled in {1}", s.Name, p.PaperName), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpenMenuItemClick(object sender, EventArgs e) {
            ReadUniversityFromFile();
        }

        private void ButOpenUniFileClick(object sender, EventArgs e) {
            ReadUniversityFromFile();
        }

        
    }
}
