# Database Schema for Order Management System

This document describes the database schema used in our Order Management System. The schema is visualized in the provided ER diagram.

![ER Diagram](path/to/your/image.png)

## Table Descriptions

### Suppliers
| Column Name  | Data Type  | Description                  |
|--------------|------------|------------------------------|
| SupplierID   | int        | Primary key                  |
| SupplierName | varchar(100)| Name of the supplier         |
| ContactName  | varchar(100)| Contact person's name        |
| Address      | varchar(255)| Supplier's address           |
| City         | varchar(100)| City where supplier is located|
| PostalCode   | varchar(20) | Postal code                  |
| Country      | varchar(100)| Country                      |

### Products
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| ProductID    | int         | Primary key                   |
| ProductName  | varchar(100)| Name of the product           |
| SupplierID   | int         | Foreign key referencing Suppliers table |
| CategoryID   | int         | Foreign key referencing Categories table|
| UnitPrice    | decimal     | Price per unit                |
| UnitsInStock | int         | Available stock units         |

### Categories
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| CategoryID   | int         | Primary key                   |
| CategoryName | varchar(100)| Name of the category          |
| Description  | varchar(255)| Description of the category   |

### Inventory
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| InventoryID  | int         | Primary key                   |
| WarehouseID  | int         | Foreign key referencing Warehouses table |
| ProductID    | int         | Foreign key referencing Products table  |
| Quantity     | int         | Quantity of the product in the warehouse |

### Warehouses
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| WarehouseID  | int         | Primary key                   |
| WarehouseName| varchar(100)| Name of the warehouse         |
| Location     | varchar(255)| Location of the warehouse     |

### Orders
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| OrderID      | int         | Primary key                   |
| CustomerID   | int         | Foreign key referencing Customers table |
| OrderDate    | date        | Date the order was placed     |
| ShipDate     | date        | Date the order was shipped    |
| EmployeeID   | int         | Foreign key referencing Employees table |

### OrderDetails
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| OrderDetailID| int         | Primary key                   |
| OrderID      | int         | Foreign key referencing Orders table |
| ProductID    | int         | Foreign key referencing Products table |
| Quantity     | int         | Quantity ordered              |
| UnitPrice    | decimal     | Unit price at the time of order|
| Discount     | int         | Discount on the product       |

### Customers
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| CustomerID   | int         | Primary key                   |
| CustomerName | varchar(100)| Name of the customer          |
| ContactName  | varchar(100)| Contact person's name         |
| Address      | varchar(255)| Customer's address            |
| City         | varchar(100)| City where customer is located|
| PostalCode   | varchar(20) | Postal code                   |
| Country      | varchar(100)| Country                       |

### Employees
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| EmployeeID   | int         | Primary key                   |
| FirstName    | varchar(100)| Employee's first name         |
| LastName     | varchar(100)| Employee's last name          |
| Title        | varchar(100)| Job title                     |
| HireDate     | date        | Date of hire                  |
| ReportsTo    | int         | Supervisor's employee ID      |

### Shipments
| Column Name  | Data Type   | Description                   |
|--------------|-------------|-------------------------------|
| ShipmentID   | int         | Primary key                   |
| OrderID      | int         | Foreign key referencing Orders table |
| ShippedDate  | date        | Date the shipment was made    |
| ShipperName  | varchar(100)| Name of the shipping company  |
| TrackingNumber | varchar(100)| Tracking number of the shipment |

## Relationships

- **Products** are supplied by **Suppliers**.
- **Products** belong to **Categories**.
- **Inventory** records the quantity of **Products** in **Warehouses**.
- **Orders** are placed by **Customers** and processed by **Employees**.
- **OrderDetails** contains information about **Products** ordered in **Orders**.
- **Shipments** track the shipment details of **Orders**.

This schema ensures a comprehensive tracking of orders, products, suppliers, customers, and shipments, providing a robust foundation for managing the order management system efficiently.
