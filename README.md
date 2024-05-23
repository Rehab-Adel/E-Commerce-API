# E-Commerce API

## Overview

The E-Commerce API is a robust backend service designed for managing products, carts, orders, and user authentication. Built with ASP.NET Core, it leverages Entity Framework Core for database operations and Identity for user authentication and authorization.

## Features

- User registration and login
- Role-based authorization (Admin, Customer)
- Product management
- Cart management
- Order management

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

**1. Clone the repository:**

   <pre>
   git clone https://github.com/Rehab-Adel/E-Commerce-API.git
   cd E-Commerce-API</pre>
   
**2. Set up the database:**

Update the `appsettings.json` file with your SQL Server connection string:
<pre>
{
"ConnectionStrings": {
"DefaultConnection": "Server=your_server_name;Database=E_Commerce;Trusted_Connection=True;TrustServerCertificate=True;"
},
"Logging": {
"LogLevel": {
"Default": "Information",
"Microsoft.AspNetCore": "Warning"
}
},
"AllowedHosts": "*"
}
</pre>

**3. Apply migrations and create the database:**

<pre>
add-migration InitialCreate
update-database
</pre>

**4. Run the project and Test APIs**

Sample Data for User Registration:
<pre>
  {
  "userName": "reha_3del",
  "email": "rehab@example.com",
  "password": "Password123!",
  "fullName": "Rehab Adel"
}</pre>


## API Endpoints


**Authentication**

• `POST /api/auth/register` - Register a new user

• `POST /api/auth/login` - Login a user



**Account Management**

• `POST /api/account/register` - Register a new user

• `POST /api/account/login` - Login a user

• `POST /api/account/create-role` - Create a new role




**Product Management**

• `GET /api/products` - Get all products

• `GET /api/products/{id}` - Get a product by ID

• `POST /api/products` - Create a new product

• `PUT /api/products/{id}` - Update a product

• `DELETE /api/products/{id}` - Delete a product




**Cart Management**

• `GET /api/carts/{userId}` - Get cart by user ID

• `POST /api/carts` - Create a new cart

• `PUT /api/carts/{id}` - Update a cart

• `DELETE /api/carts/{id}` - Delete a cart



**Order Management**

• `GET /api/orders/{userId}` - Get orders by user ID

• `GET /api/orders/{userId}/{id}` - Get an order by ID

• `POST /api/orders` - Create a new order

• `PUT /api/orders/{id}` - Update an order

• `DELETE /api/orders/{id}` - Delete an order

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any changes.

**Thank You ^^**
