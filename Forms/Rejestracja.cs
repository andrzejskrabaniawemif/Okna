using DietCalc.Classes;
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
        public Rejestracja()
        {
            InitializeComponent();
            dateTimePickerDateBirth.CustomFormat = "dd.MM.yyyy";
            dateTimePickerDateBirth.Format = DateTimePickerFormat.Custom;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Account user = new Account(textBoxLogin.Text, textBoxPassword.Text, dateTimePickerDateBirth.Text, comboBoxGender.SelectedIndex, Decimal.ToInt32(numericUpDownHeight.Value));
            new BMRCPM(user).Show();
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
