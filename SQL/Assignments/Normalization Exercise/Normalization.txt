create database Normalization

use Normalization

--1NF
create table ClientRentals_1NF(
client_no varchar(50),
c_name varchar(50),
property_no varchar(50),
p_address varchar(50),
rent_start date,
rent_finish date,
rent int,
owner_no varchar(50),
o_Name varchar(50)
)

insert into ClientRentals_1NF values
('CR76','John Kay','PG4','6 Lawrence','2003-07-09','2001-09-01',350,'CO40','tina murphy'),
('CR76','John Kay','PG16','5 novar dr glass grow','2001-09-02','2001-09-02',450,'CO93','tony shaw'),
('CR56','Aline stewart','PG4','6 Lawrence','1999-09-01','2000-09-01',350,'CO40','tina murphy '),
('CR56','Aline stewart','PG36','2 manor rd, glass gow','2000-10-10','2001-12-01',370,'CO93','tony shaw'),
('CR56','Aline stewart','PG16','5 novar dr glass grow','2002-11-01','2003-08-01',450,'CO93','tony shaw')

select * from ClientRentals_1NF

-------------------------------------------------------------------------------------------------------
----2NF

--- Clients Table
create table Clients_2NF(
client_no varchar(50) Primary key,
c_name varchar(50)
)

insert into clients_2nf(client_no,c_name) values
('CR76', 'John Kay'),
('CR56', 'Aline Stewart')

select * from Clients_2NF

--- Properties Table
create table Properties_2NF(
property_no varchar(50) Primary Key,
p_address varchar(50),
owner_no varchar(50),
o_Name varchar(50)
)

insert into Properties_2nf(property_no, p_address, owner_no, o_Name) values
('PG4', '6 Lawrence', 'CO40', 'Tina Murphy'),
('PG16', '5 Novar Dr Glass Grow', 'CO93', 'Tony Shaw'),
('PG36', '2 Manor Rd, Glass Gow', 'CO93', 'Tony Shaw')

select * from Properties_2NF

--- Rentals Table
create table Rentals_2NF(
client_no varchar(50) references Clients_2nf(client_no),
property_no varchar(50) references Properties_2nf(property_no),
rent_start DATE,
rent_finish DATE,
rent int,
primary key (client_no, property_no),
)

insert into Rentals_2nf(client_no, property_no, rent_start, rent_finish, rent) values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)

select * from Rentals_2NF

--------------------------------------------------------------------------------------------------------
--3NF

--Clients
create table Clients_3NF(
client_no varchar(50) primary key,
c_name varchar(50)
)

insert into clients_3nf(client_no, c_name) values
('CR76', 'John Kay'),
('CR56', 'Aline Stewart')


--PropertyOwners Table
create table property_owners_3NF(
owner_no varchar(50) primary key,
o_Name varchar(50)
)

insert into property_owners_3NF(owner_no, o_Name) values
('CO40', 'Tina Murphy'),
('CO93', 'Tony Shaw')

-- Update the Properties table to reference Property Owners
create table properties_3nf (
property_no varchar(50) primary key,
p_address varchar(50),
owner_no varchar(50) references property_owners_3NF(owner_no)
)

-- Insert values into the Properties table
insert into properties_3nf(property_no, p_address, owner_no) values
('PG4', '6 Lawrence', 'CO40'),
('PG16', '5 Novar Dr Glass Grow', 'CO93'),
('PG36', '2 Manor Rd, Glass Gow', 'CO93')

--Rental Table
create table Rental_3NF (
client_no varchar(50),
property_no varchar(50),
rent_start DATE,
rent_finish DATE,
rent int,
primary key (client_no, property_no),
foreign key (client_no) references Clients_3nf(client_no),
foreign key (property_no) references Properties_3nf(property_no)
)

-- Insert values into the Rental table
insert into Rental_3nf(client_no, property_no, rent_start, rent_finish, rent) values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450)

------------------------------------------------------------------------------------------------------
select * from Clients_3nf
select * from Properties_3nf
select * from property_owners_3NF
select * from Rental_3nf