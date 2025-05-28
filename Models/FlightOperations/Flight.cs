using AirPorASPMVC.Models.Airport;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPorASPMVC.Models.FlightOperations
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string FlightStatus { get; set; }

        [ForeignKey("AirId")]
        public Airline Airline { get; set; }
        public int AirId { get; set; }

        [ForeignKey("GateId")]
        public Gate Gate { get; set; }
        public int GateId { get; set; }


    }
}
