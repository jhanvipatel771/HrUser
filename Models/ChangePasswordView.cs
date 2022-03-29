using System.ComponentModel.DataAnnotations;

namespace HrUser.Models
{
    public class ChangePasswordView
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm new password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
