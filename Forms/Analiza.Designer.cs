namespace Okna.Forms
{
    partial class Analiza
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.comboBoxMacronutritions = new System.Windows.Forms.ComboBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelMacronutritions = new System.Windows.Forms.Label();
            this.labelProtein = new System.Windows.Forms.Label();
            this.labelCarbo = new System.Windows.Forms.Label();
            this.labelFat = new System.Windows.Forms.Label();
            this.textBoxFatG = new System.Windows.Forms.TextBox();
            this.textBoxCarboG = new System.Windows.Forms.TextBox();
            this.textBoxProteinG = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.chartMacronutritions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMacronutritions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.AutoCompleteCustomSource.AddRange(new string[] {
            "Redukcja",
            "Masa"});
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Items.AddRange(new object[] {
            "Redukcja",
            "Masa"});
            this.comboBoxTarget.Location = new System.Drawing.Point(140, 28);
            this.comboBoxTarget.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(220, 24);
            this.comboBoxTarget.TabIndex = 0;
            // 
            // comboBoxMacronutritions
            // 
            this.comboBoxMacronutritions.AutoCompleteCustomSource.AddRange(new string[] {
            "Własne",
            "Standardowe"});
            this.comboBoxMacronutritions.FormattingEnabled = true;
            this.comboBoxMacronutritions.Items.AddRange(new object[] {
            "Standardowe",
            "Własne"});
            this.comboBoxMacronutritions.Location = new System.Drawing.Point(140, 73);
            this.comboBoxMacronutritions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMacronutritions.Name = "comboBoxMacronutritions";
            this.comboBoxMacronutritions.Size = new System.Drawing.Size(220, 24);
            this.comboBoxMacronutritions.TabIndex = 2;
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(103, 32);
            this.labelTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(28, 17);
            this.labelTarget.TabIndex = 8;
            this.labelTarget.Text = "Cel";
            // 
            // labelMacronutritions
            // 
            this.labelMacronutritions.AutoSize = true;
            this.labelMacronutritions.Location = new System.Drawing.Point(25, 76);
            this.labelMacronutritions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMacronutritions.Name = "labelMacronutritions";
            this.labelMacronutritions.Size = new System.Drawing.Size(101, 17);
            this.labelMacronutritions.TabIndex = 9;
            this.labelMacronutritions.Text = "Makroskładniki";
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(465, 33);
            this.labelProtein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(46, 17);
            this.labelProtein.TabIndex = 10;
            this.labelProtein.Text = "Białko";
            // 
            // labelCarbo
            // 
            this.labelCarbo.AutoSize = true;
            this.labelCarbo.Location = new System.Drawing.Point(420, 78);
            this.labelCarbo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCarbo.Name = "labelCarbo";
            this.labelCarbo.Size = new System.Drawing.Size(88, 17);
            this.labelCarbo.TabIndex = 11;
            this.labelCarbo.Text = "Węlowodany";
            // 
            // labelFat
            // 
            this.labelFat.AutoSize = true;
            this.labelFat.Location = new System.Drawing.Point(444, 121);
            this.labelFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFat.Name = "labelFat";
            this.labelFat.Size = new System.Drawing.Size(64, 17);
            this.labelFat.TabIndex = 12;
            this.labelFat.Text = "Tłuszcze";
            // 
            // textBoxFatG
            // 
            this.textBoxFatG.Location = new System.Drawing.Point(525, 118);
            this.textBoxFatG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFatG.Name = "textBoxFatG";
            this.textBoxFatG.Size = new System.Drawing.Size(195, 22);
            this.textBoxFatG.TabIndex = 15;
            // 
            // textBoxCarboG
            // 
            this.textBoxCarboG.Location = new System.Drawing.Point(525, 75);
            this.textBoxCarboG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarboG.Name = "textBoxCarboG";
            this.textBoxCarboG.Size = new System.Drawing.Size(195, 22);
            this.textBoxCarboG.TabIndex = 14;
            // 
            // textBoxProteinG
            // 
            this.textBoxProteinG.Location = new System.Drawing.Point(525, 31);
            this.textBoxProteinG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProteinG.Name = "textBoxProteinG";
            this.textBoxProteinG.Size = new System.Drawing.Size(195, 22);
            this.textBoxProteinG.TabIndex = 13;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(140, 113);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(111, 28);
            this.buttonCalc.TabIndex = 16;
            this.buttonCalc.Text = "Oblicz";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(251, 113);
            this.buttonHistory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(111, 28);
            this.buttonHistory.TabIndex = 17;
            this.buttonHistory.Text = "Historia wagi";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // chartMacronutritions
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMacronutritions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMacronutritions.Legends.Add(legend1);
            this.chartMacronutritions.Location = new System.Drawing.Point(140, 188);
            this.chartMacronutritions.Margin = new System.Windows.Forms.Padding(4);
            this.chartMacronutritions.Name = "chartMacronutritions";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "S1";
            this.chartMacronutritions.Series.Add(series1);
            this.chartMacronutritions.Size = new System.Drawing.Size(797, 396);
            this.chartMacronutritions.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "[g]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "[g]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "[g]";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(251, 149);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 28);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(140, 149);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 28);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Wyjdź";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Analiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 607);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMacronutritions);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxFatG);
            this.Controls.Add(this.textBoxCarboG);
            this.Controls.Add(this.textBoxProteinG);
            this.Controls.Add(this.labelFat);
            this.Controls.Add(this.labelCarbo);
            this.Controls.Add(this.labelProtein);
            this.Controls.Add(this.labelMacronutritions);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.comboBoxMacronutritions);
            this.Controls.Add(this.comboBoxTarget);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Analiza";
            this.Text = " Analiza";
            this.Load += new System.EventHandler(this.Analiza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMacronutritions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.ComboBox comboBoxMacronutritions;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label labelMacronutritions;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Label labelCarbo;
        private System.Windows.Forms.Label labelFat;
        private System.Windows.Forms.TextBox textBoxFatG;
        private System.Windows.Forms.TextBox textBoxCarboG;
        private System.Windows.Forms.TextBox textBoxProteinG;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMacronutritions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}