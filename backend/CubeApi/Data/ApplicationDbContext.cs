using Microsoft.EntityFrameworkCore;
using CubeApi.Models;

namespace CubeApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CubeCase> CubeCases { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=cube.db");
            }
        }
    }
}
