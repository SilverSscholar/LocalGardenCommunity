using LocalGardenCommunity.Data;
using Microsoft.AspNetCore.Mvc;

namespace LocalGardenCommunity.Controllers
{
    public class GardenClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GardenClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var gardeningClubs = _context.GardeningClubs.ToList();
            return View(gardeningClubs);
        }
    }
}
