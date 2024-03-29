using SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp.Migrations.SqlServer
{
    public class SamuraiSqlServerContext : SamuraiContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = SamuraiData; "
                + "User Id = sa; Password=yourStrong(!)Password;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
