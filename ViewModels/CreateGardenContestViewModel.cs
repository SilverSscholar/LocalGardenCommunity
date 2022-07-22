using LocalGardenCommunity.Data.Enum;
using LocalGardenCommunity.Models;

namespace LocalGardenCommunity.ViewModels
{
    public class CreateGardenContestViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public GardenContestCategory GardenContestCategory { get; set; }
    }
}
