--Drop Database
USE master
IF EXISTS(select * from sys.databases where name='TicketSelling')
DROP DATABASE TicketSelling
Go
--Create Database
CREATE DATABASE TicketSelling;
Go
--Using Database
USE TicketSelling

--Create table User
CREATE TABLE USERS 
(
	ID INT IDENTITY(1,1) NOT NULL,
	ID_User AS 'UID' + RIGHT('00000000' + CAST(ID AS VARCHAR(8)),8) PERSISTED PRIMARY KEY,
	First_Name VARCHAR(50) NOT NULL,
	Last_Name VARCHAR(50) NOT NULL,
	Phone CHAR(20) NOT NULL,
	Address_User NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Gender_User CHAR(10) NOT NULL,
	Date_Of_Birth DATE  NOT NULL,
	Role_User VARCHAR(15)
);


--Create table Account
CREATE TABLE ACCOUNT
(
	Username NVARCHAR(50) PRIMARY KEY,
	Pass_Account NVARCHAR(50) NOT NULL,
	ID_User VARCHAR(11) FOREIGN KEY REFERENCES USERS (ID_User)
	
);

--Create table Trip
CREATE TABLE TRIP
(
	ID INT IDENTITY(1,1) NOT NULL,
	ID_Trip AS 'TID' + RIGHT('00000000' + CAST(ID AS VARCHAR(8)),8) PERSISTED PRIMARY KEY,
	Source VARCHAR(50) NOT NULL,
	Destination VARCHAR(50) NOT NULL,
	Date_Trip DATE NOT NULL,
	Start_Time TIME NOT NULL,
	Arrival_Time TIME NOT NULL,
	Duration TIME NOT NULL,
	Total_Seat INT NOT NULL,
	Available_Seat INT NOT NULL,
	Price INT NOT NULL,
	Discount FLOAT NOT NULL,
	ID_Driver VARCHAR(11) FOREIGN KEY REFERENCES USERS(ID_User),
	ID_Manager VARCHAR(11) FOREIGN KEY REFERENCES USERS(ID_User) 
);

--Create table Ticket
CREATE TABLE TICKET 
(
	ID INT IDENTITY(1,1) NOT NULL,
	ID_Ticket AS 'TKID' + RIGHT('00000000' + CAST(ID AS VARCHAR(8)),8) PERSISTED PRIMARY KEY,
	Seat_Number INT NOT NULL,
	Total_Price FLOAT,
	ID_User VARCHAR(11) FOREIGN KEY REFERENCES USERS (ID_User),
	ID_Trip VARCHAR(11) FOREIGN KEY REFERENCES TRIP (ID_Trip) 
);

--Create table Payment
CREATE TABLE PAYMENT
(
	ID INT IDENTITY(1,1) NOT NULL,
	ID_Bill AS 'PID' + RIGHT('00000000' + CAST(ID AS VARCHAR(8)),8) PERSISTED PRIMARY KEY,
	Name VARCHAR(50),
	Bank VARCHAR(50),
	Card_Number INT,
	Card_Type VARCHAR(50),
	Date_Pay DATE,
	ID_Ticket VARCHAR(12) FOREIGN KEY REFERENCES dbo.TICKET (ID_Ticket)

);

-- Insert value of User into database (20 users)

