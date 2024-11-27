create database Assessment_4
use Assessment_4
create table books
(
ID int primary key ,
Title varchar(100) not null,
Author varchar(100) not null,
Isbn varchar(15) unique,
Published_date datetime NOT NULL
);
 
insert into books 
values
    (1,'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
    (2,'My Second SQL book', 'John Mayer', '8573000923713', '1972-07-03 09:22:45'),
    (3,'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');
 
create table reviews (
    id int Primary key,
    book_id int NOT NULL,
    reviewer_name varchar(100) NOT NULL,
    content text,
    rating int check (rating BETWEEN 1 AND 5),
    published_date datetime NOT NULL,
    foreign key (book_id) REFERENCES books(id) ON DELETE CASCADE
);
 
insert into reviews
values(1, 1,'John Smith','My first review',4,'2017-12-10 05:50:11.1'),
	  (2, 2,'John Smith','My second review',5,'2017-10-13 15:05:12.6'),
	  (3, 3,'Alice walker','Another review',1,'2017-10-22 23:47:10');
 
------------------------1 
select * from books
where author LIKE '%er';
 
---------------------------2
select b.title, b.author, r.reviewer_name
from books b
JOIN reviews r on b.id = r.book_id;
 
--------------------------3
select reviewer_name
from reviews
group by reviewer_name
having COUNT(DISTINCT book_id) > 1;
 


create table customers(
id int primary key,
name varchar(40),
age int,
address varchar(40),
salary float)
 
insert into customers values(1,'ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'delhi',1500.00),
(3,'kaushik',23,'kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',85000),
(6,'komal',22,'Mp',4500.00),
(7,'Muffy',24,'Indore',10000.00)

 
-------------------------------------------4
select name,address from customers where address like'%o%'
 
 
create table orders1(
Oid int,
Date date not null,
customer_id int references customers(id)  not null,
amount int
)
 
insert into orders1 values
(102,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)
 select * from orders1
 
-------------------------------------5-------------------------------
 select date, COUNT(CUSTOMER_ID) TotalCustomers from Orders1 group by Date;
 
 
 create table Employee
(
Id int primary key,
Ename varchar(20) not null,
Age int not null,
Addres varchar(20) not null,
Salary int
)
 
 
insert into Employee values
(1,'Ramesh',32,'Ahmedabad',2000.00),
(2,'Khilan',25,'Delhi',1500.00),
(3,'Kaushik',23,'Kota',2000.00),
(4,'Chaitali',25,'Mumbai',6500.00),
(5,'Hardik',27,'Bhopal',8500.00),
(6,'Komal',22,'MP',null),
(7,'Muffy',24,'Indore',null)

 
----------------------------------------------6
 
select LOWER(Ename) from Employee where Salary is null
 
 
create table Student_details
(
Register_no int primary key,
Name varchar(30) not null,
Age int not null,
Qualification varchar(20),
Mobile_no float not null,
Mail_id varchar(30),
locationn varchar(30),
Gender varchar(1)
)

insert into Student_details values
(2,'Sai',22,'B.E',9952836779,'sai@gmail,com','Chennai','M'),
(3,'Kumar',20,'BSC',7252836779,'kumar@gmail,com','Madurai','M'),
(4,'Selvi',22,'B.TECH',8952836779,'selvi@gmail,com','Selam','F'),
(5,'Nisha',25,'M.E',6352836779,'nisha@gmail,com','Theni','F'),
(6,'SaiSaran',21,'B.A',9865836779,'saisaran@gmail,com','Madurai','F'),
(7,'Tom',23,'BCA',6552836779,'tom@gmail,com','Pune','M')

---------------7--------------------------------
select Gender,count(*) as Total_count from Student_details group by Gender 
