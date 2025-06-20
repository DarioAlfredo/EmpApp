using System.ComponentModel.DataAnnotations;

namespace EmpApp.Components.Models
{
    public class TitleDto
    {
        public int EmployeeTitleID { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(100, ErrorMessage = "Description cannot exceed 100 characters.")]
        public string Descr { get; set; } = string.Empty;
    }
}
