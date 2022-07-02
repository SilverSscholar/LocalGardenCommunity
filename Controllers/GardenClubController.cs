using Microsoft.AspNetCore.Mvc;

namespace LocalGardenCommunity.Controllers
{
    public class GardenClubController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
