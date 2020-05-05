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
using System.Xml.Schema;

namespace Okna
{
    public partial class Test : Form
    {
        Account user;

        public Test(Account user)
        {
            this.user = user;
            InitializeComponent();
            labelUserLogin.Text = user.accountID;
            labelUserGender.Text = user.gender.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
