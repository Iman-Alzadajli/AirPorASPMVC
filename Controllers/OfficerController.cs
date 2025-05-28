using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class OfficerController : Controller
    {

        private ApplicationDbContext _context;
        public OfficerController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
