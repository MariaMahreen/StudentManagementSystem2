using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem2.Database;

namespace StudentManagementSystem2.Forms
{
    public partial class CourseForm : Form
    {
        // Stores selected course ID for update/delete
        private int selectedCourseID = 0;

        public CourseForm()
        {
            InitializeComponent();
        }

        // Load courses when form opens
        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        // Fetch all active courses from database
        private void LoadCourses()
        {
            try
            {
                string query = "SELECT CourseID, CourseName, CourseCode, CreditHours, Description FROM Courses WHERE IsActive=1";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvCourses.DataSource = dt;

                // Hide CourseID column from view
                dgvCourses.Columns["CourseID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add new course to database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrEmpty(txtCourseName.Text) || string.IsNullOrEmpty(txtCourseCode.Text))
            {
                MessageBox.Show("Course Name and Course Code are required!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"INSERT INTO Courses (CourseName, CourseCode, CreditHours, Description, IsActive) 
                                VALUES (@name, @code, @hours, @desc, 1)";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@name", txtCourseName.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@code", txtCourseCode.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@hours", string.IsNullOrEmpty(txtCreditHours.Text) ? 0 : int.Parse(txtCreditHours.Text)),
                    new MySql.Data.MySqlClient.MySqlParameter("@desc", txtDescription.Text.Trim())
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Course added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update selected course record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course to update!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE Courses SET CourseName=@name, CourseCode=@code, 
                                CreditHours=@hours, Description=@desc 
                                WHERE CourseID=@id";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@name", txtCourseName.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@code", txtCourseCode.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@hours", string.IsNullOrEmpty(txtCreditHours.Text) ? 0 : int.Parse(txtCreditHours.Text)),
                    new MySql.Data.MySqlClient.MySqlParameter("@desc", txtDescription.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@id", selectedCourseID)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Course updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Soft delete - marks course as inactive
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course to delete!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Soft delete - set IsActive to 0
                    string query = "UPDATE Courses SET IsActive=0 WHERE CourseID=@id";
                    MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                        new MySql.Data.MySqlClient.MySqlParameter("@id", selectedCourseID)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Course deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadCourses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Search courses by name or code
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string query = @"SELECT CourseID, CourseName, CourseCode, CreditHours, Description 
                                FROM Courses WHERE IsActive=1 AND 
                                (CourseName LIKE @search OR CourseCode LIKE @search)";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@search", "%" + searchText + "%")
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvCourses.DataSource = dt;
                dgvCourses.Columns["CourseID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill form fields when row is clicked in DataGridView
        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                selectedCourseID = Convert.ToInt32(row.Cells["CourseID"].Value);
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCreditHours.Text = row.Cells["CreditHours"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
            }
        }

        // Clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Reset all form fields and selection
        private void ClearFields()
        {
            selectedCourseID = 0;
            txtCourseName.Clear();
            txtCourseCode.Clear();
            txtCreditHours.Clear();
            txtDescription.Clear();
        }
    }
}