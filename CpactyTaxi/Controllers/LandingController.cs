using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult LandingIndex()
        {
            return View();
        }
        public IActionResult LoginIndex()
        {
            return View();
        }
        public IActionResult RegisterIndex()
        {
            return View();
        }
        
    }
}
