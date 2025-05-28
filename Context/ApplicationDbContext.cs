using AirPorASPMVC.Models.Airport;
using AirPorASPMVC.Models.FlightOperations;
using AirPorASPMVC.Models.Maneage;
using Microsoft.EntityFrameworkCore;

namespace AirPorASPMVC.Context
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

      public DbSet<Checkpoint> checkpoints { get; set; }

       public DbSet<Gate> Gates { get; set; }

        public DbSet<Officer> Officers { get; set; }

        public DbSet<Terminal> Terminals { get; set; }

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Bagger> Baggers { get; set; }

        public DbSet<Passenger> Passengers { get; set; }








    }
}
