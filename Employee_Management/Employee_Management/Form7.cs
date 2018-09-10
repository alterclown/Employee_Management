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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");
        String affirmation;

        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where Employee_Number = '" + comboBox2.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Text = dr["Employee_Number"].ToString();
                textBox2.Text = dr["Employee_Name"].ToString();

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
                comboBox2.Items.Add(dr["Employee_Number"].ToString());
            }
            con.Close();


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (checkBox1.Checked == true)
            {
                affirmation = "Yes";
            }
            else if (checkBox2.Checked == true) {

                affirmation = "No";
            }
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Leave_Employee 
                     (Employee_Number,Employee_Name,Unit,Entitlement_Unit,Form,Too,affirmation)
                   VALUES('" + comboBox2.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','"+ affirmation +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added The Table......!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE  Leave_Employee 
            SET Employee_Number='" + comboBox2.Text + "',Employee_Name='" + textBox2.Text + "',Unit='" + comboBox1.Text + "',Entitlement_Unit = '" + textBox7.Text + "' ,Form = '" + textBox6.Text + "',Too = '" + textBox5.Text + "',affirmation = '" + affirmation + "' WHERE( Employee_Number='" + comboBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }
    }
}
