using LocalGardenCommunity.Data;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Controllers
{
    public class GardenContestController : Controller
    {
        private readonly IGardenContestRepository _gardenContestRepository;


        public GardenContestController(IGardenContestRepository gardenContestRepository)
        {
            _gardenContestRepository = gardenContestRepository;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<GardenContest> gardenContests = await _gardenContestRepository.GetAll();
            return View(gardenContests);
        }
        public async Task < IActionResult> Detail(int id)
        {
            GardenContest gardenContest = await _gardenContestRepository.GetByIdAsync(id);
            return View(gardenContest);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
