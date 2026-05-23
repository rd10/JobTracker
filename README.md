# JobTracker

A web application for tracking job applications built using ASP.NET Core MVC and C#.

## Features
- Add, edit, and delete job applications
- Track application status (Applied, Phone Screen, Interview, Offer, Rejected)
- Secure login with user authentication
- Filter applications by status

## Tech Stack
- ASP.NET Core MVC
- C# / .NET 9
- Entity Framework Core
- SQLite
- ASP.NET Identity (authentication)
- Bootstrap 5

## Getting Started

### Prerequisites
- .NET 9 SDK
- Visual Studio 2026

### Run Locally
1. Clone the repo
   git clone https://github.com/rd10/JobTracker.git
2. Navigate to the project folder
   cd JobTracker
3. Apply database migrations
   dotnet ef database update
4. Run the app
   dotnet run

## Roadmap
- Dashboard with application stats
- Filter and search
- Email reminders for stale applications
- CSV export