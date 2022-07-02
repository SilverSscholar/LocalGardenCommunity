using System.ComponentModel.DataAnnotations;

namespace LocalGardenCommunity.Models
{
    public class AppUser 
    {
        [Key]
        public string Id { get; set; }
        public int? MyVegetables { get; set; }
       
        public Address? Address { get; set; }
        public ICollection<GardenContest> GardenContestes { get; set; }
        public ICollection<GardeningClub> GardeningClubs { get; set; }

    }
}
