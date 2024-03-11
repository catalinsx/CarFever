using FinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{

    public class AdminController : Controller
    {
        private readonly CarsDbContext _context;
       

        public AdminController(CarsDbContext context)
        {
            _context = context;
            
        }

        // iactionresultu pentru interfata de la adminpanel
        [HttpGet]
        public IActionResult AddCar()
        {
            // salvez intr o variabila usernameu logat pe sesiune
            var username = HttpContext.Session.GetString("username");

            // verific daca acesta e egal cu catalin , catalin fiind cel aprobat ca poa sa intre pe admin
            if (username != null && username.Equals("catalin", StringComparison.OrdinalIgnoreCase))
            {
                var carInputModel = new Car();
                return View(carInputModel);
            }
            else
            {
                // eroare  cu TempData ca sa pot transmite cu bootstrap pe views
                TempData["ErrorMessage"] = "Accesul interzis. Trebuie sa fii logat ca si administrator";
                return RedirectToAction("Index", "Home");
            }
        }

        
        [HttpPost]
        public IActionResult AddCar(Car carInput)
        {
            if (ModelState.IsValid)
            {
                // tot inputul realizat de admin
                Console.WriteLine($"Received car data: {carInput.Name}, {carInput.Brand}");
                var car = new Car
                {
                    Name = carInput.Name,
                    Brand = carInput.Brand,
                    Model = carInput.Model,
                    ShortDescription = carInput.ShortDescription,
                    LongDescription = carInput.LongDescription,
                    Price = carInput.Price,
                    yearProduction = carInput.yearProduction,
                    horsePower = carInput.horsePower,
                    newtonMetters = carInput.newtonMetters,
                    engineCapacity = carInput.engineCapacity,
                    fuelType = carInput.fuelType,
                    gearBox = carInput.gearBox,
                    ImageUrl = carInput.ImageUrl,
                    ImageThumbnailUrl = carInput.ImageThumbnailUrl,
                   
                };

                // adaugarea pe baza de date, cu context add si save
              
                _context.Cars.Add(car);
                _context.SaveChanges();

                Console.WriteLine("Car added successfully to the database.");

                return RedirectToAction("Index", "Home");
            }

            return View(carInput);
        }
    }

}
