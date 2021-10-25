using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Login : Form
    {
        Pages ob = new Pages();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob.ClientsPage();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob.CompanyPage();
        }
    }
}
