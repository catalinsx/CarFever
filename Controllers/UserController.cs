using FinalProject.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace FinalProject.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }

        // iactionu de vizualizare a login pageului
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {

            // se salveaza intr o variabila userul din ef care indeplineste criteriile din lambda
           var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (existingUser != null)
            {
                // pur si simplu sistemul de login
                if (!string.IsNullOrEmpty(existingUser.Username))
                {
                    Trace.WriteLine("Userul " + user.Username + " s-a logat la data de " + DateTime.Now);
                    HttpContext.Session.SetString("username", existingUser.Username);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   
                    ModelState.AddModelError("", "Numele de utilizator este invalid.");
                    return View(user);
                }
            }
            else
            {
                ModelState.AddModelError("", "Nume de utilizator sau parola incorecte.");
                return View(user);
            }
        }


        // register 

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // verifica daca exista un user deja cu numele asta
                var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username);

                if (existingUser == null)
                {
                    // daca userul e null, se adauga in ef
                    _context.Users.Add(user);
                    _context.SaveChanges();

                    Trace.WriteLine("Userul " + user.Username + " s-a înregistrat la data de " + DateTime.Now);
                    return RedirectToAction("Login");
                }

                ModelState.AddModelError("", "Numele de utilizator este deja folosit. Alegeti alt nume de utilizator.");
            }

            return View(user);
        }

    }
}
