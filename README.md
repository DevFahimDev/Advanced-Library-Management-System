# Advanced Library Management System 📚

A robust, enterprise-grade desktop application built with C# Windows Forms and Microsoft SQL Server. This project demonstrates strict adherence to Object-Oriented Programming (OOP) principles and implements a clean **3-Tier Architecture** to separate user interface, business logic, and database operations.

## 🚀 Key Features

* **Role-Based Access Control (RBAC):** Secure authentication system routing users to distinct Management or Student dashboards based on their database-assigned roles.
* **Real-Time Inventory Management:** Administrators can dynamically add or remove books, with changes instantly synchronized across all active data grids.
* **Smart Wishlist System:** Students can browse the global catalog and maintain a personal wishlist. The system enforces logical constraints, preventing duplicate entries and capping wishlists at a maximum of 3 books per student.
* **Complex Data Retrieval:** Utilizes parameterized SQL `INNER JOIN` queries to cross-reference the Book inventory with user-specific Wishlist records.
* **Modern UI/UX:** Features a dark-themed interface with buttery-smooth animated transitions and double-buffered data grids to eliminate scrolling lag.

## 💻 Tech Stack

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **UI Components:** Guna UI Framework
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (Parameterized Queries for SQL Injection prevention)
* **Architecture:** 3-Tier Architecture (UI, BLL, DAL)

## 🏗️ Architecture Overview

This application is strictly divided into three layers to ensure maintainability and scalability:
1. **Presentation Layer (UI):** The visual Windows Forms. It contains absolutely zero direct database code.
2. **Business Logic Layer (BLL):** The "brain" of the application. It enforces rules (e.g., "A student cannot add a 4th book") before passing data down.
3. **Data Access Layer (DAL):** The only layer allowed to communicate with SQL Server. It handles all `SqlConnection` and `SqlCommand` executions.

## 📸 Screenshots

*(Upload your screenshots to your GitHub repository and replace these placeholder links!)*

| Login Portal | Management Dashboard |
| :---: | :---: |
| ![Login Screen](Insert_Link_To_Your_Login_Image_Here) | ![Management](Insert_Link_To_Your_Management_Image_Here) |

| Student Dashboard | System ER Diagram |
| :---: | :---: |
| ![Student](Insert_Link_To_Your_Student_Image_Here) | ![ER Diagram](Insert_Link_To_Your_ER_Diagram_Image_Here) |

## ⚙️ How to Run Locally

### Prerequisites
* Visual Studio (2019 or newer)
* Microsoft SQL Server Management Studio (SSMS)

### Setup Instructions
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/YourUsername/Advanced-Library-Management-System.git](https://github.com/YourUsername/Advanced-Library-Management-System.git)

2.Build the Database:

-Open SQL Server Management Studio (SSMS).

-Drag and drop the LibrarySetup.sql file into a new query window.

-Click Execute. This will instantly generate the database, tables, and insert master dummy data.

3.Run the Application:

-Open the .sln file in Visual Studio.

-Press F5 to Start.

4.Test Credentials:

-Management: Admin / 1234

-Student: Student1 / 1234