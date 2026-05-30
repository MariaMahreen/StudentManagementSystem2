using System;
using System.Data;
using System.Windows.Forms;
using StudentManagementSystem2.Database;

namespace StudentManagementSystem2.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            // Show logged in username
            lblWelcome.Text = "Welcome, " + LoginForm.LoggedInUser;
        }

        // Load dashboard statistics from database
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        // Fetch and display counts from database
        private void LoadStatistics()
        {
            try
            {
                // Get total active students
                DataTable students = DatabaseHelper.ExecuteQuery(
                    "SELECT COUNT(*) as Total FROM Students WHERE IsActive=1");
                lblStudentCount.Text = students.Rows[0]["Total"].ToString();

                // Get total active courses
                DataTable courses = DatabaseHelper.ExecuteQuery(
                    "SELECT COUNT(*) as Total FROM Courses WHERE IsActive=1");
                lblCourseCount.Text = courses.Rows[0]["Total"].ToString();

                // Get total enrollments
                DataTable enrollments = DatabaseHelper.ExecuteQuery(
                    "SELECT COUNT(*) as Total FROM Enrollments");
                lblEnrollCount.Text = enrollments.Rows[0]["Total"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open Students form
        private void btnStudents_Click(object sender, EventArgs e)
        {
            // TODO: Uncomment when StudentForm is created
             StudentForm sf = new StudentForm();
             sf.Show();
        }

        // Open Courses form
        private void btnCourses_Click(object sender, EventArgs e)
        {
            // TODO: Uncomment when CourseForm is created
             CourseForm cf = new CourseForm();
             cf.Show();
        }

        // Open Enrollments form
        private void btnEnrollments_Click(object sender, EventArgs e)
        {
            // TODO: Uncomment when EnrollmentForm is created
            // EnrollmentForm ef = new EnrollmentForm();
            // ef.Show();
        }

        // Logout - go back to login
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}