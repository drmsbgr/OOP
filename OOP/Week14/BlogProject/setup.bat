dotnet new sln
dotnet new console -o BlogApp
dotnet sln BlogProject.sln add BlogApp
cd BlogApp
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet run
