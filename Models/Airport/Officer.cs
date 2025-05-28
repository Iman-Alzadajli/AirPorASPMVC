using System.ComponentModel.DataAnnotations;

namespace AirPorASPMVC.Models.Airport
{
    public class Officer
    {
        [Key]
        public int Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
    }
}
