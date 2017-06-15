using Microsoft.EntityFrameworkCore;

namespace GIS.Models
{
    public class GISContext : DbContext
    {
        public DbSet<Construction> Constructions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=GISDB;Trusted_Connection=True;");
        }

    }
}
