namespace StudentManagementSystem2.Models
{
    // Model class representing a Course record
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}