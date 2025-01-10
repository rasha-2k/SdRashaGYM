using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SdRashaGYMV2.Models;
using System.Configuration;

namespace SdRashaGYMV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Package> Packages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Package>().HasData(
                new Package
                {
                    Id = 1,
                    PackageName = "Test Package",
                    Duration = "30",
                    Price = 100,
                    Days = "Sunday, Monday"
                },
                new Package
                {
                    Id = 2,
                    PackageName = "Test2 Package",
                    Duration = "60",
                    Price = 200,
                    Days = "Tuesday, Wednesdsy"
                }
                );
        }

    }
}
