namespace CpactyTaxi.Audits
{
    public class Audit
    {
        public int? RequestedBy { get; set; }
        public DateTime RequestedDate { get; set; }
        public int? LastRequestedBy { get; set; }
        public DateTime LastRequestedDate { get; set; } = DateTime.Now;
    }
}
