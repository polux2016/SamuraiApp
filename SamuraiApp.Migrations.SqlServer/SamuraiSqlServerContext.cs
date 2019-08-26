using SamuraiApp.Data;
using Microsoft.EntityFrameworkCore;

namespace SamuraiApp.Migrations.SqlLite
{
    public class SamuraiSqlServerContext : SamuraiContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = SamuraiData; "
                + "User Id = sa; Password=reallyStrongPwd123;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
