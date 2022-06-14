using CpactyTaxi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CpactyTaxi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //List<Result> rsl= new List<Result>(){ new Result(){brandName="yTaxt" , price=5
            //new Result(){brandName}}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            
        }
        public IActionResult _Login()
        {
            return View();
        }
        public IActionResult VerifyCode()
        {
            return View();
        }
    }
}