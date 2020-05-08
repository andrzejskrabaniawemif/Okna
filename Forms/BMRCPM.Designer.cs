namespace Okna.Forms
{
    partial class BMRCPM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAge = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.comboBoxActivity = new System.Windows.Forms.ComboBox();
            this.labelAcitvity = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelCPM = new System.Windows.Forms.Label();
            this.labelBMR = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxBMR = new System.Windows.Forms.TextBox();
            this.textBoxCPM = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.Analyze = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(55, 38);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 17);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Wiek";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(55, 85);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 17);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Waga";
            // 
            // comboBoxActivity
            // 
            this.comboBoxActivity.FormattingEnabled = true;
            this.comboBoxActivity.Items.AddRange(new object[] {
            "Niska",
            "Średnia",
            "Wysoka"});
            this.comboBoxActivity.Location = new System.Drawing.Point(119, 126);
            this.comboBoxActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxActivity.Name = "comboBoxActivity";
            this.comboBoxActivity.Size = new System.Drawing.Size(245, 24);
            this.comboBoxActivity.TabIndex = 7;
            // 
            // labelAcitvity
            // 
            this.labelAcitvity.AutoSize = true;
            this.labelAcitvity.Location = new System.Drawing.Point(27, 133);
            this.labelAcitvity.Name = "labelAcitvity";
            this.labelAcitvity.Size = new System.Drawing.Size(74, 17);
            this.labelAcitvity.TabIndex = 8;
            this.labelAcitvity.Text = "Aktywność";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(119, 290);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(245, 50);
            this.buttonCalc.TabIndex = 9;
            this.buttonCalc.Text = "Oblicz";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelCPM
            // 
            this.labelCPM.AutoSize = true;
            this.labelCPM.Location = new System.Drawing.Point(51, 419);
            this.labelCPM.Name = "labelCPM";
            this.labelCPM.Size = new System.Drawing.Size(37, 17);
            this.labelCPM.TabIndex = 11;
            this.labelCPM.Text = "CPM";
            // 
            // labelBMR
            // 
            this.labelBMR.AutoSize = true;
            this.labelBMR.Location = new System.Drawing.Point(55, 371);
            this.labelBMR.Name = "labelBMR";
            this.labelBMR.Size = new System.Drawing.Size(38, 17);
            this.labelBMR.TabIndex = 10;
            this.labelBMR.Text = "BMR";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(51, 181);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(52, 17);
            this.labelHeight.TabIndex = 15;
            this.labelHeight.Text = "Wzrost";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(119, 178);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(245, 22);
            this.textBoxHeight.TabIndex = 16;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Location = new System.Drawing.Point(119, 80);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(247, 22);
            this.numericUpDownWeight.TabIndex = 17;
            // 
            // textBoxBMR
            // 
            this.textBoxBMR.Enabled = false;
            this.textBoxBMR.Location = new System.Drawing.Point(119, 371);
            this.textBoxBMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBMR.Name = "textBoxBMR";
            this.textBoxBMR.Size = new System.Drawing.Size(245, 22);
            this.textBoxBMR.TabIndex = 21;
            // 
            // textBoxCPM
            // 
            this.textBoxCPM.Enabled = false;
            this.textBoxCPM.Location = new System.Drawing.Point(119, 415);
            this.textBoxCPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCPM.Name = "textBoxCPM";
            this.textBoxCPM.Size = new System.Drawing.Size(245, 22);
            this.textBoxCPM.TabIndex = 22;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(119, 33);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(245, 22);
            this.textBoxAge.TabIndex = 23;
            // 
            // Analyze
            // 
            this.Analyze.Location = new System.Drawing.Point(119, 468);
            this.Analyze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Analyze.Name = "Analyze";
            this.Analyze.Size = new System.Drawing.Size(245, 50);
            this.Analyze.TabIndex = 24;
            this.Analyze.Text = "Pełna analiza";
            this.Analyze.UseVisualStyleBackColor = true;
            this.Analyze.Click += new System.EventHandler(this.Analyze_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(119, 220);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerDate.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(119, 533);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(245, 50);
            this.buttonReturn.TabIndex = 27;
            this.buttonReturn.Text = "Powrót";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // BMRCPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 606);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Analyze);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxCPM);
            this.Controls.Add(this.textBoxBMR);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelCPM);
            this.Controls.Add(this.labelBMR);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelAcitvity);
            this.Controls.Add(this.comboBoxActivity);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelAge);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BMRCPM";
            this.Text = "Obliczanie BMR i CPM";
            this.Load += new System.EventHandler(this.BMRCPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ComboBox comboBoxActivity;
        private System.Windows.Forms.Label labelAcitvity;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelCPM;
        private System.Windows.Forms.Label labelBMR;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.TextBox textBoxBMR;
        private System.Windows.Forms.TextBox textBoxCPM;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button Analyze;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReturn;
    }
}