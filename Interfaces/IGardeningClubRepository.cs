using LocalGardenCommunity.Controllers;
using LocalGardenCommunity.Models;

namespace LocalGardenCommunity.Interfaces
{
    public interface IGardeningClubRepository
    {
        Task<IEnumerable<GardeningClub>> GetAll();

        Task<GardeningClub> GetByIdAsync(int id);
        Task<IEnumerable<GardeningClub>> GetGardeningClubByCity(string city);
        bool Add(GardeningClub gardeningClub);
        bool Update(GardeningClub gardeningClub);
        bool Delete(GardeningClub gardeningClub);
        bool Save();
    }
}


