namespace Okna
{
    partial class Test
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
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.labelUserGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserLogin.Location = new System.Drawing.Point(94, 192);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(195, 58);
            this.labelUserLogin.TabIndex = 0;
            this.labelUserLogin.Text = "Payudg";
            this.labelUserLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUserGender
            // 
            this.labelUserGender.AutoSize = true;
            this.labelUserGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserGender.Location = new System.Drawing.Point(94, 55);
            this.labelUserGender.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelUserGender.Name = "labelUserGender";
            this.labelUserGender.Size = new System.Drawing.Size(131, 58);
            this.labelUserGender.TabIndex = 1;
            this.labelUserGender.Text = "User";
            this.labelUserGender.Click += new System.EventHandler(this.label2_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 58F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 502);
            this.Controls.Add(this.labelUserGender);
            this.Controls.Add(this.labelUserLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label labelUserGender;
    }
}