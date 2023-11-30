Create Database MotorcycleManagement

create table Users (

userID varchar(10) Primary key not null,
fullName varchar(50),
password varchar(50),
status bit,
);

INSERT INTO Users(userID,fullName,password,status) VALUES ('E001','Dao Phung Hung Thinh','123456789',1);

INSERT INTO Users(userID,fullName,password,status) VALUES ('E002','Hung Loi','123456789',1);
INSERT INTO Users(userID,fullName,password,status) VALUES ('E003','Toan Thang','123456789',0);



create table tblBrand (
brandID nvarchar(10) PRIMARY KEY not null,
brandName nvarchar(50),
country nvarchar(50),
decription nvarchar(200),
);


create table tblBike (
motocycleID nchar(10) primary key not null,
model nvarchar(50),
year date,
condition varchar(50),
price float,
quantity integer,
warranty nvarchar(50),
brandID nvarchar(10) FOREIGN KEY REFERENCES tblBrand(brandID),
);


INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('1','Yamaha','Japan','Good,Enduring');

INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('2','Ducati','Italy','Good,Enduring');
INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('3','BMW','German','Good,Enduring');
INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('4','Kawasaki','Japan','Good,Enduring');
INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('5','Suzuki','Japan','Good,Enduring');
INSERT INTO tblBrand(brandID,brandName,country,decription) VALUES('6','Honda','Japan','Good,Enduring');


INSERT INTO tblBike(motocycleID,model,year,condition,price,quantity,warranty,brandID) VALUES('1','Standards','2012-08-24','dry',50000000,50,'2 nam','1');
INSERT INTO tblBike(motocycleID,model,year,condition,price,quantity,warranty,brandID) VALUES('5','Standards','2012-08-24','dry',50000000,50,'2 nam','1');
INSERT INTO tblBike(motocycleID,model,year,condition,price,quantity,warranty,brandID) VALUES('2','Cruisers','2012-08-24','dry',100000000,100,'2 nam','2');
INSERT INTO tblBike(motocycleID,model,year,condition,price,quantity,warranty,brandID) VALUES('3','Touring','2012-08-24','dry',75000000,50,'2 nam','3');
INSERT INTO tblBike(motocycleID,model,year,condition,price,quantity,warranty,brandID) VALUES('4','Sport ','2012-08-24','dry',55000000,50,'2 nam','4');

