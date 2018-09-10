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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int HRA = Convert.ToInt32(this.textBox1.Text);
            int TA = Convert.ToInt32(this.textBox2.Text);
            int DA = Convert.ToInt32(this.textBox3.Text);

         
            double calculate = HRA + TA + DA;
            textBox4.Text = calculate.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IT = Convert.ToInt32(this.textBox7.Text);
            int PF = Convert.ToInt32(this.textBox6.Text);


            double calculate = IT + PF;
            textBox5.Text = calculate.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int basic_pay = Convert.ToInt32(this.textBox8.Text);
            int HRA = Convert.ToInt32(this.textBox1.Text);
            int TA = Convert.ToInt32(this.textBox2.Text);
            int DA = Convert.ToInt32(this.textBox3.Text);
            

            double calculate = HRA + TA + DA + basic_pay;
            textBox10.Text = calculate.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int basic_pay = Convert.ToInt32(this.textBox8.Text);
            int HRA = Convert.ToInt32(this.textBox1.Text);
            int TA = Convert.ToInt32(this.textBox2.Text);
            int DA = Convert.ToInt32(this.textBox3.Text);
            int IT = Convert.ToInt32(this.textBox7.Text);
            int PF = Convert.ToInt32(this.textBox6.Text);


            double calculate = HRA + TA + DA + basic_pay - IT - PF;
            textBox9.Text = calculate.ToString();
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
                textBox11.Text = dr["Employee_Name"].ToString();

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

        private void Form9_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Payroll_calculate 
                     (Employee_Number,Employee_Name,Basic_pay,HRA,TA,DA,IT,PF,Gross_Salary,Net_Salary)
                   VALUES('" + comboBox1.Text + "','" + textBox11.Text + "','" + textBox8.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox10.Text + "','" + textBox9.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Added The Table......!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE  Payroll_calculate 
            SET Employee_Number='" + comboBox1.Text + "',Employee_Name='" + textBox11.Text + "',Basic_pay='" + textBox8.Text + "',HRA = '" + textBox1.Text + "',TA = '" + textBox2.Text + "',DA = '" + textBox3.Text + "',IT = '" + textBox7.Text + "',PF = '" + textBox6.Text + "',Gross_Salary = '" + textBox10.Text + "',Net_Salary = '" + textBox9.Text + "' WHERE( Employee_Number='" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }
    }
}
