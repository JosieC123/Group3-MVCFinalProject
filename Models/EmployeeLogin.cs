using System.ComponentModel.DataAnnotations;

namespace Group3_MVCFinalProject.Models
{
    public class EmployeeLogin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}