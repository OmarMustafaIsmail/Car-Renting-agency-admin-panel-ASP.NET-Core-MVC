using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Renting_agency_admin_panel_ASP.NET_Core_MVC
{
    public class CarsController : Controller
    {

        ApplicationDbContext context;
        IWebHostEnvironment webHostEnvironment;


        public CarsController(ApplicationDbContext con,IWebHostEnvironment webHost)
        {
            context = con;
            webHostEnvironment = webHost;
        }

        [Authorize]
        public IActionResult Cars()
        {
            List<Cars> cars = new List<Cars>();
            cars = context.Cars.ToList();
            return View("Cars",cars);
        }



        public IActionResult GetCreateView()
        {
            return View("Create");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCar([Bind("Id,MarkName,CarModel,ImageUrl,ManYear,Color,Price")]Cars car,IFormFile? imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null)
                {
                    string imgExtension = Path.GetExtension(imageFile.FileName);
                    Guid imgGuid = Guid.NewGuid();
                    string imgName = imgGuid + imgExtension;
                    string imgUrl = "/images/" + imgName;
                    car.ImageUrl = imgUrl;

                    string imgPath = webHostEnvironment.WebRootPath + imgUrl;

                    FileStream imgStream = new FileStream(imgPath, FileMode.Create);
                    imageFile.CopyTo(imgStream);
                    imgStream.Dispose();

                }
                else
                {
                    car.ImageUrl = "/images/car.png";
                }

                context.Cars.Add(car);
                context.SaveChanges();
                return RedirectToAction("Cars");
            }
            else
            {
                return View("Create",car);
            }
        }



        public IActionResult GetDeleteView(int ID)
        {
            Cars car = context.Cars.FirstOrDefault(c => c.Id == ID);

            if(car == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", car);
            }
        }



        [HttpPost]
        public IActionResult DeleteCar(int Id)
        {
            Cars car = context.Cars.FirstOrDefault(c => c.Id == Id);

            if(car.ImageUrl != "/images/car.png")
            {
                string imgPath = webHostEnvironment.WebRootPath + car.ImageUrl;

                if (System.IO.File.Exists(imgPath))
                {
                    System.IO.File.Delete(imgPath);
                }
            }

            context.Cars.Remove(car);
            context.SaveChanges();

            return RedirectToAction("Cars");
        }



        public IActionResult GetEditView(int ID)
        {
            Cars car = context.Cars.FirstOrDefault(c => c.Id == ID);

            if (car == null)
            {
                return NotFound();

            }
            else
            {
                return View("Edit", car);
            }
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult UpdateCar([Bind("Id,MarkName,CarModel,ManYear,Price,Color,ImageUrl,")] Cars car,
            IFormFile? imageFile, int id)
        {

            if (car.Id != id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid == true)
            {
             

                if (imageFile != null)
                {

                    if (car.ImageUrl != "/images/car.png")
                    {
                        string OldimgPath = webHostEnvironment.WebRootPath + car.ImageUrl;

                        if (System.IO.File.Exists(OldimgPath))
                        {
                            System.IO.File.Delete(OldimgPath);
                        }
                    }

                    string imgExtension = Path.GetExtension(imageFile.FileName);
                    Guid imgGuid = Guid.NewGuid();
                    string imgName = imgGuid + imgExtension;
                    string imgUrl = "/images/" + imgName;
                    car.ImageUrl = imgUrl;

                    string imgPath = webHostEnvironment.WebRootPath + imgUrl;

                    FileStream imgStream = new FileStream(imgPath, FileMode.Create);
                    imageFile.CopyTo(imgStream);
                    imgStream.Dispose();

                }


                context.Cars.Update(car);
                
                context.SaveChanges();
                return RedirectToAction("Cars");
            }
            else
            {
                

                return View("Edit", car);
            }

        }
    }


}
