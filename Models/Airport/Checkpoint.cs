using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPorASPMVC.Models.Airport
{
    public class Checkpoint
    {
        [Key]
        public int Id { get; set; }
        public int PassengerCapacity { get; set; }
        public string Location { get; set; }

        [ForeignKey("TerminalId")]
        public Terminal Terminal { get; set; }

        public int TerminalId { get; set; }
    }
}
