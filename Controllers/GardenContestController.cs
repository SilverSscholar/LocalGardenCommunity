using LocalGardenCommunity.Data;
using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
