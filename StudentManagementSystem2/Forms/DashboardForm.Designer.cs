namespace StudentManagementSystem2.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnEnrollments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlStudentCount = new System.Windows.Forms.Panel();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.lblStudentLabel = new System.Windows.Forms.Label();
            this.pnlCourseCount = new System.Windows.Forms.Panel();
            this.lblCourseCount = new System.Windows.Forms.Label();
            this.lblCourseLabel = new System.Windows.Forms.Label();
            this.pnlEnrollCount = new System.Windows.Forms.Panel();
            this.lblEnrollCount = new System.Windows.Forms.Label();
            this.lblEnrollLabel = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlStudentCount.SuspendLayout();
            this.pnlCourseCount.SuspendLayout();
            this.pnlEnrollCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlSidebar.Controls.Add(this.lblSystemTitle);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.btnCourses);
            this.pnlSidebar.Controls.Add(this.btnEnrollments);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 600);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(10, 20);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(180, 40);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "Student Management";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 9F);
            this.lblWelcome.ForeColor = System.Drawing.Color.LightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(10, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(180, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Arial", 10F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(10, 110);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(180, 45);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(10, 165);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(180, 45);
            this.btnCourses.TabIndex = 3;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnEnrollments
            // 
            this.btnEnrollments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(100)))), ((int)(((byte)(145)))));
            this.btnEnrollments.FlatAppearance.BorderSize = 0;
            this.btnEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollments.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEnrollments.ForeColor = System.Drawing.Color.White;
            this.btnEnrollments.Location = new System.Drawing.Point(10, 220);
            this.btnEnrollments.Name = "btnEnrollments";
            this.btnEnrollments.Size = new System.Drawing.Size(180, 45);
            this.btnEnrollments.TabIndex = 4;
            this.btnEnrollments.Text = "Enrollments";
            this.btnEnrollments.UseVisualStyleBackColor = false;
            this.btnEnrollments.Click += new System.EventHandler(this.btnEnrollments_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 530);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlMain.Controls.Add(this.lblDashboardTitle);
            this.pnlMain.Controls.Add(this.pnlStudentCount);
            this.pnlMain.Controls.Add(this.pnlCourseCount);
            this.pnlMain.Controls.Add(this.pnlEnrollCount);
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 600);
            this.pnlMain.TabIndex = 1;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 20);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(400, 40);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // pnlStudentCount
            // 
            this.pnlStudentCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.pnlStudentCount.Controls.Add(this.lblStudentCount);
            this.pnlStudentCount.Controls.Add(this.lblStudentLabel);
            this.pnlStudentCount.Location = new System.Drawing.Point(20, 100);
            this.pnlStudentCount.Name = "pnlStudentCount";
            this.pnlStudentCount.Size = new System.Drawing.Size(220, 120);
            this.pnlStudentCount.TabIndex = 1;
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.ForeColor = System.Drawing.Color.White;
            this.lblStudentCount.Location = new System.Drawing.Point(0, 10);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(220, 65);
            this.lblStudentCount.TabIndex = 0;
            this.lblStudentCount.Text = "0";
            this.lblStudentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentLabel
            // 
            this.lblStudentLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStudentLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.lblStudentLabel.Location = new System.Drawing.Point(0, 75);
            this.lblStudentLabel.Name = "lblStudentLabel";
            this.lblStudentLabel.Size = new System.Drawing.Size(220, 30);
            this.lblStudentLabel.TabIndex = 1;
            this.lblStudentLabel.Text = "Total Students";
            this.lblStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCourseCount
            // 
            this.pnlCourseCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.pnlCourseCount.Controls.Add(this.lblCourseCount);
            this.pnlCourseCount.Controls.Add(this.lblCourseLabel);
            this.pnlCourseCount.Location = new System.Drawing.Point(260, 100);
            this.pnlCourseCount.Name = "pnlCourseCount";
            this.pnlCourseCount.Size = new System.Drawing.Size(220, 120);
            this.pnlCourseCount.TabIndex = 2;
            // 
            // lblCourseCount
            // 
            this.lblCourseCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblCourseCount.ForeColor = System.Drawing.Color.White;
            this.lblCourseCount.Location = new System.Drawing.Point(0, 0);
            this.lblCourseCount.Name = "lblCourseCount";
            this.lblCourseCount.Size = new System.Drawing.Size(220, 70);
            this.lblCourseCount.TabIndex = 0;
            this.lblCourseCount.Text = "0";
            this.lblCourseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourseLabel
            // 
            this.lblCourseLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCourseLabel.ForeColor = System.Drawing.Color.White;
            this.lblCourseLabel.Location = new System.Drawing.Point(0, 75);
            this.lblCourseLabel.Name = "lblCourseLabel";
            this.lblCourseLabel.Size = new System.Drawing.Size(220, 30);
            this.lblCourseLabel.TabIndex = 1;
            this.lblCourseLabel.Text = "Total Courses";
            this.lblCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEnrollCount
            // 
            this.pnlEnrollCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnlEnrollCount.Controls.Add(this.lblEnrollCount);
            this.pnlEnrollCount.Controls.Add(this.lblEnrollLabel);
            this.pnlEnrollCount.Location = new System.Drawing.Point(500, 100);
            this.pnlEnrollCount.Name = "pnlEnrollCount";
            this.pnlEnrollCount.Size = new System.Drawing.Size(220, 120);
            this.pnlEnrollCount.TabIndex = 3;
            // 
            // lblEnrollCount
            // 
            this.lblEnrollCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblEnrollCount.ForeColor = System.Drawing.Color.White;
            this.lblEnrollCount.Location = new System.Drawing.Point(-3, 5);
            this.lblEnrollCount.Name = "lblEnrollCount";
            this.lblEnrollCount.Size = new System.Drawing.Size(220, 65);
            this.lblEnrollCount.TabIndex = 0;
            this.lblEnrollCount.Text = "0";
            this.lblEnrollCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnrollLabel
            // 
            this.lblEnrollLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEnrollLabel.ForeColor = System.Drawing.Color.White;
            this.lblEnrollLabel.Location = new System.Drawing.Point(0, 75);
            this.lblEnrollLabel.Name = "lblEnrollLabel";
            this.lblEnrollLabel.Size = new System.Drawing.Size(220, 30);
            this.lblEnrollLabel.TabIndex = 1;
            this.lblEnrollLabel.Text = "Total Enrollments";
            this.lblEnrollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Student Management System";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlStudentCount.ResumeLayout(false);
            this.pnlCourseCount.ResumeLayout(false);
            this.pnlEnrollCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Controls declaration
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnEnrollments;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlStudentCount;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label lblStudentLabel;
        private System.Windows.Forms.Panel pnlCourseCount;
        private System.Windows.Forms.Label lblCourseCount;
        private System.Windows.Forms.Label lblCourseLabel;
        private System.Windows.Forms.Panel pnlEnrollCount;
        private System.Windows.Forms.Label lblEnrollCount;
        private System.Windows.Forms.Label lblEnrollLabel;
    }
}