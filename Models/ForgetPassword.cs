using System.ComponentModel.DataAnnotations;

namespace HrUser.Models
{
    public class ForgetPassword
    {

        [Required, EmailAddress, Display(Name ="Registered email address")]
        public string Email { get; set; }
    }
}
