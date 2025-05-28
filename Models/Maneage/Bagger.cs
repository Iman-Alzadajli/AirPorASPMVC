using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPorASPMVC.Models.Maneage
{
    public class Bagger
    {
        [Key]
        public int Id{ get; set; }
        public double Weight { get; set; }
        public string TrackingNum { get; set; }

        [ForeignKey("PassengerId")]
        public Passenger Passenger { get; set; }
    
        public int PassengerId { get; set; }
       
}
}
