using System.ComponentModel.DataAnnotations;

namespace EmpApp.Components.Models
{
    public class EmployeeDto
    {
        public int EmployeeID { get; set; }

        public int? EmployeeTitleID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name cannot exceed 100 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name cannot exceed 100 characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public bool IsActive { get; set; }
        public string? EmployeeTitle { get; set; } // For joined title
    }
}
