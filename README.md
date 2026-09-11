# Supermarket POS & Inventory Management System

A desktop Point of Sale (POS) and inventory management application built with **C# .NET Windows Forms** and **SQL Server**. This system is designed to streamline supermarket checkout operations, track inventory levels, manage user access, and handle transactional reporting.

**[View Full Documentation & User Guide](Documentation.pdf)**
---

##  Key Features

###  Administrator Module
* **Role-Based Access Control:** Secure authentication supporting distinct Administrator and Cashier permissions.
* **Inventory & Product Management:** Full CRUD operations (Insert, Update, Delete) for Products, Brands, Categories, and Suppliers.
* **Stock & Re-order Controls:** Track stock-in logs and monitor re-order levels to prevent stockouts.
* **Data Portability:** Export and import product databases securely using XML files.
* **User Management:** Create and manage accounts for additional administrators or cashiers.

###  Cashier Module
* **Fast Checkout & Barcode Scanning:** Add items to the cart using product lookups or barcode scanning.
* **Dynamic Cart Operations:** Adjust quantities (with real-time stock validation), remove items, or clear the cart.
* **Discounts & Calculations:** Apply custom percentage discounts with automated row-level and total calculations, plus built-in VAT computations.
* **Payment Settlement:** Handle transaction completion, cash changes, and receipt tracking.
* **Transaction Voids & Daily Sales:** Review daily sales filtered by date and cashier, with a secure override system to cancel/void sales and automatically restore items back to inventory.

---

## Tech Stack

* **Language:** C#
* **Framework:** .NET Windows Forms (WinForms)
* **Database:** Microsoft SQL Server (LocalDB)
* **Data Access:** ADO.NET (`Microsoft.Data.SqlClient`) with Stored Procedures and SQL Triggers

---

## Database Architecture
The application relies on a relational database schema featuring:
* `tbProduct` (Product catalog and inventory quantities)
* `tbCart` (Active and completed transaction items, managed via SQL triggers for automatic total and discount calculations)
* `tbCategory` / `tbBrand` / `tbSupplier` (Classification and supply chain management)
* `tbStockin` (Inventory restocking logs)
* `tbCancel` (Audit trail for voided/cancelled transactions)
* `tbUser` (Authentication and role management)

---

## Getting Started

### Prerequisites
* Visual Studio (with the `.NET desktop development` workload installed)
* SQL Server LocalDB or SQL Server Express

### Installation & Setup
1. Clone the repository:
   ```bash
   git clone [https://github.com/AntonioP1H/ProiectSupermarket.git](https://github.com/AntonioP1H/ProiectSupermarket.git)

2. Open the solution file (ProiectSupermarket.sln) in Visual Studio.

3. Set up the Database: Attach the project's SQL Server database (DBPOSALE.MDF) to your local SQL Server instance.

4. Update Connection String: Open your database connection class (DBConnect.cs) and update the connection string path to match your local SQL Server instance.

5. Build and run the project (F5).