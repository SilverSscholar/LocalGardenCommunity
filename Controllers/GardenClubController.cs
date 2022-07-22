using LocalGardenCommunity.Data;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Models;
using LocalGardenCommunity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Controllers
{
    public class GardenClubController : Controller
    {

        private readonly IGardeningClubRepository _gardeningClubRepository;
        private readonly IPhotoService _photoService;

        public GardenClubController( IGardeningClubRepository gardeningClubRepository, IPhotoService photoService)

        {

            _gardeningClubRepository = gardeningClubRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<GardeningClub> gardeningClubs = await _gardeningClubRepository.GetAll();
            return View(gardeningClubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            GardeningClub gardeningClub = await _gardeningClubRepository.GetByIdAsync(id);
            return View(gardeningClub);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGardeningClubViewModel gardeningClubVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(gardeningClubVM.Image);

                var gardeningClub = new GardeningClub
                {
                    Title = gardeningClubVM.Title,
                    Description = gardeningClubVM.Description,
                    Image = result.Url.ToString(),
                    Address = new Address
                    {
                        Street = gardeningClubVM.Address.Street,
                        City = gardeningClubVM.Address.City,
                        State = gardeningClubVM.Address.State
                    }
                };
                _gardeningClubRepository.Add(gardeningClub);
                return RedirectToAction("Index");
            }

            else
            {
                ModelState.AddModelError("", "Photo upload failed");
            }

            return View(gardeningClubVM);

        }
    }
}