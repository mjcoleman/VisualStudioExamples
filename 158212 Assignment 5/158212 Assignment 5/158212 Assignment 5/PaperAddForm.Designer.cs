namespace StudentManagementSystem {
    partial class PaperAddForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PaperNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaperCoordinatorTextBox = new System.Windows.Forms.TextBox();
            this.PaperIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPaperButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaperNameTextBox
            // 
            this.PaperNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.PaperNameTextBox.Name = "PaperNameTextBox";
            this.PaperNameTextBox.Size = new System.Drawing.Size(202, 20);
            this.PaperNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paper Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paper Co-ordinator:";
            // 
            // PaperCoordinatorTextBox
            // 
            this.PaperCoordinatorTextBox.Location = new System.Drawing.Point(12, 196);
            this.PaperCoordinatorTextBox.Name = "PaperCoordinatorTextBox";
            this.PaperCoordinatorTextBox.Size = new System.Drawing.Size(202, 20);
            this.PaperCoordinatorTextBox.TabIndex = 2;
            // 
            // PaperIDTextBox
            // 
            this.PaperIDTextBox.Location = new System.Drawing.Point(12, 133);
            this.PaperIDTextBox.Name = "PaperIDTextBox";
            this.PaperIDTextBox.Size = new System.Drawing.Size(202, 20);
            this.PaperIDTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paper ID:";
            // 
            // AddPaperButton
            // 
            this.AddPaperButton.Location = new System.Drawing.Point(73, 296);
            this.AddPaperButton.Name = "AddPaperButton";
            this.AddPaperButton.Size = new System.Drawing.Size(75, 23);
            this.AddPaperButton.TabIndex = 6;
            this.AddPaperButton.Text = "Add Paper";
            this.AddPaperButton.UseVisualStyleBackColor = true;
            this.AddPaperButton.Click += new System.EventHandler(this.AddPaperButtonClick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 245);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(55, 13);
            this.ErrorLabel.TabIndex = 9;
            this.ErrorLabel.Text = "ErrorLabel";
            this.ErrorLabel.Visible = false;
            // 
            // PaperAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 331);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.AddPaperButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaperIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaperCoordinatorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaperNameTextBox);
            this.Name = "PaperAddForm";
            this.Text = "Add A Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaperNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaperCoordinatorTextBox;
        private System.Windows.Forms.MaskedTextBox PaperIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPaperButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}