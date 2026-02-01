# Hospital Management System - Setup Instructions

## Prerequisites
1. Visual Studio 2022 (or later) with VB.NET support
2. XAMPP (for MySQL database)
3. MySQL Connector/NET NuGet package

## Database Setup
1. Start XAMPP and ensure MySQL is running
2. Open phpMyAdmin (http://localhost/phpmyadmin)
3. Import the `database_setup.sql` file OR run the SQL commands manually
4. Database name: `hospital_db`
5. Default connection: Server=localhost, User=root, Password=(empty)

## NuGet Package Installation
1. Open the project in Visual Studio
2. Right-click on the project in Solution Explorer
3. Select "Manage NuGet Packages"
4. Search for "MySql.Data"
5. Install the latest stable version (8.x or higher)

## Running the Application
1. Build the solution (Ctrl+Shift+B)
2. Run the application (F5)
3. Login credentials:
   - Username: admin
   - Password: admin

## Project Structure
- **LoginForm**: User authentication
- **DashboardForm**: Main navigation hub
- **PatientForm**: Manage patient records (Add/Edit/Delete/View)
- **DoctorForm**: Manage doctor records (Add/Edit/Delete/View)
- **AppointmentForm**: Schedule and manage appointments
- **BillingForm**: Generate bills and track payment status
- **DatabaseHelper**: MySQL database connection utility

## Features
- Patient Management (CRUD operations)
- Doctor Management (CRUD operations)
- Appointment Scheduling
- Billing and Payment Tracking
- Simple Login System

## Notes
- All forms use drag-and-drop GUI design (Windows Forms Designer)
- Event-driven programming approach
- ADO.NET with MySQL connector for database operations
- DataGridView for displaying records

## Troubleshooting
- If database connection fails, check:
  1. XAMPP MySQL service is running
  2. Database `hospital_db` exists
  3. Connection string in DatabaseHelper.vb matches your setup
  4. MySql.Data NuGet package is installed

## Default Login
Username: admin
Password: admin
