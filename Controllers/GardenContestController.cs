using Microsoft.AspNetCore.Mvc;

namespace LocalGardenCommunity.Controllers
{
    public class GardenContestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
