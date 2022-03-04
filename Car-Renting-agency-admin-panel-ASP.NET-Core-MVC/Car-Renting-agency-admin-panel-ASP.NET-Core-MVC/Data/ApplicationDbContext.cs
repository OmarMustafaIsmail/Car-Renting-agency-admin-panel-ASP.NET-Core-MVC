using System;
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        DbSet<ApplicationUsers> ApplicationUsers { get; set; }

        public DbSet<Cars> Cars { get; set; }
        public DbSet<Clients> Clients { get; set; }
    }
}
