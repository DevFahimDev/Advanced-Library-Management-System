-- 1. Create the Database
CREATE DATABASE LibraryDB;
GO

USE LibraryDB;
GO

-- 2. Build Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    PasswordHash NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);
GO

-- 3. Build Books Table
CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(200) NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    TotalCopies INT NOT NULL DEFAULT 1,
    AvailableCopies INT NOT NULL DEFAULT 1,
    DateAdded DATETIME NULL DEFAULT GETDATE()
);
GO

-- 4. Build Wishlist Table
CREATE TABLE Wishlist (
    WishlistID INT IDENTITY(1,1) PRIMARY KEY,
    StudentName NVARCHAR(100) NOT NULL,
    BookID INT NOT NULL
);
GO

-- 5. Insert Master Dummy Data (So you can immediately log in!)
INSERT INTO Users (FullName, PasswordHash, Role) VALUES ('Admin', '1234', 'Management');
INSERT INTO Users (FullName, PasswordHash, Role) VALUES ('Student1', '1234', 'Student');

INSERT INTO Books (Title, Author, Category, TotalCopies, AvailableCopies) 
VALUES ('Clean Code', 'Robert C. Martin', 'Programming', 5, 5);
INSERT INTO Books (Title, Author, Category, TotalCopies, AvailableCopies) 
VALUES ('The Pragmatic Programmer', 'Andy Hunt', 'Programming', 3, 3);
GO