using Microsoft.AspNetCore.Mvc;
using argeya.Data;
using argeya.Models;
using System.Threading.Tasks;

namespace argeya.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            return View(contact);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
