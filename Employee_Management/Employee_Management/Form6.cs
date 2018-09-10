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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            a();
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Employee_attendance 
                     (Employee_Number,Employee_Name,Date,Absent,In_time,Out_time,Shift_code,Employee_Department)
                   VALUES('" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added The Table......!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE  Employee_attendance 
            SET Employee_Number='" + comboBox1.Text + "',Employee_Name='" + textBox7.Text + "',Date='" + textBox6.Text + "',Absent = '" + textBox5.Text + "' ,In_time = '" + textBox1.Text + "',Out_time = '" + textBox2.Text + "',Shift_code = '" + textBox3.Text + "',Employee_Department = '" + textBox4.Text + "' WHERE( Employee_Number='" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }
    }
}
