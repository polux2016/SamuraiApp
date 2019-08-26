using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "/Users/andrejpoluhovic/Documents/Documents/Projects/SamuraiApp/SQLLite/";
            optionsBuilder.UseSqlite($"Data Source={path}/sqllite.db;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
