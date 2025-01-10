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

        public DbSet<User> Users { get; set; }
        public DbSet<Package> Packages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Package>()
        .Property(p => p.Price)
        .HasPrecision(18, 2);

            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        UserName = "Rasha",
            //        PasswordHash = "rasha123",
            //        FullName = "Rasha Al-Saleh",
            //        DateOfBirth = new DateTime(2005, 2, 5),
            //        IsMale = false,
            //        Email = "rasha@example.com",
            //        PhoneNumber = "1234567890",
            //        Description = "Gym member and student"
            //    },
            //    new User
            //    {
            //        UserName = "Sdra",
            //        PasswordHash = "sdra123",
            //        FullName = "Sdra Khalid",
            //        DateOfBirth = new DateTime(2003, 1, 25),
            //        IsMale = false,
            //        Email = "sdra@example.com",
            //        PhoneNumber = "0987654321",
            //        Description = "Passionate about fitness"
            //    },
            //    new User
            //    {
            //        UserName = "Dalaa",
            //        PasswordHash = "dalaa123",
            //        FullName = "Dalaa Saqer",
            //        DateOfBirth = new DateTime(2003, 3, 30),
            //        IsMale = false,
            //        Email = "dalaa@example.com",
            //        PhoneNumber = "1122334455"
            //    }
            //);
        }

    }
}
