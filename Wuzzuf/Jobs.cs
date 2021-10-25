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
    public partial class Jobs : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mts\source\repos\Test1\Test1\Database1.mdf;Integrated Security=True");
        Company1 ob = new Company1();
        Pages ob1 = new Pages();
        public Jobs()
        {
            InitializeComponent();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Handling();

        }
        public void AddJob()
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("Insert Into Jobs (Company,Job,Salary,Experince,Field,Email,Phone) Values (@Company,@Job,@Salary,@Experince,@Field,@Email,@Phone)", connect);
                cmd.Parameters.AddWithValue(@"Company", ob.PCompany);
                cmd.Parameters.AddWithValue(@"Job", textBox1.Text);
                cmd.Parameters.AddWithValue(@"Salary", textBox2.Text);
                cmd.Parameters.AddWithValue(@"Experince", textBox3.Text);
                cmd.Parameters.AddWithValue(@"Field", comboBox1.Text);
                cmd.Parameters.AddWithValue(@"Email", textBox4.Text);
                cmd.Parameters.AddWithValue(@"Phone", textBox5.Text);
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
        public void Handling()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter your Job Describtion", "Warning");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Length > 5)
            {
                MessageBox.Show("Please enter your salary", "Warning");

            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text.Length != 1)
            {
                MessageBox.Show("Please enter your Exprerince", "Warning");

            }
            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please choose your Field", "Warning");

            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter your E-mail", "Warning");

            }
            else if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text.Length > 11 && textBox5.Text.Length < 11)
            {
                MessageBox.Show("Please enter your Phone", "Warning");

            }
            else
            {


                AddJob();
                this.Hide();
                ob1.WelcomeCompany();
            }
        }
    }
}
