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
    public partial class EkranPowitalny : Form
    {
        public EkranPowitalny()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Logowanie(this).Show();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Rejestracja(this).Show();
        }
    }
}
