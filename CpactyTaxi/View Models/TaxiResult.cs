using System.ComponentModel;

namespace CpactyTaxi.View_Models
{
    public class TaxiResult
    {
        [DisplayName("Taxi Name")]
        public string TaxiName { get; set; }
        public double Cost { get; set; }
    }
}
