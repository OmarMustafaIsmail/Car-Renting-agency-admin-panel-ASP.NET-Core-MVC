using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class RegisterViewModel
    {
        [Display(Name =("First Name"))]
        [Required(ErrorMessage = "You have to provide a valid first name.")]
        [MinLength(2, ErrorMessage = "First name must not be less than 2 characters.")]
        [MaxLength(20, ErrorMessage = "First name must not exceed 20 characters.")]
        public string FirstName { get; set; }

        [Display(Name =("Last Name"))]
        [Required(ErrorMessage = "You have to provide a valid last name.")]
        [MinLength(5, ErrorMessage = "Last name must not be less than 5 characters.")]
        [MaxLength(50, ErrorMessage = "Last name must not exceed 50 characters.")]
        public string LastName { get; set; }

        [Display(Name =("Email Address"))]
        [Required(ErrorMessage = "You have to provide a valid email address.")]
        [EmailAddress(ErrorMessage = "You have to provide a valid email address.")]
        public string Email { get; set; }

        [Display(Name = ("Password"))]
        [Required(ErrorMessage = "You have to provide a valid password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match password.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "You have to provide a valid phone number.")]
        [Display(Name = "Phone Number")]
        [MinLength(11, ErrorMessage = "Phone number should be at least 11 characters long")]
        [MaxLength(11, ErrorMessage = ("Phone number should be no more than 11 numbers"))]
        public string PhoneNumber { get; set; }
    }
}
