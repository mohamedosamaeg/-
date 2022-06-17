using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class TaxiServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
