using LocalGardenCommunity.Models;

namespace LocalGardenCommunity.Interfaces
{
    public interface IGardenContestRepository
    {
        Task<IEnumerable<GardenContest>> GetAll();

        Task<GardenContest> GetByIdAsync(int id);
        Task<IEnumerable<GardeningClub>> GetAllGardenContestsByCity(string city);
        bool Add(GardenContest gardenContest);
        bool Update(GardenContest gardenContest);
        bool Delete(GardenContest gardenContest);
        bool Save();
    }
}
