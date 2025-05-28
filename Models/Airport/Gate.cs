using AirPorASPMVC.Models.FlightOperations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPorASPMVC.Models.Airport
{
    public class Gate
    {
        [Key]
        public int Id { get; set; }
        public string GateName { get; set; }
        public string AvailableStatus { get; set; }

        [ForeignKey("TerminalId")]
        public Terminal Terminal { get; set; }
        public int TerminalId { get; set; }


        public IEnumerable<Flight> Flights { get; set; } = new List<Flight>();
    }
}
