
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
using System.Globalization;
using System.Threading;

namespace Okna.Forms
{
    public partial class BMRCPM : Form
    {

        Account user;
       
        int age;
        decimal CPM;
        public BMRCPM(Account user)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            this.user = user;
            InitializeComponent();
            dateTimePickerDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            age = CalculateAge();
            textBoxAge.Text = age.ToString();
            textBoxHeight.Text = user.height.ToString();
            comboBoxActivity.Text = "Wybierz stopien aktywności";

        }

       
        public int CalculateAge()
        {
            var today = DateTime.Today;
            string pattern = "dd.MM.yyyy";
            var birthDate = DateTime.ParseExact(user.dateBirth, pattern, null);
            var age = today.Year - birthDate.Year;
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
                coef = 1.2M;
            }
            else if (comboBoxActivity.SelectedIndex == 1)
            {
                coef = 1.6M;
            }
            else
            {
                coef = 2.1M;
            }

            History history = new History(age, Convert.ToDecimal(numericUpDownWeight.Value), dateTimePickerDate.Text, coef, user.height);

            history.AddNewRecord(user.ID);

            textBoxBMR.Text = history.BMR.ToString() +" kcal";
            textBoxCPM.Text = history.CPM.ToString() +" kcal";
            CPM = history.CPM;

        }

        private void Analyze_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Analiza(user, CPM).Show();
            
        }

        private void BMRCPM_Load(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EkranPowitalny().Show();
        }
    }
}
