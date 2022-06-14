using CpactyTaxi.Bases;

namespace CpactyTaxi.Models
{
    public class ErrorViewModel :Base
    { 
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}