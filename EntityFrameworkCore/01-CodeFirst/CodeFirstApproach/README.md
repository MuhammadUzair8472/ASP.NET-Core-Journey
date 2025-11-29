# CodeFirstApproach - ASP.NET Core Entity Framework

This project demonstrates the Code First approach using ASP.NET Core and Entity Framework Core.

## Features
- Code First Database Creation
- Student Model Implementation
- Database Context Configuration
- Migration Management
- MVC Pattern Implementation

## Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#

## Project Structure
- **Models/**: Contains entity models (Student, StudentDBContext)
- **Controllers/**: Contains MVC controllers
- **Views/**: Contains Razor views
- **Migrations/**: Contains EF Core migrations

## How to Run
1. Update connection string in `appsettings.json`
2. Run migrations: `dotnet ef database update`
3. Start the application: `dotnet run`