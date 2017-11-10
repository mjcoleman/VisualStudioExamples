namespace Sudoku {
    partial class Sudoku {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGGameBoardView = new System.Windows.Forms.DataGridView();
            this.BtnOpenSudoku = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGGameBoardView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGGameBoardView
            // 
            this.DGGameBoardView.AllowUserToAddRows = false;
            this.DGGameBoardView.AllowUserToDeleteRows = false;
            this.DGGameBoardView.AllowUserToResizeColumns = false;
            this.DGGameBoardView.AllowUserToResizeRows = false;
            this.DGGameBoardView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGGameBoardView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGGameBoardView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGGameBoardView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGGameBoardView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGGameBoardView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGGameBoardView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGGameBoardView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGGameBoardView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGGameBoardView.Location = new System.Drawing.Point(12, 12);
            this.DGGameBoardView.MultiSelect = false;
            this.DGGameBoardView.Name = "DGGameBoardView";
            this.DGGameBoardView.RowHeadersVisible = false;
            this.DGGameBoardView.Size = new System.Drawing.Size(203, 257);
            this.DGGameBoardView.TabIndex = 0;
            this.DGGameBoardView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDidChange);
            // 
            // BtnOpenSudoku
            // 
            this.BtnOpenSudoku.Location = new System.Drawing.Point(67, 300);
            this.BtnOpenSudoku.Name = "BtnOpenSudoku";
            this.BtnOpenSudoku.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenSudoku.TabIndex = 1;
            this.BtnOpenSudoku.Text = "Open Puzzle";
            this.BtnOpenSudoku.UseVisualStyleBackColor = true;
            this.BtnOpenSudoku.Click += new System.EventHandler(this.BtnOpenSudokuClick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 278);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status:";
            this.StatusLabel.Visible = false;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 335);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BtnOpenSudoku);
            this.Controls.Add(this.DGGameBoardView);
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.DGGameBoardView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGGameBoardView;
        private System.Windows.Forms.Button BtnOpenSudoku;
        private System.Windows.Forms.Label StatusLabel;
    }
}

