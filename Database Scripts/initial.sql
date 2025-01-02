-- SQL Script for Automobile Sales and Service Management System

-- Create Database
CREATE DATABASE AutomobileSalesServiceDB

-- Use Database
USE AutomobileSalesServiceDB

-- Roles Table
CREATE TABLE Roles (
    Role_ID INT PRIMARY KEY IDENTITY(1,1),
    Role_Name VARCHAR(225) NOT NULL UNIQUE
);

-- Department Table
CREATE TABLE Department (
    D_ID INT PRIMARY KEY IDENTITY(1,1),
    D_name VARCHAR(225) NOT NULL UNIQUE,
    D_location VARCHAR(225)
);

-- Employee Table
CREATE TABLE Employee (
    EID INT PRIMARY KEY IDENTITY(1,1),
    Email VARCHAR(225) NOT NULL UNIQUE,
    Mobile VARCHAR(15) NOT NULL UNIQUE,
    City VARCHAR(225),
    Address TEXT,
    Role_ID INT,
    Department_ID INT,
    FOREIGN KEY (Role_ID) REFERENCES Roles(Role_ID),
    FOREIGN KEY (Department_ID) REFERENCES Department(D_ID)
);

-- Vehicle Table
CREATE TABLE Vehicle (
    Vehicle_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_name VARCHAR(225),
    Vehicle_type VARCHAR(225),
    Chassis_no VARCHAR(225) UNIQUE,
    Engine_no VARCHAR(225) UNIQUE,
    Manufacture_date DATE
);

-- Owner Table
CREATE TABLE Owner (
    Owner_ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(225),
    Address TEXT,
    City VARCHAR(225),
    DOB DATE,
    Mobile VARCHAR(15) NOT NULL UNIQUE,
    Email VARCHAR(225) UNIQUE
);

-- Inventory Table
CREATE TABLE Inventory (
    Inventory_ID INT PRIMARY KEY IDENTITY(1,1),
    Inventory_item_name VARCHAR(225),
    Category VARCHAR(225),
    Per_price DECIMAL(10, 2),
    Qty INT
);

-- Customer Table
CREATE TABLE Customers (
    Cus_ID INT PRIMARY KEY IDENTITY(1,1),
    Customer_Name VARCHAR(225),
    Mobile VARCHAR(15) NOT NULL UNIQUE,
    Email VARCHAR(225) UNIQUE
);

-- Services Table
CREATE TABLE Services (
    Services_ID INT PRIMARY KEY IDENTITY(1,1),
    Services_type VARCHAR(225),
    Services_Date DATE,
    Service_Desc TEXT
);

-- Requests Table
CREATE TABLE Requests (
    Request_ID INT PRIMARY KEY IDENTITY(1,1),
    Request_type VARCHAR(225),
    Request_Qty INT,
    Request_Desc TEXT
);

-- Sales Table
CREATE TABLE Sales (
    Sales_ID INT PRIMARY KEY IDENTITY(1,1),
    Sales_type VARCHAR(225),
    Sales_Date DATE,
    Sales_value DECIMAL(10, 2)
);

-- Login Table
CREATE TABLE Login (
    Login_ID INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(225) UNIQUE,
    password VARCHAR(225),
    EID INT,
    FOREIGN KEY (EID) REFERENCES Employee(EID) ON DELETE CASCADE
);

-- Reports Table
CREATE TABLE Reports (
    Report_ID INT PRIMARY KEY IDENTITY(1,1),
    Report_Name VARCHAR(225),
    Report_type VARCHAR(225),
    Year INT,
    Report_Description TEXT
);

-- Payment Table
CREATE TABLE Payment (
    Pay_ID INT PRIMARY KEY IDENTITY(1,1),
    Paid_amount DECIMAL(10, 2),
    Payment_desc TEXT
);


-- Sales Budget Table
CREATE TABLE Sales_Budget (
    Year INT NOT NULL DEFAULT YEAR(GETDATE()) PRIMARY KEY,
    Budget_amount DECIMAL(10, 2) NOT NULL,
    Department_ID INT,
    FOREIGN KEY (Department_ID) REFERENCES Department(D_ID)
);

-- Budget Expenses Table
CREATE TABLE Budget_Expenses (
    Expense_ID INT PRIMARY KEY IDENTITY(1,1),
    Expense_Description TEXT,
    Expense_Amount DECIMAL(10, 2) NOT NULL,
    Expense_Date DATE,
    Budget_ID INT,
    FOREIGN KEY (Budget_ID) REFERENCES Sales_Budget(Year)
);

-- Relationships and Foreign Keys
-- Linking Vehicle with Owner
ALTER TABLE Vehicle ADD Owner_ID INT;
ALTER TABLE Vehicle ADD FOREIGN KEY (Owner_ID) REFERENCES Owner(Owner_ID);

-- Linking Inventory with Sales
ALTER TABLE Inventory ADD Sales_ID INT;
ALTER TABLE Inventory ADD FOREIGN KEY (Sales_ID) REFERENCES Sales(Sales_ID);

-- Linking Services with Requests
ALTER TABLE Services ADD Request_ID INT;
ALTER TABLE Services ADD FOREIGN KEY (Request_ID) REFERENCES Requests(Request_ID);

-- Linking Sales with Customers
ALTER TABLE Sales ADD Cus_ID INT;
ALTER TABLE Sales ADD FOREIGN KEY (Cus_ID) REFERENCES Customers(Cus_ID);

-- Linking Reports with Payments
ALTER TABLE Reports ADD Pay_ID INT;
ALTER TABLE Reports ADD FOREIGN KEY (Pay_ID) REFERENCES Payment(Pay_ID);



-- Add additional relations as per specific requirements.

