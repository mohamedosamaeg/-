using CpactyTaxi.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace CpactyTaxi.Models
{
    public class User:Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole userRole { get; set; }

        public string mobile { get; set; }
    }
}
