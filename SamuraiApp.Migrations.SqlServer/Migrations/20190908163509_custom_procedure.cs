using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiApp.Migrations.SqlServer.Migrations
{
    public partial class custom_procedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    CREATE PROCEDURE dbo.FilterSamuraiByPartOfName
                        @namepart nvarchar(50)
                    AS
                        SELECT *
                        FROM Samurais
                        WHERE Name LIKE '%' + @namepart + '%'
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                if OBJECT_ID('dbo.FilterSamuraiByPartOfName') IS NOT NULL
                BEGIN
                    DROP PROCEDURE dbo.FilterSamuraiByPartOfName
                END");
        }
    }
}
