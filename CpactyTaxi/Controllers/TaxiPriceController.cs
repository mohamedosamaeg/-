using CpactyTaxi.Interfaces;
using CpactyTaxi.View_Models;
using Microsoft.AspNetCore.Mvc;

namespace CpactyTaxi.Controllers
{
    public class TaxiPriceController : Controller
    {
        private readonly IRideInfoRepository rideInfoRepository;

        public TaxiPriceController(IRideInfoRepository _rideInfoRepository)
        {
            rideInfoRepository = _rideInfoRepository;
        }
        public IActionResult TaxiIndex()
        {
            rideInfoRepository.GetTaxiResult();
            List<TaxiResultDto> taxiResults = new List<TaxiResultDto>()
            {
                new TaxiResultDto(){ TaxiName="Uber",Cost=150},
                new TaxiResultDto(){ TaxiName="Yandex taxi",Cost=205},
                new TaxiResultDto(){ TaxiName="Ситимобил",Cost=159},
            };
            return View(taxiResults);
            //Copy Rights MoOsama
        }
       
    }
}
