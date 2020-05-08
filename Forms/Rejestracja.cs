using Okna.Classes;
using Okna.Forms;
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
    public partial class Rejestracja : Form
    {
        EkranPowitalny ekranPowitalny;
        public Rejestracja(EkranPowitalny ekranPowitalny)
        {
            this.ekranPowitalny = ekranPowitalny;
            InitializeComponent();
            dateTimePickerDateBirth.CustomFormat = "dd.MM.yyyy";
            dateTimePickerDateBirth.Format = DateTimePickerFormat.Custom;
            comboBoxGender.Text = "Wybierz płeć";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Account user = new Account(textBoxLogin.Text, textBoxPassword.Text, dateTimePickerDateBirth.Text, comboBoxGender.SelectedIndex +1, Decimal.ToInt32(numericUpDownHeight.Value));

            if (user.CreateAccount() == true)
            {
                this.Hide();
                new BMRCPM(user).Show();
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ekranPowitalny.Show();
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
    }
}
