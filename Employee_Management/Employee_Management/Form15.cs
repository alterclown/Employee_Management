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
    public partial class Form15 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");

        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Employee_manahement;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Payroll_calculate", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Payroll_calculate", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully......!");
        }
    }
}
