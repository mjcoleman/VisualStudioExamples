namespace _158212_Assignment_2 {
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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CurrencyFromSelector = new System.Windows.Forms.ComboBox();
            this.CurrencyToSelector = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.ConversionInput = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConvertButton.Location = new System.Drawing.Point(129, 139);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(63, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(198, 139);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(55, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CurrencyFromSelector
            // 
            this.CurrencyFromSelector.FormattingEnabled = true;
            this.CurrencyFromSelector.Location = new System.Drawing.Point(129, 81);
            this.CurrencyFromSelector.Name = "CurrencyFromSelector";
            this.CurrencyFromSelector.Size = new System.Drawing.Size(124, 21);
            this.CurrencyFromSelector.TabIndex = 2;
            this.CurrencyFromSelector.SelectedIndexChanged += new System.EventHandler(this.CurrencyFromSelector_SelectedIndexChanged);
            // 
            // CurrencyToSelector
            // 
            this.CurrencyToSelector.FormattingEnabled = true;
            this.CurrencyToSelector.Location = new System.Drawing.Point(129, 112);
            this.CurrencyToSelector.Name = "CurrencyToSelector";
            this.CurrencyToSelector.Size = new System.Drawing.Size(124, 21);
            this.CurrencyToSelector.TabIndex = 3;
            this.CurrencyToSelector.SelectedIndexChanged += new System.EventHandler(this.CurrencyToSelector_SelectedIndexChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(12, 174);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(353, 19);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResultLabel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(16, 174);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(349, 19);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Error";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ErrorLabel.Visible = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.Location = new System.Drawing.Point(42, 9);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(283, 32);
            this.LogoLabel.TabIndex = 6;
            this.LogoLabel.Text = "Currency Converter";
            // 
            // ConversionInput
            // 
            this.ConversionInput.Location = new System.Drawing.Point(129, 55);
            this.ConversionInput.Name = "ConversionInput";
            this.ConversionInput.Size = new System.Drawing.Size(124, 20);
            this.ConversionInput.TabIndex = 7;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(90, 84);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(33, 13);
            this.FromLabel.TabIndex = 8;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(100, 114);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(23, 13);
            this.ToLabel.TabIndex = 9;
            this.ToLabel.Text = "To:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(77, 57);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // Form1
            // 
            this.AcceptButton = this.ConvertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 210);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CurrencyFromSelector);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.ConversionInput);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CurrencyToSelector);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConvertButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ComboBox CurrencyFromSelector;
        private System.Windows.Forms.ComboBox CurrencyToSelector;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.TextBox ConversionInput;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label AmountLabel;
    }
}

