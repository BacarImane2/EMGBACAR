using System.ComponentModel.DataAnnotations;

namespace EMGBACAR.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Display(Name = "Se souvenir de moi")]
        public required bool RememberMe { get; set; }
    }
}
