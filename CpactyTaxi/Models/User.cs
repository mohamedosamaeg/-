using CpactyTaxi.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace CpactyTaxi.Models
{
    public class User:Base
    {
        public string FullName { get; set; }
        
        public string Password { get; set; }
        [NotMapped]
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole UserRole { get; set; }

        public string Mobile { get; set; }
    }
}
