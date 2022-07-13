using LocalGardenCommunity.Data;
using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Controllers
{
    public class GardenContestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GardenContestController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<GardenContest> gardenContests = _context.GardenContestes.ToList();
       
            return View(gardenContests);
        }
        public IActionResult Detail(int id)
        {
            GardenContest gardenContest = _context.GardenContestes.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(gardenContest);
        }
    }
}
