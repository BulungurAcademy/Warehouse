# Database Schema for Order Management System

This document describes the database schema used in our Order Management System. The schema is visualized in the provided ER diagram.

![image](https://github.com/user-attachments/assets/e5797888-326c-4da5-9b02-768d6daf02f4)

## Technologies - Libraries
- ✔️ **[`.NET 8`](https://dotnet.microsoft.com/download)** - .NET Framework and .NET Core, including ASP.NET and ASP.NET Cor
- ✔️ **[`Swagger & Swagger UI`](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)** - Swagger tools for documenting API's built on ASP.NET Core

## Relationships

- **Products** are supplied by **Suppliers**.
- **Products** belong to **Categories**.
- **Inventory** records the quantity of **Products** in **Warehouses**.
- **Orders** are placed by **Customers** and processed by **Employees**.
- **OrderDetails** contains information about **Products** ordered in **Orders**.
- **Shipments** track the shipment details of **Orders**.

This schema ensures a comprehensive tracking of orders, products, suppliers, customers, and shipments, providing a robust foundation for managing the order management system efficiently.
