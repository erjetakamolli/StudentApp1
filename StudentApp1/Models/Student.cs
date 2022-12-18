namespace StudentApp1.Models
{
    public class Student : Baseclass
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int GraduationYear { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}