using System;
using SamuraiApp.Domain;
using SamuraiApp.Migrations.SqlLite;
using SamuraiApp.Migrations.SqlServer;

namespace SamuraiApp.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertSamurai();
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai() { Name = "Julia" };
            using (var context = new SamuraiSqlLiteContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
