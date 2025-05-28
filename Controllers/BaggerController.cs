using AirPorASPMVC.Context;
using Microsoft.AspNetCore.Mvc;

namespace AirPorASPMVC.Controllers
{
    public class BaggerController : Controller
    {

        private ApplicationDbContext _context;
        public BaggerController(ApplicationDbContext context) // obect context 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
