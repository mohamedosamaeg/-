using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult ProfileIndex()
        {
            return View();
        }
    }
}
