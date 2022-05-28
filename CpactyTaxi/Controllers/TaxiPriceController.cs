using CpactyTaxi.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class TaxiPriceController : Controller
    {
        public IActionResult TaxiIndex()
        {
            List<TaxiResult> taxiResults = new List<TaxiResult>()
            {
                new TaxiResult(){ TaxiName="Uber",Cost=10},
                new TaxiResult(){ TaxiName="Yellow taxi",Cost=20},
                new TaxiResult(){ TaxiName="Indrive",Cost=15},
            };
            return View(taxiResults);
        }
    }
}
