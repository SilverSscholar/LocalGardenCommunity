using LocalGardenCommunity.Data.Enum;
using LocalGardenCommunity.Models;

namespace LocalGardenCommunity.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.GardeningClubs.Any())
                {
                    context.GardeningClubs.AddRange(new List<GardeningClub>()
                    {
                        new GardeningClub()
                        {
                            Title = "Garden Club 1",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            GardeningClubCategory = GardeningClubCategory.Outdoor,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                         },
                        new GardeningClub()
                        {
                            Title = "Garden Club 2",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first cinema",
                            GardeningClubCategory = GardeningClubCategory.Homesteading,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new GardeningClub()
                        {
                            Title = "Garden Club 3",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first club",
                            GardeningClubCategory = GardeningClubCategory.Indoor,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new GardeningClub()
                        {
                            Title = "Garden Club 4",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first club",
                            GardeningClubCategory = GardeningClubCategory.Floral,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Michigan",
                                State = "NC"
                            }
                        },
                           new GardeningClub()
                        {
                            Title = "Garden Club 5",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first club",
                            GardeningClubCategory = GardeningClubCategory.Greenhouse,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Kentucky",
                                State = "NC"
                            }
                         }

                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.GardenContestes.Any())
                {
                    context.GardenContestes.AddRange(new List<GardenContest>()
                    {
                        new GardenContest()
                        {
                            Title = "Contest 1",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first race",
                            GardenContestCategory = GardenContestCategory.Young_Gardeners,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new GardenContest()
                        {
                            Title = "Contest 2",
                            Image = "https://www.thoughtco.com/thmb/BzILs7mpbaH0_XV_XKhoOgcAlyw=/3865x2576/filters:fill(auto,1)/spring-garden-with-sundial-in-circular-bed-in-centre-of-lawn-with-ceanothus--ceanothus---puget-blue--130793740-593d98535f9b58d58ac501cb.jpg",
                            Description = "This is the description of the first race",
                            GardenContestCategory = GardenContestCategory.Survival_Garden,
                            AddressId = 5,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

        //public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        //{
        //    using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        //    {
        //        //Roles
        //        var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        //            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

        //        //Users
        //        var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
        //        string adminUserEmail = "teddysmithdeveloper@gmail.com";

        //        var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
        //        if (adminUser == null)
        //        {
        //            var newAdminUser = new AppUser()
        //            {
        //                UserName = "teddysmithdev",
        //                Email = adminUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAdminUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
        //        }

        //        string appUserEmail = "user@etickets.com";

        //        var appUser = await userManager.FindByEmailAsync(appUserEmail);
        //        if (appUser == null)
        //        {
        //            var newAppUser = new AppUser()
        //            {
        //                UserName = "app-user",
        //                Email = appUserEmail,
        //                EmailConfirmed = true,
        //                Address = new Address()
        //                {
        //                    Street = "123 Main St",
        //                    City = "Charlotte",
        //                    State = "NC"
        //                }
        //            };
        //            await userManager.CreateAsync(newAppUser, "Coding@1234?");
        //            await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
        //        }
    }
}



 