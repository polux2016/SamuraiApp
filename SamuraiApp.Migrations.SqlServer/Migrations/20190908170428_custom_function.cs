using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Migrations.SqlServer.Migrations
{
    public partial class custom_function : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    CREATE FUNCTION dbo.FilterSamuraiByPartOfNameFunc
                        (@namepart nvarchar(50))
                    RETURNS TABLE  
                    AS  
                    RETURN ( 
                        SELECT *
                        FROM Samurais
                        WHERE Name LIKE '%' + @namepart + '%'
                    )
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                if OBJECT_ID('dbo.FilterSamuraiByPartOfNameFunc') IS NOT NULL
                BEGIN
                    DROP FUNCTION dbo.FilterSamuraiByPartOfNameFunc
                END");
        }
    }
}
