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
                new TaxiResult(){ TaxiName="Uber",Cost=150},
                new TaxiResult(){ TaxiName="Yandex taxi",Cost=205},
                new TaxiResult(){ TaxiName="Ситимобил",Cost=159},
            };
            return View(taxiResults);
            //Copy Rights MoOsama
        }
       
    }
}