INSERT INTO USERS VALUES ('Nguyen','Mike','171184856',N'Manchester', N'mikenguyen@gmail.com','Male','19960101','User')
INSERT INTO USERS VALUES ('Rio','Ferdinand','151134846',N'Manchester', N'rioferdinand@gmail.com','Male','19970501','User')
INSERT INTO USERS VALUES ('Nguyen','Alex','111584858',N'Manchester', N'alexnguyen@gmail.com','Male','19861226','Manager')
INSERT INTO USERS VALUES ('Nemanja','Vidic','171144857',N'Manchester', N'nemanjavidic@gmail.com','Male','19900301','User')
INSERT INTO USERS VALUES ('Matteo','Darmian','121144866',N'Manchester', N'matteodarmian@gmail.com','Male','19960428','User')
INSERT INTO USERS VALUES ('Wayne','Rooney','176182859',N'Manchester', N'waynerooney@gmail.com','Male','19760601','User')
INSERT INTO USERS VALUES ('Mohamed','Salah','141194846',N'Liverpool', N'mohamedsalah@gmail.com','Male','19901101','Driver')
INSERT INTO USERS VALUES ('Hoang','Jessica','111984556',N'London', N'jessicahoang@gmail.com','Female','19980101','Manager')
INSERT INTO USERS VALUES ('Nguyen','Linda','171144830',N'Bristol', N'lindanguyen@gmail.com','Female','19860101','User')
INSERT INTO USERS VALUES ('Victor','Valdes','171144650',N'Liverpool', N'victorvaldes@gmail.com','Male','19800501','Driver')
INSERT INTO USERS VALUES ('Adam','Lalana','170184056',N'Southamton', N'adamlalana@gmail.com','Male','19761001','User')
INSERT INTO USERS VALUES ('Steven','Gerrard','171084956',N'Liverpool', N'stevengerrard@gmail.com','Male','19800530','User')
INSERT INTO USERS VALUES ('Daniel','James','171104846',N'Brimingham', N'danieljames@gmail.com','Male','19971201','Driver')
INSERT INTO USERS VALUES ('Juan','Mata','171384836',N'Norwich', N'juanmata@gmail.com','Male','19790201','User')
INSERT INTO USERS VALUES ('Nguyen','Mario','121164856',N'London', N'marionguyen@gmail.com','Male','20000428','User')
INSERT INTO USERS VALUES ('Ander','Herrera','171480806',N'Norwich', N'anderherrera@gmail.com','Male','19961010','Driver')
INSERT INTO USERS VALUES ('Nguyen','Isabella','171174851',N'Bristol', N'isabellanguyen@gmail.com','Female','19901201','Manager')
INSERT INTO USERS VALUES ('Tran','Sophia','101104856',N'Leeds', N'sophiatran@gmail.com','Female','20011005','User')
INSERT INTO USERS VALUES ('Victor','Anna','161084857',N'York', N'annavictor@gmail.com','Female','20020501','User')
INSERT INTO USERS VALUES ('Micheal','Dean','171818676',N'Manchester', N'michealdean@gmail.com','Male','19971228','User')


-- Insert value of Account into database (20 accounts)

INSERT INTO ACCOUNT VALUES (N'user001', N'user0101','UID00000001')
INSERT INTO ACCOUNT VALUES (N'user002', N'user0202','UID00000002')
INSERT INTO ACCOUNT VALUES (N'user003', N'user0303','UID00000003')
INSERT INTO ACCOUNT VALUES (N'user004', N'user0404','UID00000004')
INSERT INTO ACCOUNT VALUES (N'user005', N'user0505','UID00000005')
INSERT INTO ACCOUNT VALUES (N'user006', N'user0606','UID00000006')
INSERT INTO ACCOUNT VALUES (N'user007', N'user0707','UID00000007')
INSERT INTO ACCOUNT VALUES (N'user008', N'user0808','UID00000008')
INSERT INTO ACCOUNT VALUES (N'user009', N'user0909','UID00000009')
INSERT INTO ACCOUNT VALUES (N'user010', N'user1010','UID00000010')
INSERT INTO ACCOUNT VALUES (N'user011', N'user1111','UID00000011')
INSERT INTO ACCOUNT VALUES (N'user012', N'user1212','UID00000012')
INSERT INTO ACCOUNT VALUES (N'user013', N'user1313','UID00000013')
INSERT INTO ACCOUNT VALUES (N'user014', N'user1414','UID00000014')
INSERT INTO ACCOUNT VALUES (N'user015', N'user1515','UID00000015')
INSERT INTO ACCOUNT VALUES (N'user016', N'user1616','UID00000016')
INSERT INTO ACCOUNT VALUES (N'user017', N'user1717','UID00000017')
INSERT INTO ACCOUNT VALUES (N'user018', N'user1818','UID00000018')
INSERT INTO ACCOUNT VALUES (N'user019', N'user1919','UID00000019')
INSERT INTO ACCOUNT VALUES (N'user020', N'user2020','UID00000020')


-- Insert value of Trip into database (20 trips)

INSERT INTO TRIP VALUES ('Manchester','Liverpool','20200516','8:00','20:00','12:00',50,50,10,0.0,'UID00000007','UID00000003') 
INSERT INTO TRIP VALUES ('Manchester','London','20200516','8:00','18:00','10:00',50,50,9,0.0,'UID00000010','UID00000003')
INSERT INTO TRIP VALUES ('Bristol','Southamton','20200516','10:00','18:00','8:00',50,50,8,0.0,'UID00000013','UID00000008')
INSERT INTO TRIP VALUES ('Norwich','Leeds','20200516','10:00','22:00','12:00',50,50,10,0.0,'UID00000016','UID00000008')

