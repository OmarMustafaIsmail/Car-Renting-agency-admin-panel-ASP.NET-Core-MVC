using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class Clients
    {
        [Display(Name = "Client code")]
        public int Id { get; set; }


        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "You have to provide  valid full name")]
        [MinLength(10, ErrorMessage = "Name should be at least 10 characters long")]
        [MaxLength(50, ErrorMessage = "Name should be no more than 50 characters")]
        public string FullName { get; set; }




        [Required(ErrorMessage = "You have to provide a valid email address.")]
        [EmailAddress(ErrorMessage = "You have to provide a valid email address.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "You have to provide a valid phone number.")]
        [Display(Name = "Phone Number")]
        [MaxLength(11, ErrorMessage = ("Phone number should be no more than 11 numbers"))]
        [MinLength(11, ErrorMessage = "Phone number should be at least 11 characters long")]
        public string PhoneNumber { get; set; }

        
        [Display(Name = "Car")]
        [Range(1, int.MaxValue, ErrorMessage = "choose a valid Car")]
        public int CarId { get; set; }


        [ValidateNever]
        public Cars car { get; set; }



    }
}
