using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class PassengerController : Controller
    {

        private ApplicationDbContext _context;
        public PassengerController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