INSERT INTO TRIP VALUES ('Liverpool','Manchester','20200517','8:00','20:00','12:00',50,50,10,0.0,'UID00000007','UID00000008')
INSERT INTO TRIP VALUES ('London','Manchester','20200517','8:00','18:00','10:00',50,50,9,0.0,'UID00000010','UID00000003')
INSERT INTO TRIP VALUES ('Southamton','Bristol','20200517','10:00','18:00','8:00',50,50,8,0.0,'UID00000013','UID00000008')
INSERT INTO TRIP VALUES ('Leeds','Norwich','20200517','10:00','22:00','12:00',50,50,10,0.0,'UID00000016','UID00000017')

INSERT INTO TRIP VALUES ('Manchester','Brimingham','20200518','7:00','13:30','6:30',50,50,8,0.0,'UID00000007','UID00000017')
INSERT INTO TRIP VALUES ('Manchester','Bristol','20200518','8:00','22:00','14:00',50,50,15,0.0,'UID00000010','UID00000017')
INSERT INTO TRIP VALUES ('Bristol','York','20200518','12:00','22:00','10:00',50,50,9,0.0,'UID00000013','UID00000003')
INSERT INTO TRIP VALUES ('York','Manchester','20200519','8:00','20:00','12:00',50,50,10,0.0,'UID00000016','UID00000008')

INSERT INTO TRIP VALUES ('Brimingham','Manchester','20200519','7:00','13:30','4:30',50,50,6,0.0,'UID00000007','UID00000017')
INSERT INTO TRIP VALUES ('Bristol','Manchester','20200519','8:00','22:00','14:00',50,50,15,0.0,'UID00000010','UID00000003')
INSERT INTO TRIP VALUES ('York','Bristol','20200519','12:00','22:00','10:00',50,50,9,0.0,'UID00000013','UID00000008')
INSERT INTO TRIP VALUES ('Manchester','York','20200519','8:00','20:00','12:00',50,50,10,0.0,'UID00000016','UID00000003')

INSERT INTO TRIP VALUES ('Manchester','Norwich','20200520','10:00','20:00','10:00',50,50,9,0.0,'UID00000007','UID00000003')
INSERT INTO TRIP VALUES ('Bristol','Liverpool','20200520','10:00','22:00','12:00',50,50,10,0.0,'UID00000013','UID00000008')
INSERT INTO TRIP VALUES ('York','Brimingham','20200520','8:00','12:30','4:30',50,50,6,0.0,'UID00000016','UID00000017')
INSERT INTO TRIP VALUES ('Brimingham','York','20200522','8:00','20:30','12:30',50,50,12,0.0,'UID00000016','UID00000017')
INSERT INTO TRIP VALUES ('Manchester','Liverpool','20200516','10:00','22:00','12:00',50,50,10,0.0,'UID00000016','UID00000003') 


-- Insert value of Ticket into database (10 tickets)

INSERT INTO TICKET VALUES (35,10,'UID00000001','TID00000001')
INSERT INTO TICKET VALUES (28,10,'UID00000001','TID00000001')
INSERT INTO TICKET VALUES (01,10,'UID00000002','TID00000005')
INSERT INTO TICKET VALUES (02,10,'UID00000004','TID00000001')
INSERT INTO TICKET VALUES (15,9,'UID00000005','TID00000002')
INSERT INTO TICKET VALUES (40,9,'UID00000011','TID00000011')
INSERT INTO TICKET VALUES (50,12,'UID00000001','TID00000020')
INSERT INTO TICKET VALUES (30,8,'UID00000002','TID00000009')
INSERT INTO TICKET VALUES (04,6,'UID00000009','TID00000019')
INSERT INTO TICKET VALUES (19,12,'UID00000020','TID00000020')

-- Inset value of Payment into database (10 payments)

INSERT INTO PAYMENT VALUES ('Mike Nguyen','Manchester Bank',123456789,'Debit Card','20200510','TKID00000001')
INSERT INTO PAYMENT VALUES ('Mike Nguyen','Manchester Bank',123456789,'Debit Card','20200510','TKID00000002')
INSERT INTO PAYMENT VALUES ('Rio Ferdinand','Manchester Bank',103056389,'Credit Card','20200510','TKID00000003')
INSERT INTO PAYMENT VALUES ('Nemanja Vidic','Manchester Bank',323466789,'Debit Card','20200511','TKID00000004')
INSERT INTO PAYMENT VALUES ('Matteo Darmian','Manchester Bank',163453789,'Credit Card','20200511','TKID00000005')
INSERT INTO PAYMENT VALUES ('Adam Lalana','Southamton Bank',623056089,'Debit Card','20200511','TKID00000006')
INSERT INTO PAYMENT VALUES ('Mike Nguyen','Manchester Bank',123756989,'Debit Card','20200511','TKID00000007')
INSERT INTO PAYMENT VALUES ('Rio Ferdinand','Manchester Bank',103056389,'Credit Card','20200512','TKID00000008')
INSERT INTO PAYMENT VALUES ('Linda Nguyen','Bristol Bank',183466780,'Credit Card','20200512','TKID00000009')
INSERT INTO PAYMENT VALUES ('Micheal Dean','Manchester Bank',120456119,'Debit Card','20200512','TKID00000010')

