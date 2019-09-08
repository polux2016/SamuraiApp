using SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp.Migrations.SqlLite
{
    public class SamuraiSqlLiteContext : SamuraiContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "/Users/andrejpoluhovic/Documents/Documents/Projects/SamuraiApp/SQLLite/";
            optionsBuilder.UseSqlite($"Data Source={path}/sqllite.db;", 
                options => {
                    options.MaxBatchSize(100);
                });
            base.OnConfiguring(optionsBuilder);
        }
    }
}
