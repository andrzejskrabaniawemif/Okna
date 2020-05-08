using DietCalc.Classes;
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

namespace Okna.Forms
{
    public partial class Analiza : Form
    {
        decimal CPM;
        Account user;

        public Analiza(Account user, decimal CPM)
        {
            this.CPM = CPM;
            this.user = user;
            InitializeComponent();
            comboBoxTarget.Text = "Wybierz cel";
            comboBoxMacronutritions.Text = "Wybierz makroskładniki";

        }

        

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            new Wykres(user).Show();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            decimal coef;

            if (comboBoxTarget.SelectedIndex == 0)
            {
                coef = 1.85M;
            }
            else
            {
                coef = 2.15M;
            }
            Macronutritions macronutritions = new Macronutritions(CPM, coef, comboBoxMacronutritions.SelectedIndex);


            textBoxCarboG.Text = Math.Round(macronutritions.carbo).ToString();
            textBoxProteinG.Text = Math.Round(macronutritions.protein).ToString();
            textBoxFatG.Text = Math.Round(macronutritions.fat).ToString();


            chartMacronutritions.Series["S1"].IsValueShownAsLabel = true;
            chartMacronutritions.Series["S1"].Points.AddXY("Białko", Math.Round(macronutritions.carbo));
            chartMacronutritions.Series["S1"].Points.AddXY("Węglowodany", Math.Round(macronutritions.protein));
            chartMacronutritions.Series["S1"].Points.AddXY("Tłuszcz", Math.Round(macronutritions.fat));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFatG.Clear();
            textBoxProteinG.Clear();
            textBoxCarboG.Clear();
            chartMacronutritions.Series["S1"].Points.Clear();
        }

        private void Analiza_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
