using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem {
    public partial class StudentAddForm : Form {
        Form1 _frm;
        public StudentAddForm(Form1 form) {
            InitializeComponent();
            _frm = form;
        }

        private void AddStudentButtonClick(object sender, EventArgs e) {
            //Make sure the user has entered correct data, and if so, pass it back to the main form.
            if (ValidateData(StudentNameTextBox.Text, StudentIDTextBox.Text, StudentDOBTextBox.Text)) {
                ErrorLabel.Visible = false;
                DateTime validDT = new DateTime();
                validDT = DateTime.ParseExact(StudentDOBTextBox.Text, "dd/MM/yyyy", null);

                _frm.AddNewStudent(StudentNameTextBox.Text, Convert.ToInt32(StudentIDTextBox.Text), validDT);
                this.Close();
            }
            
        }

        

        private bool ValidateData(string name, string id, string dob) {
            //Validate the user data entered was o.k.
            try {
                DateTime dt = new DateTime();
                dt = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
            } catch {
                ErrorLabel.Text = "Error: Date was not valid.\nPlease use the format dd/MM/yyy";
                ErrorLabel.Visible = true;
                return false;
            }

            if (name == "") {
                ErrorLabel.Text = "Error: Student Name is required.";
                ErrorLabel.Visible = true;
                return false;
            }

            if (id == "") {
                ErrorLabel.Text = "Error: Student ID is required.";
                ErrorLabel.Visible = true;
                return false;
            }

            try {
                int valid = Convert.ToInt32(id);
            } catch {
                ErrorLabel.Text = "Error: ID is not a valid number.";
                ErrorLabel.Visible = true;
                return false;
            }

            return true;
        }
        
    }
}
