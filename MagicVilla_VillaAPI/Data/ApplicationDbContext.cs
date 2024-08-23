using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

      
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                 new Villa()
                 {
                     Id = 2,
                     Name = "Diamond Pool Villa",
                     Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                     ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                     Occupancy = 4,
                     Rate = 600,
                     Sqft = 1100,
                     Amenity = "",
                     CreatedDate = DateTime.Now,

                 },
                  new Villa()
                  {
                      Id = 3,
                      Name = "Queen Pearl Villa",
                      Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                      ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",                      Occupancy = 2,
                      Rate = 150,
                      Sqft = 500,
                      Amenity = "",
                      CreatedDate = DateTime.Now,

                  },
                   new Villa()
                   {
                       Id = 4,
                       Name = "Jason Villa",
                       Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                       ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",                       Occupancy = 6,
                       Rate = 100,
                       Sqft = 250,
                       Amenity = "",
                       CreatedDate = DateTime.Now,

                   },
                    new Villa()
                    {
                        Id = 5,
                        Name = "Royal Villa",
                        Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",                        Occupancy = 5,
                        Rate = 200,
                        Sqft = 550,
                        Amenity = "",
                        CreatedDate = DateTime.Now,
                    });
        }
    }
}
