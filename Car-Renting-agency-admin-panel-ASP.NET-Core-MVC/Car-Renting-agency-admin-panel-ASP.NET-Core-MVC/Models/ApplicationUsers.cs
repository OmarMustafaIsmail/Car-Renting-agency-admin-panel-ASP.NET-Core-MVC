using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Models
{
    
        public class ApplicationUsers : IdentityUser
        {

            [Display(Name = ("First Name"))]
            [Required(ErrorMessage = "You have to provide a valid first name")]
            [MinLength(4, ErrorMessage = ("First name should be at least 4 characters long"))]
            [MaxLength(20, ErrorMessage = ("First name should be no more than 20 characters"))]
            public string FirstName { get; set; }


            [Display(Name = ("Last Name"))]
            [Required(ErrorMessage = "You have to provide a valid last name")]
            [MinLength(4, ErrorMessage = ("Last name should be at least 4 characters long"))]
            [MaxLength(20, ErrorMessage = ("Last name should be no more than 20 characters"))]
            public string LastName { get; set; }
        }
    
}

