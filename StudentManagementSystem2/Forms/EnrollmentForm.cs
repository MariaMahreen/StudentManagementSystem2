using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem2.Database;

namespace StudentManagementSystem2.Forms
{
    public partial class EnrollmentForm : Form
    {
        // Stores selected enrollment ID for update/delete
        private int selectedEnrollmentID = 0;

        public EnrollmentForm()
        {
            InitializeComponent();
        }

        // Load data when form opens
        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadStudentsCombo();
            LoadCoursesCombo();
            LoadEnrollments();
        }

        // Load students into dropdown
        private void LoadStudentsCombo()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    "SELECT StudentID, FullName FROM Students WHERE IsActive=1");
                cmbStudent.DataSource = dt;
                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentID";
                cmbStudent.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load courses into dropdown
        private void LoadCoursesCombo()
        {
            try
            {
                DataTable dt = DatabaseHelper.ExecuteQuery(
                    "SELECT CourseID, CourseName FROM Courses WHERE IsActive=1");
                cmbCourse.DataSource = dt;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "CourseID";
                cmbCourse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fetch all enrollments from database
        private void LoadEnrollments()
        {
            try
            {
                string query = @"SELECT e.EnrollmentID, s.FullName AS Student, 
                                c.CourseName AS Course, e.Grade, e.EnrollmentDate 
                                FROM Enrollments e
                                JOIN Students s ON e.StudentID = s.StudentID
                                JOIN Courses c ON e.CourseID = c.CourseID";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvEnrollments.DataSource = dt;

                // Hide EnrollmentID column
                dgvEnrollments.Columns["EnrollmentID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading enrollments: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add new enrollment
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex == -1 || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Student and Course!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"INSERT INTO Enrollments (StudentID, CourseID, Grade, EnrollmentDate) 
                                VALUES (@studentID, @courseID, @grade, @date)";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@studentID", cmbStudent.SelectedValue),
                    new MySql.Data.MySqlClient.MySqlParameter("@courseID", cmbCourse.SelectedValue),
                    new MySql.Data.MySqlClient.MySqlParameter("@grade", txtGrade.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@date", dtpEnrollmentDate.Value.ToString("yyyy-MM-dd"))
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Enrollment added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadEnrollments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding enrollment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update selected enrollment
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0)
            {
                MessageBox.Show("Please select an enrollment to update!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"UPDATE Enrollments SET StudentID=@studentID, 
                                CourseID=@courseID, Grade=@grade, EnrollmentDate=@date 
                                WHERE EnrollmentID=@id";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@studentID", cmbStudent.SelectedValue),
                    new MySql.Data.MySqlClient.MySqlParameter("@courseID", cmbCourse.SelectedValue),
                    new MySql.Data.MySqlClient.MySqlParameter("@grade", txtGrade.Text.Trim()),
                    new MySql.Data.MySqlClient.MySqlParameter("@date", dtpEnrollmentDate.Value.ToString("yyyy-MM-dd")),
                    new MySql.Data.MySqlClient.MySqlParameter("@id", selectedEnrollmentID)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Enrollment updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadEnrollments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating enrollment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete selected enrollment
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedEnrollmentID == 0)
            {
                MessageBox.Show("Please select an enrollment to delete!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this enrollment?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Enrollments WHERE EnrollmentID=@id";
                    MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                        new MySql.Data.MySqlClient.MySqlParameter("@id", selectedEnrollmentID)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Enrollment deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadEnrollments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting enrollment: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Search enrollments by student name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string query = @"SELECT e.EnrollmentID, s.FullName AS Student, 
                                c.CourseName AS Course, e.Grade, e.EnrollmentDate 
                                FROM Enrollments e
                                JOIN Students s ON e.StudentID = s.StudentID
                                JOIN Courses c ON e.CourseID = c.CourseID
                                WHERE s.FullName LIKE @search OR c.CourseName LIKE @search";

                MySql.Data.MySqlClient.MySqlParameter[] parameters = {
                    new MySql.Data.MySqlClient.MySqlParameter("@search", "%" + searchText + "%")
                };

                DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
                dgvEnrollments.DataSource = dt;
                dgvEnrollments.Columns["EnrollmentID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill form when row clicked
        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
                selectedEnrollmentID = Convert.ToInt32(row.Cells["EnrollmentID"].Value);
                txtGrade.Text = row.Cells["Grade"].Value?.ToString();

                if (row.Cells["EnrollmentDate"].Value != null)
                    dtpEnrollmentDate.Value = Convert.ToDateTime(row.Cells["EnrollmentDate"].Value);
            }
        }

        // Clear all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Reset all form fields
        private void ClearFields()
        {
            selectedEnrollmentID = 0;
            cmbStudent.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            txtGrade.Clear();
            dtpEnrollmentDate.Value = DateTime.Now;
        }
    }
}