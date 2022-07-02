using LocalGardenCommunity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocalGardenCommunity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<GardenContest> GardenContestes { get; set; }
        public DbSet<GardeningClub> GardeningClubs { get; set; }
        public DbSet<Address> Addresses { get; set; }


    }
}