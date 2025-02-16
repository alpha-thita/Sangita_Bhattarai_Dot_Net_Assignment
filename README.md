# Sangita_Bhattarai_dotnet_assignment
What I Did
database Setup and Configuration:
Connected to SQL Server via SSMS and Visual Studio, managing the database using the Server Explorer.
Added the connection string to the appsettings.json file to link the project with the database.

Model Creation:
Created key models for the application: Product, Category, Customer, Order, OrderItem, and ApplicationUser (Identity model) to represent the main entities in the system.
Scaffolding and Controllers:
Used scaffolding to generate controllers for the models (Products, Customers, Orders, Reviews), implementing MVC architecture with Entity Framework.

Database Migration:
Ensured the database schema aligns with the models using Add-Migration and Update-Database commands.

Project Overview
The Online Furniture Store is an e-commerce web application developed using .NET Core, designed to provide a seamless shopping experience. It allows customers to browse furniture, place orders, leave reviews, and track deliveries, while providing administrators with tools to manage products, orders, and customers.

Features
Home Page:
Displays a list of products with images and descriptions, with quick access to login/signup.

User Authentication:
Secure login/signup for customers and admins with role-based access.

Product Management:
Customers can view product details, add items to their cart, and place orders.

Order Management:
Customers can track order status and delivery progress.

Admin Panel:
Admins can manage products, orders, customers, and generate reports.

Database Schema
Users:
Stores user credentials, roles (admin, customer), and personal info.

Products:
Contains product listings, including name, price, description, and images.

Orders:
Stores customer orders with product details, quantities, and status.

Reviews:
Stores customer reviews for products.
##sample image
![image](https://github.com/user-attachments/assets/4055cda9-fbf6-4b38-ae41-eeef3fc6ec20)
![image](https://github.com/user-attachments/assets/d298dc8c-8b21-47b9-abeb-61f934f02140)
![image](https://github.com/user-attachments/assets/e5fb3fbb-6a4c-4ebc-89f8-520402412b31)
![image](https://github.com/user-attachments/assets/80e3c754-8ae6-4b9d-ba38-baabba680e3d)


Technologies Used
Backend: .NET Core (ASP.NET Core)
Frontend: Razor Pages / MVC
Database: Microsoft SQL Server
Tools: Visual Studio, SSMS
Installation & Setup
Clone the repository.
Configure the database connection in appsettings.json.
Run migrations: dotnet ef database update.
Start the application using dotnet run.
