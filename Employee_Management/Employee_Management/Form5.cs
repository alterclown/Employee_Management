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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Schedule 
                     (Employee_Number,Employee_Name,Shift_Schedule,Schedule_Type,Date,Rotation_Period)
                   VALUES('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added The Table......!");
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
                textBox1.Text = dr["Employee_Name"].ToString();

            }
            con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            a();
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

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE  Schedule 
            SET Employee_Number='" + comboBox1.Text + "',Employee_Name='" + textBox1.Text + "',Shift_Schedule='" + comboBox2.Text + "',Schedule_Type = '" + comboBox3.Text + "' ,Date = '" + textBox3.Text + "',Rotation_Period = '" + textBox2.Text + "' WHERE( Employee_Number='" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");

        }
    }
}
