using LocalGardenCommunity.Data;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Models;
using LocalGardenCommunity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Controllers
{
    public class GardenContestController : Controller
    {
        private readonly IGardenContestRepository _gardenContestRepository;
        private readonly IPhotoService _photoService;


        public GardenContestController( IGardenContestRepository gardenContestRepository, IPhotoService photoservice)
        {
            _gardenContestRepository = gardenContestRepository;
            _photoService = photoservice;
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
       [HttpPost]
        public async Task<IActionResult> Create(CreateGardenContestViewModel gardenContestVM)
            {
                if (ModelState.IsValid)
                {
                    var result = await _photoService.AddPhotoAsync(gardenContestVM.Image);

                    var gardenContest = new GardenContest

                    {
                        Title = gardenContestVM.Title,
                        Description = gardenContestVM.Description,
                        Image = result.Url.ToString(),
                        Address = new Address
                        {
                            Street = gardenContestVM.Address.Street,
                            City = gardenContestVM.Address.City,
                            State = gardenContestVM.Address.State

                        }

                    };
                    _gardenContestRepository.Add(gardenContest);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Photo upload failed");
                }

                return View(gardenContestVM);

            }
        }
    }