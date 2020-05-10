using Okna.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna.Forms
{
    public partial class Wykres : Form
    {
        Account user;
        public Wykres(Account user)
        {
            this.user = user;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("pl-PL");
            InitializeComponent();

            SQLConnection connection = new SQLConnection();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary = connection.GetValuesToChart(user.ID);

            string pattern = "dd.MM.yyyy";
            

            foreach (KeyValuePair<string,string> kvp in dictionary)
            {
                chartHistory.Series["Waga"].Points.AddXY(DateTime.ParseExact(kvp.Key, pattern, CultureInfo.InvariantCulture), Convert.ToDecimal(kvp.Value));
            }

         
        }

        private void Wykres_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
