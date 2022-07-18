using LocalGardenCommunity.Data;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Controllers
{
    public class GardenClubController : Controller
    {
        
        private readonly IGardeningClubRepository _gardeningClubRepository;

        public GardenClubController(ApplicationDbContext context, IGardeningClubRepository gardeningClubRepository)
            
        {
           
            _gardeningClubRepository = gardeningClubRepository;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<GardeningClub> gardeningClubs = await _gardeningClubRepository.GetAll();
            return View(gardeningClubs);
        }
        
        public async Task <IActionResult> Detail(int id)
        {
            GardeningClub gardeningClub = await _gardeningClubRepository.GetByIdAsync(id);
            return View(gardeningClub);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(GardeningClub gardeningClub)
        {
            if (!ModelState.IsValid)
            {
                return View(gardeningClub);
            }
            _gardeningClubRepository.Add(gardeningClub);
            return RedirectToAction("Index");
        }
    }
}
