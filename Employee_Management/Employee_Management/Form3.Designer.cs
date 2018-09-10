namespace Employee_Management
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeExperienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeescheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.showDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeExperienceToolStripMenuItem,
            this.employeescheduleToolStripMenuItem,
            this.employeeAttendanceToolStripMenuItem,
            this.employeeLeaveToolStripMenuItem,
            this.applyLeaveToolStripMenuItem,
            this.payrollCalculationToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeExperienceToolStripMenuItem
            // 
            this.employeeExperienceToolStripMenuItem.Name = "employeeExperienceToolStripMenuItem";
            this.employeeExperienceToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeExperienceToolStripMenuItem.Text = "Employee_Experience";
            this.employeeExperienceToolStripMenuItem.Click += new System.EventHandler(this.employeeExperienceToolStripMenuItem_Click);
            // 
            // employeescheduleToolStripMenuItem
            // 
            this.employeescheduleToolStripMenuItem.Name = "employeescheduleToolStripMenuItem";
            this.employeescheduleToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeescheduleToolStripMenuItem.Text = "Employee_Schedule";
            this.employeescheduleToolStripMenuItem.Click += new System.EventHandler(this.employeescheduleToolStripMenuItem_Click);
            // 
            // employeeAttendanceToolStripMenuItem
            // 
            this.employeeAttendanceToolStripMenuItem.Name = "employeeAttendanceToolStripMenuItem";
            this.employeeAttendanceToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeAttendanceToolStripMenuItem.Text = "Employee_Attendance";
            this.employeeAttendanceToolStripMenuItem.Click += new System.EventHandler(this.employeeAttendanceToolStripMenuItem_Click);
            // 
            // employeeLeaveToolStripMenuItem
            // 
            this.employeeLeaveToolStripMenuItem.Name = "employeeLeaveToolStripMenuItem";
            this.employeeLeaveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeLeaveToolStripMenuItem.Text = "Employee_Leave";
            this.employeeLeaveToolStripMenuItem.Click += new System.EventHandler(this.employeeLeaveToolStripMenuItem_Click);
            // 
            // applyLeaveToolStripMenuItem
            // 
            this.applyLeaveToolStripMenuItem.Name = "applyLeaveToolStripMenuItem";
            this.applyLeaveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.applyLeaveToolStripMenuItem.Text = "Apply_Leave";
            this.applyLeaveToolStripMenuItem.Click += new System.EventHandler(this.applyLeaveToolStripMenuItem_Click);
            // 
            // payrollCalculationToolStripMenuItem
            // 
            this.payrollCalculationToolStripMenuItem.Name = "payrollCalculationToolStripMenuItem";
            this.payrollCalculationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.payrollCalculationToolStripMenuItem.Text = "Payroll_Calculation";
            this.payrollCalculationToolStripMenuItem.Click += new System.EventHandler(this.payrollCalculationToolStripMenuItem_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experienceDataToolStripMenuItem,
            this.scheduleDataToolStripMenuItem,
            this.attendanceDataToolStripMenuItem,
            this.leaveDataToolStripMenuItem,
            this.applyDataToolStripMenuItem,
            this.payrollDataToolStripMenuItem});
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.showDataToolStripMenuItem.Text = "Show Data";
            // 
            // experienceDataToolStripMenuItem
            // 
            this.experienceDataToolStripMenuItem.Name = "experienceDataToolStripMenuItem";
            this.experienceDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.experienceDataToolStripMenuItem.Text = "Experience_Data";
            this.experienceDataToolStripMenuItem.Click += new System.EventHandler(this.experienceDataToolStripMenuItem_Click);
            // 
            // scheduleDataToolStripMenuItem
            // 
            this.scheduleDataToolStripMenuItem.Name = "scheduleDataToolStripMenuItem";
            this.scheduleDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.scheduleDataToolStripMenuItem.Text = "Schedule_Data";
            this.scheduleDataToolStripMenuItem.Click += new System.EventHandler(this.scheduleDataToolStripMenuItem_Click);
            // 
            // attendanceDataToolStripMenuItem
            // 
            this.attendanceDataToolStripMenuItem.Name = "attendanceDataToolStripMenuItem";
            this.attendanceDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.attendanceDataToolStripMenuItem.Text = "Attendance_Data";
            this.attendanceDataToolStripMenuItem.Click += new System.EventHandler(this.attendanceDataToolStripMenuItem_Click);
            // 
            // leaveDataToolStripMenuItem
            // 
            this.leaveDataToolStripMenuItem.Name = "leaveDataToolStripMenuItem";
            this.leaveDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.leaveDataToolStripMenuItem.Text = "Leave_Data";
            this.leaveDataToolStripMenuItem.Click += new System.EventHandler(this.leaveDataToolStripMenuItem_Click);
            // 
            // applyDataToolStripMenuItem
            // 
            this.applyDataToolStripMenuItem.Name = "applyDataToolStripMenuItem";
            this.applyDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.applyDataToolStripMenuItem.Text = "Apply_Data";
            this.applyDataToolStripMenuItem.Click += new System.EventHandler(this.applyDataToolStripMenuItem_Click);
            // 
            // payrollDataToolStripMenuItem
            // 
            this.payrollDataToolStripMenuItem.Name = "payrollDataToolStripMenuItem";
            this.payrollDataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.payrollDataToolStripMenuItem.Text = "Payroll_Data";
            this.payrollDataToolStripMenuItem.Click += new System.EventHandler(this.payrollDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 507);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeExperienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeescheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienceDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}