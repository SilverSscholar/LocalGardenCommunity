using System.ComponentModel.DataAnnotations;
using LocalGardenCommunity.Data.Enum;
using LocalGardenCommunity.Models;

namespace LocalGardenCommunity.ViewModels
{
    public class CreateGardeningClubViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile Image { get; set; }
        public GardeningClubCategory GardeningClubCategory { get; set; }
    }
}
