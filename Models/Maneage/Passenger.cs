using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace AirPorASPMVC.Models.Maneage
{
    public class Passenger
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<Bagger> Baggers { get; set; } = new List<Bagger>();
    }
}
