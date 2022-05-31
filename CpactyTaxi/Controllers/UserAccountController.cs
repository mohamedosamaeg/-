using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
