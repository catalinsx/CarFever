using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class CarController : Controller
    {
        private readonly CarsDbContext _context;

        public CarController(CarsDbContext context)
        {
            _context = context;
        }
    
        // lista de masini preluata din ef
        public IActionResult List()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }

        // detaliile preluate din ef bazate pe un id, fiecare masina are un id
        public IActionResult Details(int id)
        {
            // se verifica daca exista masina masina, iar firstordefault e o metoda oferita de linq ca sa returneze
            // primul car gasit dupa cerintele date in lambda expression
            var car = _context.Cars.FirstOrDefault(c=>c.CarId == id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}
