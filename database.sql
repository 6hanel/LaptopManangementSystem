
create table Userdetail (
UserIC varchar (20) not null,
Name varchar (50) not null UNIQUE,
Email varchar (150) not null,
password int not null UNIQUE,
age int not null,
gender varchar (50) not null,
phonenumber varchar (20) null,
usertype varchar(20) NOT NULL,
);

drop table Userdetail;

insert into Userdetail(UserIC, Name, Email, password, age, gender, phonenumber, usertype) values
('020629100227', 'Azure', 'nitress86@gmail.com', '8688', '20', 'Male', '0108236388', 'Receptionist'),
('012345678910', 'DataTest1', 'datatest1@gmail.com', '1234', '50', 'Female', '0123456789', 'Technician'),
('987654321098', 'DataTest2', 'datatest2@gmail.com', '4321', '51', 'Male', '9876543210', 'Customer');

create table Receptionist (
receptionistid int NOT NULL Identity(1, 1),
UserIC varchar (20) not null,
name varchar (100) not null,
email varchar (150) not null unique,
Password int not null Unique,
age int not null,
gender varchar(50) not null,
phonenumber varchar(20) null,
);

drop table Receptionist;

insert into Receptionist (UserIC, name, email, password, age, gender, phonenumber) values
('020629100227', 'Azure', 'nitress86@gmail.com', '8688', '20', 'Male', '0108236388')

create table Technician (
technicianID int not null Identity(1, 1),
UserIC varchar (20) not null,
name varchar (100) not null,
email varchar (150) not null unique,
Password int not null Unique,
age int not null,
gender varchar(50) not null,
phonenumber varchar(20) null,
);

drop table Technician;

insert into Technician (UserIC, name, email, Password, age, gender, phonenumber) values
('012345678910', 'DataTest1', 'datatest1@gmail.com', '1234', '50', 'Female', '0123456789')

create table Customer (
CustomerID int NOT NULL Identity(1, 1),
receiptid int NOT NULL,
UserIC varchar (20) not null,
name varchar (100) not null,
email varchar (150) not null UNIQUE,
password int not null UNIQUE,
age int not null,
gender varchar (50) not null, 
phonenumber varchar(20) null,
);

drop table Customer;

insert into Customer (UserIC, name, email, password, age, gender, phonenumber) values
('987654321098', 'DataTest2', 'datatest2@gmail.com', '4321', '51', 'Male', '9876543210')

create table Receipt (
receiptid int NOT NULL Identity(1, 1),
Orderdate date not null,
CustomerID nvarchar(100) NOT NULL,
pricetotal varchar(20) NOT NULL,
serviceclass varchar(50) not null,
);

drop table Receipt;

insert into Receipt (orderdate, CustomerID, pricetotal, serviceclass) values
('24 June 2021', 'DataTest2', '$120.00', 'RemoveVirus')

drop table Service;

create table Service (
id varchar(50),
invoiceId int not null identity(1,1),
service varchar(50),
price float,
priority varchar (20),
serviceDate date,
name varchar (20),
);

insert into Service (id, service, price, priority, serviceDate, name) values
('1', 'RemoveVirus', '5000.00', 'Urgent', '30 May 2021', 'DataTest2')

create table ReceiptDetail (
receiptdetailid int not null Identity(1, 1),
receiptid int not null,
invoiceid int not null,
TechnicianID int not null,
);

drop table ReceiptDetail;

create table Progress (
serviceid int not null,
startdate date not null,
enddate	date not null,
progress varchar(20) not null
);

drop table Progress;
