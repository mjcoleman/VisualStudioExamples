namespace StudentManagementSystem {
    partial class Form1 {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPaperMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaperListBox = new System.Windows.Forms.ListBox();
            this.TabUniversityView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabStudentInfoHint = new System.Windows.Forms.Label();
            this.GBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.LabNoPapersByStudent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComPaperList = new System.Windows.Forms.ComboBox();
            this.EnrollSelectedStudentButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ListSelectedStudentPapers = new System.Windows.Forms.ListBox();
            this.LabSelectedStudentDOB = new System.Windows.Forms.Label();
            this.LabSelectedStudentID = new System.Windows.Forms.Label();
            this.LabSelectedStudentName = new System.Windows.Forms.Label();
            this.ButAddStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabPaperInfoHint = new System.Windows.Forms.Label();
            this.GBoxPaperInfo = new System.Windows.Forms.GroupBox();
            this.ComStudentList = new System.Windows.Forms.ComboBox();
            this.LabNoStudentsByPaper = new System.Windows.Forms.Label();
            this.LabSelectedPaperID = new System.Windows.Forms.Label();
            this.LabSelectedPaperName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabSelectedPaperCoordinator = new System.Windows.Forms.Label();
            this.ButEnrollStudentInSelectedPaper = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ListSelectedPaperStudents = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButAddPaper = new System.Windows.Forms.Button();
            this.LABUniversityName = new System.Windows.Forms.Label();
            this.TxtUniversityName = new System.Windows.Forms.TextBox();
            this.LabUniversityNamePrompt = new System.Windows.Forms.Label();
            this.ButCreateUniversity = new System.Windows.Forms.Button();
            this.LabUniversityOpenPrompt = new System.Windows.Forms.Label();
            this.ButOpenUniFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TabUniversityView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBoxStudentInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GBoxPaperInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMenuItem,
            this.OpenMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Enabled = false;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(158, 22);
            this.SaveMenuItem.Text = "Save University";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItemClick);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(158, 22);
            this.OpenMenuItem.Text = "Open University";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItemClick);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudentMenuItem,
            this.AddPaperMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // AddStudentMenuItem
            // 
            this.AddStudentMenuItem.Enabled = false;
            this.AddStudentMenuItem.Name = "AddStudentMenuItem";
            this.AddStudentMenuItem.Size = new System.Drawing.Size(115, 22);
            this.AddStudentMenuItem.Text = "Student";
            this.AddStudentMenuItem.Click += new System.EventHandler(this.AddStudentMenuItemClick);
            // 
            // AddPaperMenuItem
            // 
            this.AddPaperMenuItem.Enabled = false;
            this.AddPaperMenuItem.Name = "AddPaperMenuItem";
            this.AddPaperMenuItem.Size = new System.Drawing.Size(115, 22);
            this.AddPaperMenuItem.Text = "Paper";
            this.AddPaperMenuItem.Click += new System.EventHandler(this.AddPaperMenuItemClick);
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(3, 36);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(243, 303);
            this.StudentListBox.TabIndex = 2;
            this.StudentListBox.SelectedIndexChanged += new System.EventHandler(this.StudentListBoxSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, -19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of Papers:";
            // 
            // PaperListBox
            // 
            this.PaperListBox.FormattingEnabled = true;
            this.PaperListBox.Location = new System.Drawing.Point(3, 36);
            this.PaperListBox.Name = "PaperListBox";
            this.PaperListBox.Size = new System.Drawing.Size(243, 303);
            this.PaperListBox.TabIndex = 4;
            this.PaperListBox.SelectedIndexChanged += new System.EventHandler(this.PaperListBoxSelectedIndexChanged);
            // 
            // TabUniversityView
            // 
            this.TabUniversityView.Controls.Add(this.tabPage1);
            this.TabUniversityView.Controls.Add(this.tabPage2);
            this.TabUniversityView.Location = new System.Drawing.Point(0, 64);
            this.TabUniversityView.Name = "TabUniversityView";
            this.TabUniversityView.SelectedIndex = 0;
            this.TabUniversityView.Size = new System.Drawing.Size(658, 405);
            this.TabUniversityView.TabIndex = 6;
            this.TabUniversityView.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabStudentInfoHint);
            this.tabPage1.Controls.Add(this.GBoxStudentInfo);
            this.tabPage1.Controls.Add(this.ButAddStudent);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.StudentListBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LabStudentInfoHint
            // 
            this.LabStudentInfoHint.AutoSize = true;
            this.LabStudentInfoHint.Location = new System.Drawing.Point(383, 153);
            this.LabStudentInfoHint.Name = "LabStudentInfoHint";
            this.LabStudentInfoHint.Size = new System.Drawing.Size(146, 13);
            this.LabStudentInfoHint.TabIndex = 18;
            this.LabStudentInfoHint.Text = "Select A Student To See Info";
            // 
            // GBoxStudentInfo
            // 
            this.GBoxStudentInfo.Controls.Add(this.LabNoPapersByStudent);
            this.GBoxStudentInfo.Controls.Add(this.label8);
            this.GBoxStudentInfo.Controls.Add(this.label7);
            this.GBoxStudentInfo.Controls.Add(this.label6);
            this.GBoxStudentInfo.Controls.Add(this.ComPaperList);
            this.GBoxStudentInfo.Controls.Add(this.EnrollSelectedStudentButton);
            this.GBoxStudentInfo.Controls.Add(this.label9);
            this.GBoxStudentInfo.Controls.Add(this.ListSelectedStudentPapers);
            this.GBoxStudentInfo.Controls.Add(this.LabSelectedStudentDOB);
            this.GBoxStudentInfo.Controls.Add(this.LabSelectedStudentID);
            this.GBoxStudentInfo.Controls.Add(this.LabSelectedStudentName);
            this.GBoxStudentInfo.Location = new System.Drawing.Point(262, 18);
            this.GBoxStudentInfo.Name = "GBoxStudentInfo";
            this.GBoxStudentInfo.Size = new System.Drawing.Size(385, 358);
            this.GBoxStudentInfo.TabIndex = 17;
            this.GBoxStudentInfo.TabStop = false;
            this.GBoxStudentInfo.Text = "Student Info";
            this.GBoxStudentInfo.Visible = false;
            // 
            // LabNoPapersByStudent
            // 
            this.LabNoPapersByStudent.AutoSize = true;
            this.LabNoPapersByStudent.Location = new System.Drawing.Point(88, 164);
            this.LabNoPapersByStudent.Name = "LabNoPapersByStudent";
            this.LabNoPapersByStudent.Size = new System.Drawing.Size(232, 13);
            this.LabNoPapersByStudent.TabIndex = 12;
            this.LabNoPapersByStudent.Text = "No Papers Currently Enrolled In By This Student";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Student Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Student ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Student Name:";
            // 
            // ComPaperList
            // 
            this.ComPaperList.FormattingEnabled = true;
            this.ComPaperList.Items.AddRange(new object[] {
            "Enroll Student In Paper....."});
            this.ComPaperList.Location = new System.Drawing.Point(12, 328);
            this.ComPaperList.Name = "ComPaperList";
            this.ComPaperList.Size = new System.Drawing.Size(235, 21);
            this.ComPaperList.TabIndex = 23;
            // 
            // EnrollSelectedStudentButton
            // 
            this.EnrollSelectedStudentButton.Location = new System.Drawing.Point(256, 328);
            this.EnrollSelectedStudentButton.Name = "EnrollSelectedStudentButton";
            this.EnrollSelectedStudentButton.Size = new System.Drawing.Size(120, 23);
            this.EnrollSelectedStudentButton.TabIndex = 22;
            this.EnrollSelectedStudentButton.Text = "Enroll";
            this.EnrollSelectedStudentButton.UseVisualStyleBackColor = true;
            this.EnrollSelectedStudentButton.Click += new System.EventHandler(this.EnrollSelectedStudentButtonClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Student\'s Enrolled Papers:";
            // 
            // ListSelectedStudentPapers
            // 
            this.ListSelectedStudentPapers.FormattingEnabled = true;
            this.ListSelectedStudentPapers.Location = new System.Drawing.Point(12, 136);
            this.ListSelectedStudentPapers.Name = "ListSelectedStudentPapers";
            this.ListSelectedStudentPapers.Size = new System.Drawing.Size(364, 186);
            this.ListSelectedStudentPapers.TabIndex = 20;
            // 
            // LabSelectedStudentDOB
            // 
            this.LabSelectedStudentDOB.AutoSize = true;
            this.LabSelectedStudentDOB.Location = new System.Drawing.Point(137, 79);
            this.LabSelectedStudentDOB.Name = "LabSelectedStudentDOB";
            this.LabSelectedStudentDOB.Size = new System.Drawing.Size(70, 13);
            this.LabSelectedStudentDOB.TabIndex = 19;
            this.LabSelectedStudentDOB.Text = "Student DOB";
            // 
            // LabSelectedStudentID
            // 
            this.LabSelectedStudentID.AutoSize = true;
            this.LabSelectedStudentID.Location = new System.Drawing.Point(137, 52);
            this.LabSelectedStudentID.Name = "LabSelectedStudentID";
            this.LabSelectedStudentID.Size = new System.Drawing.Size(58, 13);
            this.LabSelectedStudentID.TabIndex = 18;
            this.LabSelectedStudentID.Text = "Student ID";
            // 
            // LabSelectedStudentName
            // 
            this.LabSelectedStudentName.AutoSize = true;
            this.LabSelectedStudentName.Location = new System.Drawing.Point(137, 23);
            this.LabSelectedStudentName.Name = "LabSelectedStudentName";
            this.LabSelectedStudentName.Size = new System.Drawing.Size(75, 13);
            this.LabSelectedStudentName.TabIndex = 17;
            this.LabSelectedStudentName.Text = "Student Name";
            // 
            // ButAddStudent
            // 
            this.ButAddStudent.Location = new System.Drawing.Point(3, 342);
            this.ButAddStudent.Name = "ButAddStudent";
            this.ButAddStudent.Size = new System.Drawing.Size(28, 28);
            this.ButAddStudent.TabIndex = 5;
            this.ButAddStudent.Text = "+";
            this.ButAddStudent.UseVisualStyleBackColor = true;
            this.ButAddStudent.Click += new System.EventHandler(this.ButAddStudentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "List of Students:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabPaperInfoHint);
            this.tabPage2.Controls.Add(this.GBoxPaperInfo);
            this.tabPage2.Controls.Add(this.ButAddPaper);
            this.tabPage2.Controls.Add(this.PaperListBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Papers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabPaperInfoHint
            // 
            this.LabPaperInfoHint.AutoSize = true;
            this.LabPaperInfoHint.Location = new System.Drawing.Point(383, 153);
            this.LabPaperInfoHint.Name = "LabPaperInfoHint";
            this.LabPaperInfoHint.Size = new System.Drawing.Size(137, 13);
            this.LabPaperInfoHint.TabIndex = 23;
            this.LabPaperInfoHint.Text = "Select A Paper To See Info";
            // 
            // GBoxPaperInfo
            // 
            this.GBoxPaperInfo.Controls.Add(this.ComStudentList);
            this.GBoxPaperInfo.Controls.Add(this.LabNoStudentsByPaper);
            this.GBoxPaperInfo.Controls.Add(this.LabSelectedPaperID);
            this.GBoxPaperInfo.Controls.Add(this.LabSelectedPaperName);
            this.GBoxPaperInfo.Controls.Add(this.label12);
            this.GBoxPaperInfo.Controls.Add(this.label11);
            this.GBoxPaperInfo.Controls.Add(this.LabSelectedPaperCoordinator);
            this.GBoxPaperInfo.Controls.Add(this.ButEnrollStudentInSelectedPaper);
            this.GBoxPaperInfo.Controls.Add(this.label4);
            this.GBoxPaperInfo.Controls.Add(this.ListSelectedPaperStudents);
            this.GBoxPaperInfo.Controls.Add(this.label3);
            this.GBoxPaperInfo.Location = new System.Drawing.Point(262, 18);
            this.GBoxPaperInfo.Name = "GBoxPaperInfo";
            this.GBoxPaperInfo.Size = new System.Drawing.Size(385, 358);
            this.GBoxPaperInfo.TabIndex = 11;
            this.GBoxPaperInfo.TabStop = false;
            this.GBoxPaperInfo.Text = "Paper Info";
            this.GBoxPaperInfo.Visible = false;
            // 
            // ComStudentList
            // 
            this.ComStudentList.FormattingEnabled = true;
            this.ComStudentList.Items.AddRange(new object[] {
            "Select A Student To Enroll..."});
            this.ComStudentList.Location = new System.Drawing.Point(12, 328);
            this.ComStudentList.Name = "ComStudentList";
            this.ComStudentList.Size = new System.Drawing.Size(235, 21);
            this.ComStudentList.TabIndex = 23;
            // 
            // LabNoStudentsByPaper
            // 
            this.LabNoStudentsByPaper.AutoSize = true;
            this.LabNoStudentsByPaper.Location = new System.Drawing.Point(88, 164);
            this.LabNoStudentsByPaper.Name = "LabNoStudentsByPaper";
            this.LabNoStudentsByPaper.Size = new System.Drawing.Size(217, 13);
            this.LabNoStudentsByPaper.TabIndex = 11;
            this.LabNoStudentsByPaper.Text = "No Students Currently Enrolled In This Paper";
            // 
            // LabSelectedPaperID
            // 
            this.LabSelectedPaperID.AutoSize = true;
            this.LabSelectedPaperID.Location = new System.Drawing.Point(137, 52);
            this.LabSelectedPaperID.Name = "LabSelectedPaperID";
            this.LabSelectedPaperID.Size = new System.Drawing.Size(49, 13);
            this.LabSelectedPaperID.TabIndex = 22;
            this.LabSelectedPaperID.Text = "Paper ID";
            // 
            // LabSelectedPaperName
            // 
            this.LabSelectedPaperName.AutoSize = true;
            this.LabSelectedPaperName.Location = new System.Drawing.Point(137, 23);
            this.LabSelectedPaperName.Name = "LabSelectedPaperName";
            this.LabSelectedPaperName.Size = new System.Drawing.Size(66, 13);
            this.LabSelectedPaperName.TabIndex = 21;
            this.LabSelectedPaperName.Text = "Paper Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Paper ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Paper Name:";
            // 
            // LabSelectedPaperCoordinator
            // 
            this.LabSelectedPaperCoordinator.AutoSize = true;
            this.LabSelectedPaperCoordinator.Location = new System.Drawing.Point(137, 79);
            this.LabSelectedPaperCoordinator.Name = "LabSelectedPaperCoordinator";
            this.LabSelectedPaperCoordinator.Size = new System.Drawing.Size(95, 13);
            this.LabSelectedPaperCoordinator.TabIndex = 18;
            this.LabSelectedPaperCoordinator.Text = "Paper Co-ordinator";
            // 
            // ButEnrollStudentInSelectedPaper
            // 
            this.ButEnrollStudentInSelectedPaper.Location = new System.Drawing.Point(256, 328);
            this.ButEnrollStudentInSelectedPaper.Name = "ButEnrollStudentInSelectedPaper";
            this.ButEnrollStudentInSelectedPaper.Size = new System.Drawing.Size(120, 23);
            this.ButEnrollStudentInSelectedPaper.TabIndex = 17;
            this.ButEnrollStudentInSelectedPaper.Text = "Enroll";
            this.ButEnrollStudentInSelectedPaper.UseVisualStyleBackColor = true;
            this.ButEnrollStudentInSelectedPaper.Click += new System.EventHandler(this.ButEnrollStudentInSelectedPaperClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Students Enrolled In This Paper:";
            // 
            // ListSelectedPaperStudents
            // 
            this.ListSelectedPaperStudents.FormattingEnabled = true;
            this.ListSelectedPaperStudents.Location = new System.Drawing.Point(12, 136);
            this.ListSelectedPaperStudents.Name = "ListSelectedPaperStudents";
            this.ListSelectedPaperStudents.Size = new System.Drawing.Size(364, 186);
            this.ListSelectedPaperStudents.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Paper Co-ordinator:";
            // 
            // ButAddPaper
            // 
            this.ButAddPaper.Location = new System.Drawing.Point(3, 342);
            this.ButAddPaper.Name = "ButAddPaper";
            this.ButAddPaper.Size = new System.Drawing.Size(28, 28);
            this.ButAddPaper.TabIndex = 6;
            this.ButAddPaper.Text = "+";
            this.ButAddPaper.UseVisualStyleBackColor = true;
            this.ButAddPaper.Click += new System.EventHandler(this.ButAddPaperClick);
            // 
            // LABUniversityName
            // 
            this.LABUniversityName.AutoSize = true;
            this.LABUniversityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABUniversityName.Location = new System.Drawing.Point(256, 33);
            this.LABUniversityName.Name = "LABUniversityName";
            this.LABUniversityName.Size = new System.Drawing.Size(122, 16);
            this.LABUniversityName.TabIndex = 7;
            this.LABUniversityName.Text = "University Name";
            this.LABUniversityName.Visible = false;
            // 
            // TxtUniversityName
            // 
            this.TxtUniversityName.Location = new System.Drawing.Point(106, 78);
            this.TxtUniversityName.Name = "TxtUniversityName";
            this.TxtUniversityName.Size = new System.Drawing.Size(357, 20);
            this.TxtUniversityName.TabIndex = 8;
            // 
            // LabUniversityNamePrompt
            // 
            this.LabUniversityNamePrompt.AutoSize = true;
            this.LabUniversityNamePrompt.Location = new System.Drawing.Point(107, 62);
            this.LabUniversityNamePrompt.Name = "LabUniversityNamePrompt";
            this.LabUniversityNamePrompt.Size = new System.Drawing.Size(171, 13);
            this.LabUniversityNamePrompt.TabIndex = 9;
            this.LabUniversityNamePrompt.Text = "Enter A University Name To Begin:";
            // 
            // ButCreateUniversity
            // 
            this.ButCreateUniversity.Location = new System.Drawing.Point(476, 75);
            this.ButCreateUniversity.Name = "ButCreateUniversity";
            this.ButCreateUniversity.Size = new System.Drawing.Size(75, 23);
            this.ButCreateUniversity.TabIndex = 10;
            this.ButCreateUniversity.Text = "Create";
            this.ButCreateUniversity.UseVisualStyleBackColor = true;
            this.ButCreateUniversity.Click += new System.EventHandler(this.ButCreateUniversityClick);
            // 
            // LabUniversityOpenPrompt
            // 
            this.LabUniversityOpenPrompt.AutoSize = true;
            this.LabUniversityOpenPrompt.Location = new System.Drawing.Point(227, 118);
            this.LabUniversityOpenPrompt.Name = "LabUniversityOpenPrompt";
            this.LabUniversityOpenPrompt.Size = new System.Drawing.Size(143, 13);
            this.LabUniversityOpenPrompt.TabIndex = 11;
            this.LabUniversityOpenPrompt.Text = "Or Open An Existing Uni File:";
            // 
            // ButOpenUniFile
            // 
            this.ButOpenUniFile.Location = new System.Drawing.Point(261, 137);
            this.ButOpenUniFile.Name = "ButOpenUniFile";
            this.ButOpenUniFile.Size = new System.Drawing.Size(75, 25);
            this.ButOpenUniFile.TabIndex = 12;
            this.ButOpenUniFile.Text = "Open...";
            this.ButOpenUniFile.UseVisualStyleBackColor = true;
            this.ButOpenUniFile.Click += new System.EventHandler(this.ButOpenUniFileClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 469);
            this.Controls.Add(this.ButOpenUniFile);
            this.Controls.Add(this.LabUniversityOpenPrompt);
            this.Controls.Add(this.ButCreateUniversity);
            this.Controls.Add(this.LabUniversityNamePrompt);
            this.Controls.Add(this.TxtUniversityName);
            this.Controls.Add(this.LABUniversityName);
            this.Controls.Add(this.TabUniversityView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Uni Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabUniversityView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBoxStudentInfo.ResumeLayout(false);
            this.GBoxStudentInfo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GBoxPaperInfo.ResumeLayout(false);
            this.GBoxPaperInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStudentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPaperMenuItem;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PaperListBox;
        private System.Windows.Forms.TabControl TabUniversityView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButAddPaper;
        private System.Windows.Forms.Button ButAddStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LABUniversityName;
        private System.Windows.Forms.TextBox TxtUniversityName;
        private System.Windows.Forms.Label LabUniversityNamePrompt;
        private System.Windows.Forms.Button ButCreateUniversity;
        private System.Windows.Forms.GroupBox GBoxStudentInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComPaperList;
        private System.Windows.Forms.Button EnrollSelectedStudentButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox ListSelectedStudentPapers;
        private System.Windows.Forms.Label LabSelectedStudentDOB;
        private System.Windows.Forms.Label LabSelectedStudentID;
        private System.Windows.Forms.Label LabSelectedStudentName;
        private System.Windows.Forms.Label LabStudentInfoHint;
        private System.Windows.Forms.GroupBox GBoxPaperInfo;
        private System.Windows.Forms.Label LabPaperInfoHint;
        private System.Windows.Forms.Label LabSelectedPaperID;
        private System.Windows.Forms.Label LabSelectedPaperName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabSelectedPaperCoordinator;
        private System.Windows.Forms.Button ButEnrollStudentInSelectedPaper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListSelectedPaperStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComStudentList;
        private System.Windows.Forms.Label LabNoPapersByStudent;
        private System.Windows.Forms.Label LabNoStudentsByPaper;
        private System.Windows.Forms.Label LabUniversityOpenPrompt;
        private System.Windows.Forms.Button ButOpenUniFile;
    }
}

