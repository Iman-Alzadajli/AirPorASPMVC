using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class AirlineController : Controller
    {
        private ApplicationDbContext _context;
        public AirlineController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
