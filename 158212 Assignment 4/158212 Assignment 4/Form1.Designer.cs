namespace _158212_Assignment_4 {
    partial class TextAnalyst {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TotalWordsStatisticsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchWordButton = new System.Windows.Forms.Button();
            this.SearchLengthButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AverageWordLengthTextBox = new System.Windows.Forms.TextBox();
            this.SearchBoxTextBox = new System.Windows.Forms.TextBox();
            this.ShortestWordsTextBox = new System.Windows.Forms.TextBox();
            this.LongestWordsTextBox = new System.Windows.Forms.TextBox();
            this.SearchResultTextBox = new System.Windows.Forms.TextBox();
            this.MostCommonWordsTextBox = new System.Windows.Forms.TextBox();
            this.SearchWordResultTextBox = new System.Windows.Forms.TextBox();
            this.UniqueWordsTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WordFreqChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OpenFilePromptLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.WordTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordFreqChart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.openFileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalWordsStatisticsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1041, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TotalWordsStatisticsLabel
            // 
            this.TotalWordsStatisticsLabel.Name = "TotalWordsStatisticsLabel";
            this.TotalWordsStatisticsLabel.Size = new System.Drawing.Size(114, 17);
            this.TotalWordsStatisticsLabel.Text = "TotalWordsStatistics";
            this.TotalWordsStatisticsLabel.Visible = false;
            // 
            // WordTabControl
            // 
            this.WordTabControl.Controls.Add(this.tabPage1);
            this.WordTabControl.Controls.Add(this.tabPage2);
            this.WordTabControl.Location = new System.Drawing.Point(0, 25);
            this.WordTabControl.Name = "WordTabControl";
            this.WordTabControl.SelectedIndex = 0;
            this.WordTabControl.Size = new System.Drawing.Size(1041, 450);
            this.WordTabControl.TabIndex = 15;
            this.WordTabControl.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ErrorLabel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.SearchWordButton);
            this.tabPage1.Controls.Add(this.SearchLengthButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TitleLabel);
            this.tabPage1.Controls.Add(this.AverageWordLengthTextBox);
            this.tabPage1.Controls.Add(this.SearchBoxTextBox);
            this.tabPage1.Controls.Add(this.ShortestWordsTextBox);
            this.tabPage1.Controls.Add(this.LongestWordsTextBox);
            this.tabPage1.Controls.Add(this.SearchResultTextBox);
            this.tabPage1.Controls.Add(this.MostCommonWordsTextBox);
            this.tabPage1.Controls.Add(this.SearchWordResultTextBox);
            this.tabPage1.Controls.Add(this.UniqueWordsTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Search Text:";
            // 
            // SearchWordButton
            // 
            this.SearchWordButton.Location = new System.Drawing.Point(529, 237);
            this.SearchWordButton.Name = "SearchWordButton";
            this.SearchWordButton.Size = new System.Drawing.Size(91, 23);
            this.SearchWordButton.TabIndex = 23;
            this.SearchWordButton.Text = "Search Word";
            this.SearchWordButton.UseVisualStyleBackColor = true;
            this.SearchWordButton.Click += new System.EventHandler(this.SearchWordButtonClick);
            // 
            // SearchLengthButton
            // 
            this.SearchLengthButton.Location = new System.Drawing.Point(423, 237);
            this.SearchLengthButton.Name = "SearchLengthButton";
            this.SearchLengthButton.Size = new System.Drawing.Size(91, 23);
            this.SearchLengthButton.TabIndex = 22;
            this.SearchLengthButton.Text = "Search Length";
            this.SearchLengthButton.UseVisualStyleBackColor = true;
            this.SearchLengthButton.Click += new System.EventHandler(this.SearchLengthButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Shortest Word(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(807, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Average Unique Word Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(819, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "All Unique Words in Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Longest Word(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Most Common Word(s):";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(400, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(230, 22);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Analysis of FileName.txt";
            // 
            // AverageWordLengthTextBox
            // 
            this.AverageWordLengthTextBox.Location = new System.Drawing.Point(721, 369);
            this.AverageWordLengthTextBox.Name = "AverageWordLengthTextBox";
            this.AverageWordLengthTextBox.ReadOnly = true;
            this.AverageWordLengthTextBox.Size = new System.Drawing.Size(295, 20);
            this.AverageWordLengthTextBox.TabIndex = 8;
            this.AverageWordLengthTextBox.Text = "AverageWordLength";
            // 
            // SearchBoxTextBox
            // 
            this.SearchBoxTextBox.Location = new System.Drawing.Point(423, 210);
            this.SearchBoxTextBox.Name = "SearchBoxTextBox";
            this.SearchBoxTextBox.Size = new System.Drawing.Size(197, 20);
            this.SearchBoxTextBox.TabIndex = 15;
            // 
            // ShortestWordsTextBox
            // 
            this.ShortestWordsTextBox.Location = new System.Drawing.Point(23, 309);
            this.ShortestWordsTextBox.Multiline = true;
            this.ShortestWordsTextBox.Name = "ShortestWordsTextBox";
            this.ShortestWordsTextBox.ReadOnly = true;
            this.ShortestWordsTextBox.Size = new System.Drawing.Size(295, 80);
            this.ShortestWordsTextBox.TabIndex = 7;
            this.ShortestWordsTextBox.Text = "ShortestWords";
            // 
            // LongestWordsTextBox
            // 
            this.LongestWordsTextBox.Location = new System.Drawing.Point(23, 195);
            this.LongestWordsTextBox.Multiline = true;
            this.LongestWordsTextBox.Name = "LongestWordsTextBox";
            this.LongestWordsTextBox.ReadOnly = true;
            this.LongestWordsTextBox.Size = new System.Drawing.Size(295, 80);
            this.LongestWordsTextBox.TabIndex = 6;
            this.LongestWordsTextBox.Text = "Longest words";
            // 
            // SearchResultTextBox
            // 
            this.SearchResultTextBox.Location = new System.Drawing.Point(361, 305);
            this.SearchResultTextBox.Multiline = true;
            this.SearchResultTextBox.Name = "SearchResultTextBox";
            this.SearchResultTextBox.Size = new System.Drawing.Size(317, 84);
            this.SearchResultTextBox.TabIndex = 13;
            this.SearchResultTextBox.Text = "SearchResult";
            this.SearchResultTextBox.Visible = false;
            // 
            // MostCommonWordsTextBox
            // 
            this.MostCommonWordsTextBox.Location = new System.Drawing.Point(23, 65);
            this.MostCommonWordsTextBox.Multiline = true;
            this.MostCommonWordsTextBox.Name = "MostCommonWordsTextBox";
            this.MostCommonWordsTextBox.ReadOnly = true;
            this.MostCommonWordsTextBox.Size = new System.Drawing.Size(295, 90);
            this.MostCommonWordsTextBox.TabIndex = 5;
            this.MostCommonWordsTextBox.Text = "Most Common";
            // 
            // SearchWordResultTextBox
            // 
            this.SearchWordResultTextBox.Location = new System.Drawing.Point(475, -53);
            this.SearchWordResultTextBox.Multiline = true;
            this.SearchWordResultTextBox.Name = "SearchWordResultTextBox";
            this.SearchWordResultTextBox.Size = new System.Drawing.Size(289, 39);
            this.SearchWordResultTextBox.TabIndex = 12;
            this.SearchWordResultTextBox.Text = "SearchWordResults";
            // 
            // UniqueWordsTextBox
            // 
            this.UniqueWordsTextBox.Location = new System.Drawing.Point(721, 65);
            this.UniqueWordsTextBox.Multiline = true;
            this.UniqueWordsTextBox.Name = "UniqueWordsTextBox";
            this.UniqueWordsTextBox.ReadOnly = true;
            this.UniqueWordsTextBox.Size = new System.Drawing.Size(295, 276);
            this.UniqueWordsTextBox.TabIndex = 11;
            this.UniqueWordsTextBox.Text = "UniqueWordBox";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.WordFreqChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WordFreqChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WordFreqChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.WordFreqChart.Legends.Add(legend2);
            this.WordFreqChart.Location = new System.Drawing.Point(0, 6);
            this.WordFreqChart.Name = "WordFreqChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.WordFreqChart.Series.Add(series2);
            this.WordFreqChart.Size = new System.Drawing.Size(1033, 418);
            this.WordFreqChart.TabIndex = 15;
            this.WordFreqChart.Text = "chart1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OpenFileButton.Location = new System.Drawing.Point(468, 256);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 21;
            this.OpenFileButton.Text = "Open...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButtonClick);
            // 
            // OpenFilePromptLabel
            // 
            this.OpenFilePromptLabel.AutoSize = true;
            this.OpenFilePromptLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFilePromptLabel.Location = new System.Drawing.Point(359, 222);
            this.OpenFilePromptLabel.Name = "OpenFilePromptLabel";
            this.OpenFilePromptLabel.Size = new System.Drawing.Size(323, 32);
            this.OpenFilePromptLabel.TabIndex = 20;
            this.OpenFilePromptLabel.Text = "Please Open A Text File";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(420, 272);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(58, 13);
            this.ErrorLabel.TabIndex = 25;
            this.ErrorLabel.Text = "Error Label";
            this.ErrorLabel.Visible = false;
            // 
            // TextAnalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 500);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.OpenFilePromptLabel);
            this.Controls.Add(this.WordTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextAnalyst";
            this.Text = "TextAnalyst";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.WordTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WordFreqChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TotalWordsStatisticsLabel;
        private System.Windows.Forms.TabControl WordTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox AverageWordLengthTextBox;
        private System.Windows.Forms.TextBox ShortestWordsTextBox;
        private System.Windows.Forms.TextBox LongestWordsTextBox;
        private System.Windows.Forms.TextBox MostCommonWordsTextBox;
        private System.Windows.Forms.TextBox SearchResultTextBox;
        private System.Windows.Forms.TextBox SearchWordResultTextBox;
        private System.Windows.Forms.TextBox UniqueWordsTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart WordFreqChart;
        private System.Windows.Forms.TextBox SearchBoxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SearchWordButton;
        private System.Windows.Forms.Button SearchLengthButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label OpenFilePromptLabel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

