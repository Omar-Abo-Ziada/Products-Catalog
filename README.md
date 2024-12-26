# Product Management System

This repository contains an implementation of a **Product Management System** built using **ASP.NET Core MVC** and **Entity Framework (EF Core)** as the ORM. The project follows the **Clean Architecture** principles to ensure maintainability, scalability, and separation of concerns. 

---

## **Features**
### Completed Features:
1. **Clean Architecture**: Separation of concerns with clearly defined layers for data, business logic, and presentation.
2. **Generic Repository Pattern**: To abstract data access and allow for cleaner, reusable code.
3. **Fluent API Configurations**: For setting up entity relationships, constraints, and data seeding.
4. **Identity and Role Management**: 
   - Admin-specific functionality for managing products.
   - Pre-configured **admin credentials** (added via Fluent API) for testing:
     - **Email**: `omar@gmail.com`
     - **Password**: `Test@gmail.com`
5. **Authentication and Authorization**: Utilized **Identity** with cookies for managing sessions securely.
6. **Product Update Logs**: Created a table for tracking changes to products, including the update date and userId (though not fully integrated into the project due to time constraints).
7. **Dynamic Product Visibility**: Products are displayed only during their active duration.
8. **Category Filtering**: Products can be filtered by their respective categories.
9. **Data Seeding**: Initila Data for Categories and Products are preloaded into the database and cannot be modified through the application interface.

### Incomplete Features:
- **Edit Mode**: Not fully implemented due to time constraints.
- **Show Details View**: Could not complete within the given deadline.
- **xUnit Tests**: The testing project has not been implemented yet. 

---

## **Technologies Used**
1. **Backend**: ASP.NET Core MVC (using .NET Core 6.0)
2. **Database**: MSSQL with **Entity Framework Core**
3. **Authentication**: Identity Framework with cookies.
4. **Automapper**: For object mapping between layers.
5. **Logging**: Error handling and logging mechanisms.
6. **Frontend**: Razor Views with Bootstrap for styling.
7. **Repository Pattern**: Generic repository for better abstraction.

---

## **How to Run the Project**
1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Update the connection string in `appsettings.json` to point to your SQL Server instance.
3. Run migrations to create the database schema and seed the data:
   ```bash
   dotnet ef database update
   ```
4. Start the application:
   ```bash
   dotnet run
   ```
5. Use the following **Admin credentials** to log in:
   - Email: `omar@gmail.com`
   - Password: `Test@gmail.com`

---

## **Known Limitations**
1. **Product Update Logs**: Although the table has been created to log updates, it hasn't been integrated into the application due to time constraints.
2. **Edit Mode and Details View**: These features were not completed due to the tight deadline and overlapping work commitments.
3. **xUnit Testing**: Unit tests have not been implemented.

---

## **Improvements**
If given more time, the following enhancements could be made:
1. Integrate the **Product Update Logs** feature fully to track all changes made to products.
2. Implement the **Edit Mode** and **Details View** functionality.
3. Add **unit tests** using xUnit for better code reliability.
4. Optimize error logging with a more robust solution (e.g., integrating Serilog or another logging framework).

---

## **Contact Information**  
- **Name**: Omar Ahmed Abo Ziada  
- **Email**: o.ahmed9847@gmail.com  
- **Phone**: +20 1159361955
- **Job Title**: Full-Stack .NET Developer at Initium Solutions  

