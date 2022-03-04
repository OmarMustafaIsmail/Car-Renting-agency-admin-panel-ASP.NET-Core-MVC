using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class ClientsController : Controller
    {

        ApplicationDbContext context;

        public ClientsController(ApplicationDbContext con)
        {
            context = con;
            
        }

        [HttpGet]
        [Authorize]
        public IActionResult Clients(string? search, int pageSize = 10, int pageNumber = 1)
        {
            List<Clients> clients = new List<Clients>();


            if (string.IsNullOrEmpty(search))
            {
                clients = context.Clients.Include(c => c.car).ToList();
            }
            else
            {
                ViewBag.CurrentSearch = search;
                clients = context.Clients.Include(c=>c.car).Where(c => c.FullName.Contains(search)).ToList();
            }

            ViewBag.CurrentPageSize = pageSize;
            ViewBag.CurrentPageNumber = pageNumber;
            ViewBag.AllCars = context.Cars.ToList();
            clients = clients.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            return View("Clients", clients);
        }

        [Authorize]
        public IActionResult GetCreateView()
        {
            ViewBag.Allcars = context.Cars.ToList();

            return View("Create");
        }


        public IActionResult AddClient( Clients client)
           
        {

            if (ModelState.IsValid == true)
            {
                Cars car = context.Cars.FirstOrDefault(c => c.Id == client.CarId);
                car.isCarRented = true;

                context.Cars.Update(car);
                context.Clients.Add(client);
                context.SaveChanges();
                return RedirectToAction("Clients");
            }
            else
            {
                ViewBag.AllCars = context.Cars.ToList();

                return View("create", client);
            }

        }



        [Authorize]
        public IActionResult GetEditView(int id) {

            Clients client = context.Clients.FirstOrDefault(c => c.Id == id);

            if(client == null)
            {
                return NotFound();
            }
            else
            {
                ViewBag.AllCars = context.Cars.ToList();
                return View("Edit", client);
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public IActionResult UpdateClient([Bind("Id,FullName,PhoneNumber,Email,CarId")] Clients client
           , int id)
        {
            if (client.Id != id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid == true)
            {
                var oldClient = context.Clients.AsNoTracking().FirstOrDefault(c => c.Id == id);
                if (client.CarId != oldClient.CarId)
                {
                    
                    var oldClientCar = context.Cars.FirstOrDefault(c => c.Id == oldClient.CarId);
                    var clientCar = context.Cars.FirstOrDefault(c => c.Id == client.CarId);
                    oldClientCar.isCarRented = false;
                    context.Cars.Update(oldClientCar);
                    clientCar.isCarRented = true;
                    context.Cars.Update(clientCar);
                 
                }
               
                
                context.Clients.Update(client);
                context.SaveChanges();
                return RedirectToAction("Clients");
            }
            else
            {
                ViewBag.AllCars = context.Cars.ToList();

                return View("Edit", client);
            }

        }



        [Authorize]
        public IActionResult GetDeleteView(int id)
        {

            Clients client = context.Clients.Include(c=>c.car).FirstOrDefault(c => c.Id == id);
            if( client == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", client);
            }

        }
        [HttpPost]
        public IActionResult DeleteClient(int ID)
        {
            Clients client = context.Clients.FirstOrDefault(c => c.Id == ID);

            Cars car = context.Cars.FirstOrDefault(c => c.Id == client.CarId);
            car.isCarRented = false;

            context.Cars.Update(car);
            context.Clients.Remove(client);
            context.SaveChanges();


            return RedirectToAction("Clients");

        }
    }
}








