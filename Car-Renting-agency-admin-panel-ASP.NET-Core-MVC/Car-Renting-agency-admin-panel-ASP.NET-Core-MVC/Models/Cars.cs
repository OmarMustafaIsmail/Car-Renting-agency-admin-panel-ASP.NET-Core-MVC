using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class Cars
    {
        public int Id { get; set; }

        [Display(Name =("Car Mark"))]
        [Required]
        public string MarkName { get; set; }

        [Display(Name = ("Year"))]
        [Required]
        public int ManYear { get; set; }

        [ValidateNever]
        public bool isCarRented { get; set; } = false;


        [Required]
        public string Color { get; set; }

        [Required]
        public int Price { get; set; }

        [Display(Name =("Image"))]
        [ValidateNever]
        [Required]
        public string ImageUrl { get; set; }

    }
}
