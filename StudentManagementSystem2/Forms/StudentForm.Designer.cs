namespace StudentManagementSystem2.Forms
{
    partial class StudentForm
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRollNumber = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
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
            this.lblTitle.Text = "Student Management";

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

            // dgvStudents
            this.dgvStudents.Location = new System.Drawing.Point(10, 70);
            this.dgvStudents.Size = new System.Drawing.Size(720, 500);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.pnlForm.Location = new System.Drawing.Point(740, 70);
            this.pnlForm.Size = new System.Drawing.Size(350, 500);
            this.pnlForm.Controls.Add(this.lblFullName);
            this.pnlForm.Controls.Add(this.txtFullName);
            this.pnlForm.Controls.Add(this.lblRollNumber);
            this.pnlForm.Controls.Add(this.txtRollNumber);
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.lblPhone);
            this.pnlForm.Controls.Add(this.txtPhone);
            this.pnlForm.Controls.Add(this.lblGender);
            this.pnlForm.Controls.Add(this.cmbGender);
            this.pnlForm.Controls.Add(this.lblAddress);
            this.pnlForm.Controls.Add(this.txtAddress);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9F);
            this.lblFullName.Location = new System.Drawing.Point(15, 15);
            this.lblFullName.Text = "Full Name *";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(15, 33);
            this.txtFullName.Size = new System.Drawing.Size(320, 25);
            this.txtFullName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtFullName.Name = "txtFullName";

            // lblRollNumber
            this.lblRollNumber.AutoSize = true;
            this.lblRollNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.lblRollNumber.Location = new System.Drawing.Point(15, 68);
            this.lblRollNumber.Text = "Roll Number *";

            // txtRollNumber
            this.txtRollNumber.Location = new System.Drawing.Point(15, 86);
            this.txtRollNumber.Size = new System.Drawing.Size(320, 25);
            this.txtRollNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txtRollNumber.Name = "txtRollNumber";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEmail.Location = new System.Drawing.Point(15, 121);
            this.lblEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(15, 139);
            this.txtEmail.Size = new System.Drawing.Size(320, 25);
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.txtEmail.Name = "txtEmail";

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPhone.Location = new System.Drawing.Point(15, 174);
            this.lblPhone.Text = "Phone";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(15, 192);
            this.txtPhone.Size = new System.Drawing.Size(320, 25);
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txtPhone.Name = "txtPhone";

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 9F);
            this.lblGender.Location = new System.Drawing.Point(15, 227);
            this.lblGender.Text = "Gender";

            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(15, 245);
            this.cmbGender.Size = new System.Drawing.Size(320, 25);
            this.cmbGender.Font = new System.Drawing.Font("Arial", 9F);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 9F);
            this.lblAddress.Location = new System.Drawing.Point(15, 280);
            this.lblAddress.Text = "Address";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(15, 298);
            this.txtAddress.Size = new System.Drawing.Size(320, 50);
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9F);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Multiline = true;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(15, 365);
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.Text = "Add Student";
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(175, 365);
            this.btnUpdate.Size = new System.Drawing.Size(160, 35);
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(15, 410);
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(175, 410);
            this.btnClear.Size = new System.Drawing.Size(160, 35);
            this.btnClear.Text = "Clear Fields";
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // StudentForm
            this.ClientSize = new System.Drawing.Size(1100, 580);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students - Student Management System";
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }

        // Controls declaration
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}