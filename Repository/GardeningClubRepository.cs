using LocalGardenCommunity.Data;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Repository
{
    public class GardeningClubRepository : IGardeningClubRepository

    {
        private readonly ApplicationDbContext _context;
        public GardeningClubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(GardeningClub gardeningClub)
        {
            _context.Add(gardeningClub);
            return Save();
        }

        public bool Delete(GardeningClub gardeningClub)
        {
            _context.Remove(gardeningClub);
            return Save();
        }

        public async Task<IEnumerable<GardeningClub>> GetAll()
        {
             return await _context.GardeningClubs.ToListAsync();
        }

        public async Task<GardeningClub> GetByIdAsync(int id)
        {
            return await _context.GardeningClubs.Include(i => i.Address).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<GardeningClub>> GetGardeningClubByCity(string city)
        {
            return await _context.GardeningClubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(GardeningClub gardeningClub)
        {
            _context.Update(gardeningClub);
            return Save();
        }
    }
}