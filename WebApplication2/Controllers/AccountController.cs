using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View(new Quiz());
        }

        [HttpPost]
        public IActionResult Register(Quiz quiz)
        {
            return View();
        }


    }
}
