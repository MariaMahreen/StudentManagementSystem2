namespace StudentManagementSystem2.Models
{
    // Model class representing a Student record
    public class Student
    {
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public string RollNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
    }
}