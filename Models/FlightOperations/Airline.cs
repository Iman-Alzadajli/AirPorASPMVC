using System.ComponentModel.DataAnnotations;

namespace AirPorASPMVC.Models.FlightOperations
{
    public class Airline
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNum { get; set; }
        public string Email { get; set; }

        public IEnumerable<Flight> Flights { get; set; } = new List<Flight>();

    }
}