Go
--Create procedure
CREATE PROC USP_Login
@userName NVARCHAR (100), @passWord NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.ACCOUNT WHERE Username = @userName COLLATE SQL_Latin1_General_CP1_CS_AS AND Pass_Account = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS
END

GO
				 
CREATE PROC USP_showName
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Last_Name, U.First_Name FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

GO                                 
                                 
CREATE PROC USP_getName
@idUser NVARCHAR (100)
AS
BEGIN
	SELECT First_Name, Last_Name FROM dbo.USERS WHERE ID_User = @idUser
END

GO 
                                 
CREATE PROC USP_getRole
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.Role_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

GO 
                                 
CREATE PROC USP_getID
@userName NVARCHAR (100)
AS
BEGIN

	SELECT U.ID_User FROM dbo.USERS AS U, dbo.ACCOUNT AS A WHERE A.Username = @userName AND A.ID_User = U.ID_User;
END

GO 
                           
CREATE PROC USP_loadTrip
@source NVARCHAR(100), @destination NVARCHAR (100), @date DATE
AS
BEGIN
	SELECT* FROM trip WHERE Source = @source AND Destination = @destination AND Date_Trip = @date
END

GO 
                           
CREATE PROC USP_getSeat
@idTrip NVARCHAR (100)
AS
BEGIN

	SELECT Total_Seat FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

GO 
                           
CREATE PROC USP_getListSeat
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT TK.Seat_Number
	FROM dbo.TRIP AS T, dbo.TICKET AS TK
	WHERE T.ID_Trip = TK.ID_Trip 
	AND TK.ID_Trip = @idTrip

END

GO 
                           
CREATE PROC USP_loadTripUser
@idTrip NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TRIP WHERE ID_Trip = @idTrip
END

GO 
                           
CREATE PROC USP_InsertTicket
@seatNumber INT, @totalPrice FLOAT, @idUser NVARCHAR(100), @idTrip NVARCHAR(100)
AS
BEGIN
INSERT dbo.TICKET
        ( Seat_Number ,
          Total_Price ,
          ID_User ,
          ID_Trip
        )
VALUES  ( @seatNumber , -- Seat_Number - int
          @totalPrice , -- Total_Price - bigint
          @idUser , -- ID_User - varchar(11)
          @idTrip  -- ID_Trip - varchar(11)
        )
END

GO 
                           
CREATE PROC USP_InsertPayment
@Name NVARCHAR (100), @Bank NVARCHAR (100), @CardNum INT,
@CardType NVARCHAR (100), @idTicket NVARCHAR (100)
AS
BEGIN
INSERT dbo.PAYMENT
        ( Name ,
          Bank ,
          Card_Number ,
          Card_Type ,
          Date_Pay ,
          ID_Ticket
        )
VALUES  ( @Name , -- Name - varchar(50)
          @Bank , -- Bank - varchar(50)
          @CardNum , -- Card_Number - int
          @CardType , -- Card_Type - varchar(50)
          GETDATE() , -- Date_Pay - date
          @idTicket  -- ID_Ticket - varchar(12)
        )
END

GO 
                           
CREATE PROC USP_maxIdTicket
AS
BEGIN
DECLARE @maxID INT
SET @maxID = (SELECT max (id) FROM dbo.TICKET)
SELECT ID_Ticket FROM dbo.TICKET WHERE id = @maxID
END

GO 
                           
CREATE PROC USP_updateSeat
@idTrip NVARCHAR (100)
AS
BEGIN
	UPDATE dbo.TRIP SET Available_Seat = (Available_Seat - 1) WHERE ID_Trip = @idTrip
END

GO 
                           
CREATE PROC USP_LoadTicket
@idTicket NVARCHAR (100)
AS
BEGIN
	SELECT* FROM dbo.TICKET WHERE ID_Ticket = @idTicket COLLATE SQL_Latin1_General_CP1_CS_AS
END
---------------------------------------
