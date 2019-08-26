
# Test project to learn EF Core.

**IDE**: VS Code

**Link to curse**: [here](https://app.pluralsight.com/library/courses/entity-framework-core-getting-started/table-of-contents)

#Useful command for current project

**dotnet solution commands**

dotnet add SamuraiApp.Domain reference SamuraiApp.Data
dotnet add SamuraiApp.Migrations.SqlLite reference SamuraiApp.Data

**Migrations**

dotnet ef migrations add init_sqlserver -v --project SamuraiApp.Migrations.SqlServer
dotnet ef migrations script -o ./res_sqlserver.sql -v --project SamuraiApp.Migrations.SqlServer

dotnet ef migrations add init_sqllite -v --project SamuraiApp.Migrations.SqlLite
dotnet ef migrations script -o ./res_sqllite.sql -v --project SamuraiApp.Migrations.SqlLite

dotnet ef migrations add JoinTables -v --project SamuraiApp.Migrations.SqlLite
dotnet ef migrations add JoinTables -v --project SamuraiApp.Migrations.SqlServer

**Init Databases**

dotnet ef database update --project SamuraiApp.Migrations