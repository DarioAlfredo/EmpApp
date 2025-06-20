# EmpApp – Deployment Instructions

## Prerequisites

- .NET 8 SDK (https://dotnet.microsoft.com/download)
- Visual Studio 2022 or later (with ASP.NET and web development workload)
- SQL Server (LocalDB, Developer, or Express edition)
- SQL Server Management Tool (Visual Studio SQL Server Object Explorer, Azure Data Studio, or SSMS)

## 1. Restore the Database

1. Open your SQL management tool (e.g., Visual Studio SQL Server Object Explorer or Azure Data Studio).
2. Create a new database (e.g., `EmployeeDb`).
3. Open a new SQL query window connected to your new database.
4. Run the provided SQL scripts inside EmpApp\database\* in this order:
    - All table creation scripts (e.g., `EmployeeTitle`, `Employee`, etc.)
    - All stored procedure scripts
5. Verify that tables and stored procedures are created.

## 2. Update the Connection String

1. In the Blazor project, open `appsettings.json`.
2. Find the `DefaultConnection` string.
3. Update it to point to your SQL Server instance and database. Example:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDb;Trusted_Connection=True;"
}
```

- If using SQL authentication, add `User Id=...;Password=...;` to the connection string.

## 3. Build and Run the Application

1. Unzip and open the solution in Visual Studio 2022.
2. Restore NuGet packages if prompted.
3. Build the solution.
4. Set `EmpApp` as the startup project.
5. Run the project (F5 or Ctrl+F5).

## 4. Using the Application

- Use the sidebar to navigate between Employees and Titles.
- You can perform full CRUD operations on both Employees and Titles.

## Troubleshooting

- If you get database connection errors, double-check your connection string and SQL Server instance.
- Make sure your SQL Server is running and accessible.
  - If you need to re-do the database, re-run the Stored Procedures and Tables SQL scripts inside EmpApp\database folder.

---

**Files included:**
- Blazor project source code
- SQL scripts for tables and stored procedures

---
