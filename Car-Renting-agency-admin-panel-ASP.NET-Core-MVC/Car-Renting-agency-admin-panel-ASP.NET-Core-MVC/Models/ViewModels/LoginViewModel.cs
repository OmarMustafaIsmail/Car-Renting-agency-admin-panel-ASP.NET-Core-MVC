using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class LoginViewModel
    {



        [Required]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
