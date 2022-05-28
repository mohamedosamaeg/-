using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Map()
        {
            return View();
        }
    }
}
