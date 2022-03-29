using System;
using System.ComponentModel.DataAnnotations;


namespace HrUser.Models
{
    public class UpdateView
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+([._]?[a-zA-Z0-9]+)*$", ErrorMessage = "Please Enter Valid Username.")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Blood Group is required.")]
        [Display(Name = "Blood Group:")]
        [RegularExpression("^(A|B|AB|O)[-+]$", ErrorMessage ="Please Enter Proper Blood Group")]
        public string Bldgroup { get; set; }


        [Required]
        [Display(Name = "Nationality")]
        [StringLength(25)]
        public string Nationality { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Home Address")]
        public string Homeaddress { get; set; }


        [Required(ErrorMessage = "Phone Number is required.")]
        [Display(Name = "Phone Number:")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Phone Number.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Birth Date is required.")]
        [Display(Name = "Birth Date")]
        public string Birthday { get; set; }


        [Display(Name = "UserPhoto")]
        public byte[] UserPhoto { get; set; }
    }
}
