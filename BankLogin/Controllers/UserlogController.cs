using BankLogin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankLogin.Controllers
{
    public class UserlogController : Controller
    {
        private readonly Userlog user = new Userlog()
        {
            UserId = 100,
            Password = "Rahul@123"
        };
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Userlog logs)
        {
            if(ModelState.IsValid && logs.UserId == user.UserId && logs.Password == user.Password)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View(logs);
            }
            
        }
    }
}
