
--Create table Driver
CREATE TABLE DRIVER
(
	ID_Driver INT PRIMARY KEY,
	Name_Driver VARCHAR(50),
	Phone_Driver CHAR(20),
	Address_Driver NVARCHAR(50),
	Gender_Driver CHAR(10),
	Date_Of_Birth_Driver DATE,

);

--Create table User
CREATE TABLE USERS 
(
	ID_User INT PRIMARY KEY,
	Name_User VARCHAR(50),
	Phone_User CHAR(20),
	Address_User NVARCHAR(50),
	Email_User NVARCHAR(50),
	Gender_User CHAR(10),
	Date_Of_Birth DATE

);

--Create table Manager
CREATE TABLE MANAGER
(
	ID_Manager INT PRIMARY KEY,
	Name_Manager VARCHAR(50),
	Phone_Manager CHAR(20),
	Address_Manager NVARCHAR(50),
	Email_Manager NVARCHAR(50),
	Gender_Manager CHAR(10),
	Date_Of_Birth_Manager DATE

);

--Create table Guest
CREATE TABLE GUESTS
(
	ID_Guest INT PRIMARY KEY,
	Name_Guest VARCHAR(50),
	Phone_Guest CHAR(20),
	Address_Guest NVARCHAR(50),
	Email_Guest NVARCHAR(50),
	Gender_Guest CHAR(10),
	Date_Of_Birth_Guest DATE,
	ID_User INT FOREIGN KEY REFERENCES dbo.USERS (ID_User)
);

--Create table Account
CREATE TABLE ACCOUNT
(
	Username NVARCHAR(50),
	Pass_Account NVARCHAR(50),
	ID_User INT FOREIGN KEY REFERENCES dbo.USERS(ID_User),
	ID_Manager INT REFERENCES dbo.MANAGER(ID_Manager)
);

--Create table Trip
CREATE TABLE TRIP
(
	ID_Trip INT PRIMARY KEY,
	Source VARCHAR(50),
	Destination VARBINARY(50),
	Date_Trip DATE,
	Start_Time TIME,
	Arrival_Time TIME,
	Duration TIME,
	Total_Seat INT,
	Available_Seat INT,
	Price INT,
	Discount FLOAT,
	ID_Driver INT FOREIGN KEY REFERENCES dbo.DRIVER(ID_Driver)
);

--Create table Ticket
CREATE TABLE TICKET 
(
	ID_Ticket INT PRIMARY KEY,
	ID_User INT FOREIGN KEY REFERENCES dbo.USERS(ID_User),
	ID_Trip INT FOREIGN KEY REFERENCES dbo.TRIP(ID_Trip),
	Seat_Number INT
);

--Create table Bill
CREATE TABLE BILL
(
	ID_Bill INT PRIMARY KEY,
	ID_Ticket INT FOREIGN KEY REFERENCES dbo.TICKET(ID_Ticket),
	ID_User INT FOREIGN KEY REFERENCES dbo.USERS(ID_User),
	ID_Trip INT FOREIGN KEY REFERENCES dbo.TRIP(ID_Trip)
);
