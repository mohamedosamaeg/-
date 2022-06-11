using CpactyTaxi.Enums;
using System.ComponentModel.DataAnnotations;

namespace CpactyTaxi.View_Models
{
    public class RideRequestDto
    {
        public Guid Id { get; set; }
        public string? UserID { get; set; }
        public TaxiType taxiType { get; set; }
        [Required (ErrorMessage ="You should choose pick up point")]
        public string PickUp { get; set; }
        [Required(ErrorMessage = "You should choose pick in point")]
        public string PickIn { get; set; }
    }
}
