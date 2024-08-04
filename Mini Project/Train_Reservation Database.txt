--Creating database 
create database Train_Reservation
use Train_Reservation
--1. table which consists of train details
Create table Trains(Train_No int primary key, Train_Name varchar(50), Source_Station varchar(30), Destination_Station varchar(30), Price int not null,class_of_travel varchar(10),train_status varchar(10),seat_available int)
Insert  into Trains values (12179,'InterCity SF Express','Lucknow Junction','Agra Fort',145,'SL','Active',780),
(12583,'AC Double Decker Express','Lucknow Junction','Anand Vihar Terminal',560,'CC','Inactive',120),
(22426,'Vande Bharat Express','Anand Vihar Terminal JN','Ayodhya Cantt.',1450,'2AC','Active',30),
(82501,'IRCTC Tejas Express','Lucknow Junction','New Delhi',2500,'1AC','Active',15),
(12230,'Lucknow Mail','Lucknow Junction','New Delhi',1200,'SL','Inactive',25)
Select * from Trains
drop table Trains 
--2. table which consists of bookings details
Create table Bookings (Booking_Id int primary key identity (1,1),
Train_No int,User_ID INT,No_of_Tickets INT,
Booking_Date DateTime,Foreign Key (Train_No) references Trains(Train_No))
--3. table which consists of Cancellations details
Create table Ticket_Cancellations (Cancellation_ID INT Primary Key  Identity (1,1),
Booking_ID INT,No_of_Tickets INT,Cancellation_date DateTime,Foreign Key (Booking_ID) references Bookings(Booking_ID))
--4. table which consists of Users details
Create Table Users(User_ID INT primary key identity (1,1),User_Name Varchar(50),Password Varchar(50),role Varchar(10))

Select * from Trains
Select * from Bookings
Select * from Ticket_Cancellations
select * from Users
