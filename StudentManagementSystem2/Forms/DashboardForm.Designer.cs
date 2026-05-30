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
            this.btnRefresh = new System.Windows.Forms.Button();
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

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(200, 600);
            this.pnlSidebar.Controls.Add(this.lblSystemTitle);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Controls.Add(this.btnCourses);
            this.pnlSidebar.Controls.Add(this.btnEnrollments);
            this.pnlSidebar.Controls.Add(this.btnRefresh);
            this.pnlSidebar.Controls.Add(this.btnLogout);

            // lblSystemTitle
            this.lblSystemTitle.AutoSize = false;
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.Location = new System.Drawing.Point(10, 20);
            this.lblSystemTitle.Size = new System.Drawing.Size(180, 40);
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSystemTitle.Text = "Student Management";

            // lblWelcome
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.ForeColor = System.Drawing.Color.LightBlue;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 9F);
            this.lblWelcome.Location = new System.Drawing.Point(10, 60);
            this.lblWelcome.Size = new System.Drawing.Size(180, 25);
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome!";

            // btnStudents
            this.btnStudents.Location = new System.Drawing.Point(10, 110);
            this.btnStudents.Size = new System.Drawing.Size(180, 45);
            this.btnStudents.Text = "Students";
            this.btnStudents.Font = new System.Drawing.Font("Arial", 10F);
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(52, 100, 145);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);

            // btnCourses
            this.btnCourses.Location = new System.Drawing.Point(10, 165);
            this.btnCourses.Size = new System.Drawing.Size(180, 45);
            this.btnCourses.Text = "Courses";
            this.btnCourses.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(52, 100, 145);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);

            // btnEnrollments
            this.btnEnrollments.Location = new System.Drawing.Point(10, 220);
            this.btnEnrollments.Size = new System.Drawing.Size(180, 45);
            this.btnEnrollments.Text = "Enrollments";
            this.btnEnrollments.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEnrollments.BackColor = System.Drawing.Color.FromArgb(52, 100, 145);
            this.btnEnrollments.ForeColor = System.Drawing.Color.White;
            this.btnEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrollments.FlatAppearance.BorderSize = 0;
            this.btnEnrollments.Name = "btnEnrollments";
            this.btnEnrollments.Click += new System.EventHandler(this.btnEnrollments_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(10, 475);
            this.btnRefresh.Size = new System.Drawing.Size(180, 45);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 10F);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(23, 162, 184);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(10, 530);
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10F);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Size = new System.Drawing.Size(784, 600);
            this.pnlMain.Controls.Add(this.lblDashboardTitle);
            this.pnlMain.Controls.Add(this.pnlStudentCount);
            this.pnlMain.Controls.Add(this.pnlCourseCount);
            this.pnlMain.Controls.Add(this.pnlEnrollCount);

            // lblDashboardTitle
            this.lblDashboardTitle.AutoSize = false;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 20);
            this.lblDashboardTitle.Size = new System.Drawing.Size(400, 40);
            this.lblDashboardTitle.Text = "Dashboard";

            // pnlStudentCount
            this.pnlStudentCount.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlStudentCount.Location = new System.Drawing.Point(20, 100);
            this.pnlStudentCount.Size = new System.Drawing.Size(220, 120);
            this.pnlStudentCount.Controls.Add(this.lblStudentCount);
            this.pnlStudentCount.Controls.Add(this.lblStudentLabel);

            // lblStudentCount
            this.lblStudentCount.AutoSize = false;
            this.lblStudentCount.ForeColor = System.Drawing.Color.White;
            this.lblStudentCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.Location = new System.Drawing.Point(0, 20);
            this.lblStudentCount.Size = new System.Drawing.Size(220, 50);
            this.lblStudentCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Text = "0";

            // lblStudentLabel
            this.lblStudentLabel.AutoSize = false;
            this.lblStudentLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.lblStudentLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStudentLabel.Location = new System.Drawing.Point(0, 75);
            this.lblStudentLabel.Size = new System.Drawing.Size(220, 30);
            this.lblStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStudentLabel.Text = "Total Students";

            // pnlCourseCount
            this.pnlCourseCount.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.pnlCourseCount.Location = new System.Drawing.Point(260, 100);
            this.pnlCourseCount.Size = new System.Drawing.Size(220, 120);
            this.pnlCourseCount.Controls.Add(this.lblCourseCount);
            this.pnlCourseCount.Controls.Add(this.lblCourseLabel);

            // lblCourseCount
            this.lblCourseCount.AutoSize = false;
            this.lblCourseCount.ForeColor = System.Drawing.Color.White;
            this.lblCourseCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblCourseCount.Location = new System.Drawing.Point(0, 20);
            this.lblCourseCount.Size = new System.Drawing.Size(220, 50);
            this.lblCourseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourseCount.Name = "lblCourseCount";
            this.lblCourseCount.Text = "0";

            // lblCourseLabel
            this.lblCourseLabel.AutoSize = false;
            this.lblCourseLabel.ForeColor = System.Drawing.Color.White;
            this.lblCourseLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCourseLabel.Location = new System.Drawing.Point(0, 75);
            this.lblCourseLabel.Size = new System.Drawing.Size(220, 30);
            this.lblCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCourseLabel.Text = "Total Courses";

            // pnlEnrollCount
            this.pnlEnrollCount.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.pnlEnrollCount.Location = new System.Drawing.Point(500, 100);
            this.pnlEnrollCount.Size = new System.Drawing.Size(220, 120);
            this.pnlEnrollCount.Controls.Add(this.lblEnrollCount);
            this.pnlEnrollCount.Controls.Add(this.lblEnrollLabel);

            // lblEnrollCount
            this.lblEnrollCount.AutoSize = false;
            this.lblEnrollCount.ForeColor = System.Drawing.Color.White;
            this.lblEnrollCount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblEnrollCount.Location = new System.Drawing.Point(0, 20);
            this.lblEnrollCount.Size = new System.Drawing.Size(220, 50);
            this.lblEnrollCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnrollCount.Name = "lblEnrollCount";
            this.lblEnrollCount.Text = "0";

            // lblEnrollLabel
            this.lblEnrollLabel.AutoSize = false;
            this.lblEnrollLabel.ForeColor = System.Drawing.Color.White;
            this.lblEnrollLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.lblEnrollLabel.Location = new System.Drawing.Point(0, 75);
            this.lblEnrollLabel.Size = new System.Drawing.Size(220, 30);
            this.lblEnrollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnrollLabel.Text = "Total Enrollments";

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Student Management System";
            this.Name = "DashboardForm";
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
        private System.Windows.Forms.Button btnRefresh;
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