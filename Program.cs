using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using LocalGardenCommunity.Data;
using LocalGardenCommunity.Helpers;
using LocalGardenCommunity.Interfaces;
using LocalGardenCommunity.Repository;
using LocalGardenCommunity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IGardeningClubRepository, GardeningClubRepository>();
builder.Services.AddTransient<IGardenContestRepository, GardenContestRepository>();
builder.Services.AddTransient<IPhotoService, PhotoService>();

var config = builder.Configuration.GetSection("CloudinarySettings").Get<CloudinarySettings>();

builder.Services.AddTransient<Cloudinary,Cloudinary>(x => {
     return new Cloudinary(new Account(
config.CloudName,
config.ApiKey,
config.ApiSecret
));
}
);



builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
  
var app = builder.Build();

if(args.Length ==1 && args [0].ToLower()=="seeddata")
{
    //Seed.SeedUsersandRolesAsync(app);
    Seed.SeedData(app);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
