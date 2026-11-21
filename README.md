# MVC Application 2 — Form Authentication

A classic ASP.NET MVC application targeting .NET Framework 4.7.2. The project includes user and authentication view models, data and migration components, Razor views, and Entity Framework 6.

## Technology Stack
- C#
- ASP.NET MVC on .NET Framework 4.7.2
- Entity Framework 6
- Razor views
- IIS Express / Visual Studio

## Project Structure
- `App_Start/` — MVC application configuration.
- `Data/` — data-access components.
- `Helpers/` — application helper classes.
- `Migrations/` — Entity Framework migrations.
- `Models/` — user, login, and registration view models.
- `Views/` — Razor UI views.
- `Global.asax` — application lifecycle entry point.
- `Web.config` — application configuration.

## Getting Started
1. Open the solution in Visual Studio with .NET Framework 4.7.2 targeting support.
2. Restore the NuGet packages.
3. Configure the database connection in the local `Web.config`. Do not commit credentials.
4. Apply the required Entity Framework migrations using the project's configured workflow.
5. Run the application using IIS Express.

Review the login and registration view models, user model, and Razor views for the implemented form-authentication flow. Authentication and authorization behavior should be verified against the actual application configuration before deployment.