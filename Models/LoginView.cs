using System.ComponentModel.DataAnnotations;

namespace HrUser.Models
{
    public class LoginView
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{6,}", ErrorMessage = "Your password must be at least 6 characters " +
        "long and contain at least 1 letter and 1 number")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

