using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem2.Database;

namespace StudentManagementSystem2.Forms
{
    public partial class StudentForm : Form
    {
        private int selectedStudentID = 0;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                string query = "SELECT StudentID, FullName, RollNumber, Email, Phone, Gender FROM Students WHERE IsActive=1";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvStudents.DataSource = dt;
                dgvStudents.Columns["StudentID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtRollNumber.Text))
            {
                MessageBox.Show("Full Name and Roll Number are required!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"INSERT INTO Students (FullName, RollNumber, Email, Phone, Gender, Address, IsActive) 
                                VALUES (@name, @roll, @email, @phone, @gender, @address, 1)";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@name", txtFullName.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@roll", txtRollNumber.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@email", txtEmail.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@phone", txtPhone.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@gender", cmbGender.SelectedItem?.ToString() ?? ""),
                    new MySql.Data.MySqlClient.MySqlParameter("@address", txtAddress.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Student added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student to update!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE Students SET FullName=@name, RollNumber=@roll, 
                                Email=@email, Phone=@phone, Gender=@gender, Address=@address 
                                WHERE StudentID=@id";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@name", txtFullName.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@roll", txtRollNumber.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@email", txtEmail.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@phone", txtPhone.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@gender", cmbGender.SelectedItem?.ToString() ?? ""),
                    new MySql.Data.MySqlClient.MySqlParameter("@address", txtAddress.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@id", selectedStudentID)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Student updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentID == 0)
            {
                MessageBox.Show("Please select a student to delete!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Students SET IsActive=0 WHERE StudentID=@id";
                    MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                        new MySql.Data.MySqlClient.MySqlParameter("@id", selectedStudentID)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Student deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string query = @"SELECT StudentID, FullName, RollNumber, Email, Phone, Gender 
                                FROM Students WHERE IsActive=1 AND 
                                (FullName LIKE @search OR RollNumber LIKE @search)";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@search", "%" + searchText + "%")
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvStudents.DataSource = dt;
                dgvStudents.Columns["StudentID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtRollNumber.Text = row.Cells["RollNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                cmbGender.Text = row.Cells["Gender"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedStudentID = 0;
            txtFullName.Clear();
            txtRollNumber.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
        }
    }
}
