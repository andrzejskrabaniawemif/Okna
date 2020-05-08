namespace Okna.Forms
{
    partial class Wykres
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
            this.chartHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHistory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistory.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistory.Legends.Add(legend1);
            this.chartHistory.Location = new System.Drawing.Point(0, 0);
            this.chartHistory.Name = "chartHistory";
            this.chartHistory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Waga";
            this.chartHistory.Series.Add(series1);
            this.chartHistory.Size = new System.Drawing.Size(922, 515);
            this.chartHistory.TabIndex = 0;
            this.chartHistory.Text = "chart1";
            // 
            // Wykres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 519);
            this.Controls.Add(this.chartHistory);
            this.Name = "Wykres";
            this.Text = "Wykres histori zmian wagi";
            this.Load += new System.EventHandler(this.Wykres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistory;
    }
}