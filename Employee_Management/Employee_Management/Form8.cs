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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");

        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where Employee_Number = '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Text = dr["Employee_Number"].ToString();
                textBox7.Text = dr["Employee_Name"].ToString();

            }
            con.Close();
        }
        public void a()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Employee_Number"].ToString());
            }
            con.Close();


        }

        private void Form8_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Apply_leave 
                     (Employee_Number,Employee_Name,App_status,Leave_Type,No_days)
                   VALUES('" + comboBox1.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added The Table......!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE  Apply_leave 
            SET Employee_Number='" + comboBox1.Text + "',Employee_Name='" + textBox7.Text + "',App_status='" + comboBox2.Text + "',Leave_Type = '" + comboBox3.Text + "' ,No_days = '" + comboBox4.Text + "' WHERE( Employee_Number='" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }
    }
}
