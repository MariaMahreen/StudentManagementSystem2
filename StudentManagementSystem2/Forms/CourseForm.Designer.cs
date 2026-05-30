namespace StudentManagementSystem2.Forms
{
    partial class CourseForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCreditHours = new System.Windows.Forms.Label();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(1100, 60);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.Text = "Course Management";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(650, 17);
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearch.Name = "txtSearch";

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(910, 15);
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.Text = "Search";
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgvCourses
            this.dgvCourses.Location = new System.Drawing.Point(10, 70);
            this.dgvCourses.Size = new System.Drawing.Size(720, 500);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.dgvCourses.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.pnlForm.Location = new System.Drawing.Point(740, 70);
            this.pnlForm.Size = new System.Drawing.Size(350, 500);
            this.pnlForm.Controls.Add(this.lblCourseName);
            this.pnlForm.Controls.Add(this.txtCourseName);
            this.pnlForm.Controls.Add(this.lblCourseCode);
            this.pnlForm.Controls.Add(this.txtCourseCode);
            this.pnlForm.Controls.Add(this.lblCreditHours);
            this.pnlForm.Controls.Add(this.txtCreditHours);
            this.pnlForm.Controls.Add(this.lblDescription);
            this.pnlForm.Controls.Add(this.txtDescription);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);

            // lblCourseName
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCourseName.Location = new System.Drawing.Point(15, 15);
            this.lblCourseName.Text = "Course Name *";

            // txtCourseName
            this.txtCourseName.Location = new System.Drawing.Point(15, 33);
            this.txtCourseName.Size = new System.Drawing.Size(320, 25);
            this.txtCourseName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCourseName.Name = "txtCourseName";

            // lblCourseCode
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCourseCode.Location = new System.Drawing.Point(15, 68);
            this.lblCourseCode.Text = "Course Code *";

            // txtCourseCode
            this.txtCourseCode.Location = new System.Drawing.Point(15, 86);
            this.txtCourseCode.Size = new System.Drawing.Size(320, 25);
            this.txtCourseCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCourseCode.Name = "txtCourseCode";

            // lblCreditHours
            this.lblCreditHours.AutoSize = true;
            this.lblCreditHours.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCreditHours.Location = new System.Drawing.Point(15, 121);
            this.lblCreditHours.Text = "Credit Hours";

            // txtCreditHours
            this.txtCreditHours.Location = new System.Drawing.Point(15, 139);
            this.txtCreditHours.Size = new System.Drawing.Size(320, 25);
            this.txtCreditHours.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCreditHours.Name = "txtCreditHours";

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDescription.Location = new System.Drawing.Point(15, 174);
            this.lblDescription.Text = "Description";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(15, 192);
            this.txtDescription.Size = new System.Drawing.Size(320, 80);
            this.txtDescription.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Multiline = true;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(15, 300);
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.Text = "Add Course";
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(175, 300);
            this.btnUpdate.Size = new System.Drawing.Size(160, 35);
            this.btnUpdate.Text = "Update Course";
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(15, 345);
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(175, 345);
            this.btnClear.Size = new System.Drawing.Size(160, 35);
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // CourseForm
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses - Student Management System";
            this.Name = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }

        // Controls declaration
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}