using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test1
{
    public partial class Client : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mts\source\repos\Test1\Test1\Database1.mdf;Integrated Security=True");
        Clients ob = new Clients();
        Pages ob1 = new Pages();

        public Client()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob1.RegClient();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check();

        }
        public void Check()
        {
           
            ob.PUser = textBox1.Text;
            SqlDataAdapter con = new SqlDataAdapter("SELECT * FROM Client WHERE Usern='" + ob.PUser + "' AND Pass='" + textBox2.Text + "'", connect);
            DataTable table = new DataTable();
            con.Fill(table);
            if (table.Rows.Count == 1)
            {

                MessageBox.Show("Welcome" + " " + textBox1.Text);
                this.Hide();
                ob1.WelcomeClient();
            }
            else
            {
                MessageBox.Show("Wrong Username and Pass");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob1.Choose();
        }
    }
}
