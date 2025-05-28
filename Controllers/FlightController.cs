using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class FlightController : Controller
    {

        private ApplicationDbContext _context;
        public FlightController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
