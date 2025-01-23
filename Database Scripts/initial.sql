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
	EName VARCHAR(100) NOT NULL,
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
    Price DECIMAL(10, 2),
    vehicle_color VARCHAR(225),
    vehicle_model VARCHAR(225),
    vehicle_image Varbinary(MAX),
    Manufacture_date DATE,
	Status VARCHAR (20),Owner_ID INT,Number_Plate VARCHAR (10)

);
INSERT INTO Vehicle (Vehicle_name, Vehicle_type, Chassis_no, Engine_no, Price, vehicle_color, vehicle_model, vehicle_image, Manufacture_date,Status)
VALUES 
('Toyota dw', 'dwd', '1HGBH4dw1JdX09dw186', '2T1BR32dwEdre54Cdw123456', 24000.00, 'Blwdue', '2021', 
    (SELECT * FROM OPENROWSET(BULK 'C:\Users\dhaks\Downloads\Airline Ticket Invoice Template.jpg', SINGLE_BLOB) AS Image), 
    '2021-05-15','SOLD');


-- Service Booking Table
CREATE TABLE Service_Booking (
    Booking_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_ID INT,
    Booking_Date DATE,
    Inspection BIT,
	Maintain BIT,
	Setup BIT,
	Repair BIT,
	wash BIT,
    Status VARCHAR(20),
    FOREIGN KEY (Vehicle_ID) REFERENCES Vehicle(Vehicle_ID)
);

CREATE TABLE Vehicle_Inspection (
    Inspection_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_ID INT,
    Inspection_Date DATE,
    Inspector_DESC VARCHAR(225),
    Status VARCHAR(20),
    FOREIGN KEY (Vehicle_ID) REFERENCES Vehicle(Vehicle_ID)
);

CREATE TABLE Maintain (
    Maintain_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_ID INT,
    Maintain_Date DATE,
    Description VARCHAR(255),
	Status VARCHAR(20),
    FOREIGN KEY (Vehicle_ID) REFERENCES Vehicle(Vehicle_ID)
);


-- Setup Table
CREATE TABLE Setup (
    Setup_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_ID INT,
    Setup_Date DATE,
    Setup_Details VARCHAR(255),
    FOREIGN KEY (Vehicle_ID) REFERENCES Vehicle(Vehicle_ID)
);

-- Repair Table
CREATE TABLE Repair (
    Repair_ID INT PRIMARY KEY IDENTITY(1,1),
    Vehicle_ID INT,
    Repair_Date DATE,
    Repair_Description VARCHAR(255),
    Cost DECIMAL(10, 2),
    FOREIGN KEY (Vehicle_ID) REFERENCES Vehicle(Vehicle_ID)
);

-- Service Progress Table
CREATE TABLE Service_Progress (
    Progress_ID INT PRIMARY KEY IDENTITY(1,1),
    Booking_ID INT,
    Progress_Date DATE,
    Progress_Description VARCHAR(255),
    FOREIGN KEY (Booking_ID) REFERENCES Service_Booking(Booking_ID)
);

-- Owner Table
CREATE TABLE VehicleOwner (
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

CREATE TABLE SalesTargets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ActualSales DECIMAL(18, 2),
    SalesTarget DECIMAL(18, 2),
    TargetPercentage DECIMAL(5, 2),
	SMonth DATE,
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

CREATE TABLE NetProfit (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Revenue DECIMAL(18, 2),
    Expenses DECIMAL(18, 2),
    NetProfit DECIMAL(18, 2),
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE SalesData (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Month VARCHAR(50),
    SalesAmount DECIMAL(18, 2),
    ServiceAmount DECIMAL(18, 2),
    TotalAmount AS (SalesAmount + ServiceAmount)
);


-- Example Insert Query
INSERT INTO NetProfit (Revenue, Expenses, NetProfit) 
VALUES (35534.00, 3444.00, 3000.00);


-- Relationships and Foreign Keys
-- Linking Vehicle with Owner
ALTER TABLE Vehicle ADD Owner_ID INT;
ALTER TABLE Vehicle ADD FOREIGN KEY (Owner_ID) REFERENCES VehicleOwner(Owner_ID);


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

