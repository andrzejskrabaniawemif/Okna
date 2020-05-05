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
    public partial class Wykres : Form
    {
        Account user;
        public Wykres(Account user)
        {
            this.user = user;

            InitializeComponent();

            SQLConnection connection = new SQLConnection();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary = connection.GetValuesToChart(user.ID);

            foreach(KeyValuePair<string,string> kvp in dictionary)
            {
                chartHistory.Series["Waga"].Points.AddXY(kvp.Key, kvp.Value);
            }

         
        }
    }
}
