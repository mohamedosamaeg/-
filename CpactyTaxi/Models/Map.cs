using CpactyTaxi.Bases;

namespace CpactyTaxi.Models
{
    public class Map :Base
    {
        public string From { get; set; }
        public string To { get; set; }
        public string AddressIP { get; set; }
    }
}
