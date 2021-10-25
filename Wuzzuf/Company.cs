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

     
    public partial class Re_Company : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mts\source\repos\Test1\Test1\Database1.mdf;Integrated Security=True");
        Company1 ob = new Company1();
        Pages ob1 = new Pages();

        public Re_Company()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob1.RegCompany();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            ob.PCompany = textBox1.Text;
            SqlDataAdapter adapt = new SqlDataAdapter("Select * From Comp Where Company='" + ob.PCompany + "' And Pass='" + textBox2.Text + "'", connect);
            DataTable table1 = new DataTable();
            adapt.Fill(table1);
            if (table1.Rows.Count == 1)
            {
                MessageBox.Show("Welcome" + " " + ob.PCompany);
                this.Hide();
                ob1.WelcomeCompany();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password ", "Warning");
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

        private void Re_Company_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ob1.Choose();
        }
    }
}
