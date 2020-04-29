using DietCalc.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna.Forms
{
    public partial class BMRCPM : Form
    {
        Account user;
        int age;
        public BMRCPM(Account user)
        {
            this.user = user;
            InitializeComponent();
            age = CalculateAge();
            textBoxAge.Text = age.ToString();
            textBoxHeight.Text = user.height.ToString();
        }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            string pattern = "dd.MM.yyyy";
            var birthDate = DateTime.ParseExact(user.dateBirth, pattern, null);
            //obliczamy wiek
            var age = today.Year - birthDate.Year;
            //sprawdzamy czy uzytkownik mial urodziny w tym roku czy nie
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            decimal coef;
            if(comboBoxActivity.SelectedIndex == 0)
            {
                coef = 1;
            }
            else if (comboBoxActivity.SelectedIndex == 1)
            {
                coef = 1.5M;
            }
            else
            {
                coef = 2;
            }
            History history = new History(age, numericUpDownWeight.Value, coef, user.height);
            textBoxBMR.Text = history.BMR.ToString() +" kcal";
            textBoxCPM.Text = history.CPM.ToString() +" kcal";
        }
    }
}
