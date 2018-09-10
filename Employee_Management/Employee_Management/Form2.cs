using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from registration where Employee_Name='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt); if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Form3().Show();
            } //this.Dispose(); 
            else

            {
                MessageBox.Show("Invalid username or password");
                con.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
