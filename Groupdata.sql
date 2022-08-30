
create database GroupAssignment;
use GroupAssignment;

drop database GroupAssignment;

create table Userdetail (
UserIC varchar (20) not null UNIQUE,
Name varchar (50) not null,
Email varchar (150) not null,
password int not null,
age int not null,
gender varchar (50) not null,
phonenumber varchar (20) null,
usertype varchar(20) NOT NULL
);

drop table Userdetail;

insert into Userdetail(UserIC, Name, Email, password, age, gender, phonenumber, usertype) values
('020629-10-0227', 'Azure', 'nitress86@gmail.com', '8688', '20', 'Male', '0108236388', 'Receptionist'),
('020629-10-0111', 'DataTest1', 'datatest1@gmail.com', '1234', '50', 'Female', '0123456789', 'Technician'),
('020629-10-0222', 'DataTest2', 'datatest2@gmail.com', '4321', '51', 'Male', '9876543210', 'Customer'),
('020629-10-0333', 'Admin', 'datatest3@gmail.com', '1111', '40', 'Male', '1231231231', 'Admin');


create table Receptionist (
receptionistid int NOT NULL Identity(1, 1),
UserIC varchar (20) not null UNIQUE,
name varchar (100) not null,
email varchar (150) not null  ,
Password int not null  ,
age int not null,
gender varchar(50) not null,
phonenumber varchar(20) null,
);

drop table Receptionist;

insert into Receptionist (UserIC, name, email, password, age, gender, phonenumber) values
('020629100227', 'Azure', 'nitress86@gmail.com', '8688', '20', 'Male', '0108236388')

create table Technician (
technicianID int not null Identity(1, 1),
UserIC varchar (20) not null UNIQUE,
name varchar (100) not null,
email varchar (150) not null,
Password int not null,
age int not null,
gender varchar(50) not null,
phonenumber varchar(20) null,
);

drop table Technician;

insert into Technician (UserIC, name, email, Password, age, gender, phonenumber) values
('012345678910', 'DataTest1', 'datatest1@gmail.com', '1234', '50', 'Female', '0123456789')

create table Customer (
CustomerID int NOT NULL Identity(1, 1),
receiptid varchar (20) not null,
UserIC varchar (20) not null UNIQUE,
name varchar (100) not null,
email varchar (150) not null  ,
password int not null  ,
age int not null,
gender varchar (50) not null, 
phonenumber varchar(20) null
);

create table Customer (
UserIC varchar (20) not null,
name varchar (100) not null,
email varchar (150) not null,
password varchar (150),
age int not null,
gender varchar (50) not null, 
phonenumber varchar(20) null)

drop table Customer;

insert into Customer (UserIC, name, email, password, age, gender, phonenumber) values
('987654321098', 'DataTest2', 'datatest2@gmail.com', '4321', '51', 'Male', '9876543210')

create table Receipt (
receiptid int NOT NULL Identity(1, 1),
Orderdate date not null,
CustomerID nvarchar(100) NOT NULL UNIQUE,
pricetotal varchar(20) NOT NULL,
serviceclass varchar(50) not null
);

drop table Receipt;

insert into Receipt (orderdate, CustomerID, pricetotal, serviceclass) values
('24 June 2021', 'DataTest2', '$120.00', 'RemoveVirus')

create table service (
id varchar(50) UNIQUE,
invoiceId int not null identity(1,1),
service varchar(50),
price float,
priority varchar (20),
serviceDate date,
name varchar (20),
);

create table service (
UserIC varchar(50),
invoiceId int not null identity(1,1),
service varchar(50),
price float,
priority varchar (20),
serviceDate  varchar(50)
);

drop table service;

insert into service (UserIC, service, price, priority, serviceDate) values
('020629-10-0222', 'RemoveVirus', '5000.00', 'Urgent', '30 May 2021')

create table ReceiptDetail (
receiptdetailid int not null Identity(1, 1),
receiptid varchar (100) not null UNIQUE,
invoiceid varchar (100) not null UNIQUE,
TechnicianID int not null
);

drop table ReceiptDetail;

create table Progress (
UserIC varchar(20) not null UNIQUE,
startdate date not null,
enddate	date not null,
progress varchar(20) not null
);

drop table Progress;
