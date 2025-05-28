using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class TerminalController : Controller
    {

        private ApplicationDbContext _context;
        public TerminalController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
