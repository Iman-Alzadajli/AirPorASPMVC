using System.ComponentModel.DataAnnotations;

namespace AirPorASPMVC.Models.Airport
{
    public class Terminal
    {
        [Key]
        public int Id{ get; set; }
        public string TerName { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }

        public ICollection<Gate> Gates { get; set; }
        public IEnumerable<Checkpoint> Checkpoints { get; set; } = new List<Checkpoint>();
    }
}
