using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void employeeExperienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void employeescheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }

        private void employeeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
        }

        private void employeeLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
        }

        private void applyLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
        }

        private void payrollCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
        }

        private void experienceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
        }

        private void scheduleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
        }

        private void attendanceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
        }

        private void leaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
        }

        private void applyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 a = new Form14();
            a.Show();
        }

        private void payrollDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
