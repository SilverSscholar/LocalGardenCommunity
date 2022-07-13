using LocalGardenCommunity.Data;
using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        
        public IActionResult Detail(int id)
        {
            GardeningClub gardeningClub = _context.GardeningClubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(gardeningClub);
        }
    }
}
