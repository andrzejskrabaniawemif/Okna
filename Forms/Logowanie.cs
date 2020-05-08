using Okna.Forms;
using Okna.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna
{
    public partial class Logowanie : Form
    {
        EkranPowitalny ekranPowitalny; 
        public Logowanie(EkranPowitalny ekranPowitalny)
        {
            this.ekranPowitalny = ekranPowitalny;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            ekranPowitalny.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            Account user = new Account(textBoxLogin.Text, textBoxPassword.Text);

            if (user.VerifyLoginandPassword() == true)
            {
                user.SetOtherData();
                new BMRCPM(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Zły login lub hasło", "Informacja");
            }

            
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
    }
}
