using System.ComponentModel.DataAnnotations;
namespace EmployeeRegistrationSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeedId { get; set; }
        public int CivilId { get; set; }
        public int FileNumber { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public Employee(int civilId, int fileNumber, string fullName, string department, string jobTitle, string email, string mobileNumber, DateTime employmentDate,DateTime registrationDate)
        {
            CivilId = civilId;
            FileNumber = fileNumber;
            FullName = fullName;
            Department = department;
            JobTitle = jobTitle;
            Email = email;
            MobileNumber = mobileNumber;
            EmploymentDate = employmentDate;
            RegistrationDate = registrationDate;
        }
        public Employee()
        {

        }

    }
}
