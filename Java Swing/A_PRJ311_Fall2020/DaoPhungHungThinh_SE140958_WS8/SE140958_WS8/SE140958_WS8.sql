CREATE DATABASE SE140958_WS8
USE SE140958_WS8

GO
CREATE TABLE Suppliers
(
	SupCode char(20) PRIMARY KEY,
	SupName char (20),
	Addres	char(20),
	Colloborating bit,
	
);
go
CREATE TABLE Items
(
	ItemCode char(20) PRIMARY KEY,
	ItemName char(20),
	Unit  char(20),
	Price int,
	Supplying bit,
	supCode char(20) FOREIGN KEY REFERENCES Suppliers(SupCode)	
);

GO
INSERT INTO dbo.Suppliers
Values ('TA','THIEN AN CO.','123,LE LOI,Q1',1);
INSERT INTO dbo.Suppliers
Values ('HT','HOANG TUAN CO.','452,TRAN HUNG DAO,Q5',1);
INSERT INTO dbo.Suppliers
Values ('MT','MINH TRANG CO.','37,HAI BA TRUNG,Q1',1);

GO
UPDATE Suppliers set Suppliers.Colloborating='true' where Suppliers.SupCode='TA'


GO
INSERT INTO DBO.Items
VALUES ('E0001', 'Mouse Proview','Block 10',30,1,'MT');
INSERT INTO DBO.Items
VALUES ('E0002', 'Keyboard Proview','Block 10',40,1,'MT');
INSERT INTO DBO.Items
VALUES ('E0003', 'LCD','1-Unit',90,1,'MT');
INSERT INTO DBO.Items
VALUES ('E0004', 'Main Asus MK1234','1-Unit',78,1,'HT');
INSERT INTO DBO.Items
VALUES ('E0005', 'Main Gigabyte GM34A','1-Unit',67,0,'HT');
INSERT INTO DBO.Items
VALUES ('E0006', 'Laptop Compag 6250','1-Unit',620,1,'HT');
INSERT INTO DBO.Items
VALUES ('E0007', 'Blank DVD Giga','Block 100',43,1,'HT');
INSERT INTO DBO.Items
VALUES ('E0008', 'Blank CD BW','Block 100',15,1,'TA');
INSERT INTO DBO.Items
VALUES ('E0009', 'USB 2.0 Kingston-4GB','Unit-1',10,0,'TA');

