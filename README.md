
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

dotnet ef database update --project SamuraiApp.Migrations.SqlLite
dotnet ef database update --project SamuraiApp.Migrations.SqlServer

**SQL Server in docker**
docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 microsoft/mssql-server-linux