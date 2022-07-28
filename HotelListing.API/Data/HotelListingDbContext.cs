using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) :base(options)
        {
               
        }
        public DbSet <Hotel> Hotels { get; set; }
        public DbSet <Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                Name = "India",
                ShortName = "IN"

            }, new Country
            {
                Id = 2,
                Name = "Uinted State of America",
                ShortName = "USA"

            },
            new Country { Id = 3, Name = "Singapore", ShortName = "SG" }
            );
            modelBuilder.Entity<Hotel>().HasData(new Hotel
            {
                Id = 1,
                Name = "Holiday Inn",
                Address="Ranjit Avenue, Amritsar",
                CountryId = 1,
                Rating=4.5

            },new Hotel
            {
                Id = 2,
                Name = "Park Inn",
                Address = "Sohna Road, Gurugram",
                CountryId = 1,
                Rating = 4.5

            }, new Hotel
            {
                Id = 3,
                Name = "Holiday Inn",
                Address = "Wad deyan teeji gali, Singapore",
                CountryId = 3,
                Rating = 4.5

            }
           );
        }
    }
}
