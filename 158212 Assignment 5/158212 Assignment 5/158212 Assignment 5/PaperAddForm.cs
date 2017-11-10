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
    public partial class PaperAddForm : Form {

        Form1 _frm1;
        public PaperAddForm(Form1 form) {
            InitializeComponent();
            _frm1 = form;

        }

        private void AddPaperButtonClick(object sender, EventArgs e) {
            //Make sure the user has entered correct data, and if so, pass it back to the main form.
            if (ValidateData(PaperNameTextBox.Text, PaperIDTextBox.Text, PaperCoordinatorTextBox.Text)) {
                _frm1.AddNewPaper(PaperNameTextBox.Text, Convert.ToInt32(PaperIDTextBox.Text), PaperCoordinatorTextBox.Text);
                this.Close();
            }
           
        }

        private bool ValidateData(string name, string id, string coordinator) {
            //Validate the user data entered was o.k.
            if (name == "") {
                ErrorLabel.Text = "Error: Paper Name is required.";
                ErrorLabel.Visible = true;
                return false;
            }

            if (id == "") {
                ErrorLabel.Text = "Error: Paper ID is required.";
                ErrorLabel.Visible = true;
                return false;
            }

            try{
                int valid = Convert.ToInt32(id);
            }catch{
                ErrorLabel.Text = "Error: ID is not a valid number.";
                ErrorLabel.Visible = true;
                return false;   
            }

            if (coordinator == "") {
                ErrorLabel.Text = "Error: Co-ordinator is required.";
                ErrorLabel.Visible = true;
                return false;
            }
            return true;
        }
    }
}
