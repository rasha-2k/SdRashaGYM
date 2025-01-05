using Microsoft.EntityFrameworkCore;
using SdRashaGYMV2.Models;

namespace SdRashaGYMV2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Rasha", Password = "rasha123" },
                new User { Id = 2, Username = "Sdra", Password = "sdra123" },
                new User { Id = 3, Username = "Dalaa", Password = "dalaa123" }
                );
        }
    }
}
