create database Assessment_6
use Assessment_6
create table course
(
    C_id varchar(5) primary key,
    C_Name varchar(50),
    Start_date date,
    End_date date,
    Fee int
);
insert into Course
values ('DN003', 'Dot Net', '2018-02-01', '2018-02-28', 15000),
	   ('DV004', 'Data Visualization', '2018-03-01', '2018-04-15', 15000),
	   ('JA002', 'AdvancedJava', '2018-01-02', '2018-01-20', 10000),
	   ('JC001', 'CoreJava', '2018-01-02', '2018-01-12', 3000);
	   select * from course
--------------------------------------------------------1-------------------------------------------
create function CalculateCourseDuration(@start_date DATE, @end_date DATE)
returns int
as
begin 
   return
        DATEDIFF(day, @start_date, @end_date);
		end;
select dbo.CalculateCourseDuration('2024-01-01', '2024-03-01') AS DurationInDays;
-----------------------------------------------------------2-------------------------------------------
create table T_CourseInfo (
    CourseName varchar(30),
    StartDate date
);
CREATE TRIGGER trg_after_insert_course ON Course
AFTER INSERT 
as 
BEGIN
    INSERT INTO T_CourseInfo (CourseName, StartDate)
    SELECT C_Name, Start_Date
    FROM INSERTED;
END;
INSERT INTO Course
VALUES ('DB002','MySQL', '2024-01-15','2024-03-15',18000);
SELECT * FROM T_CourseInfo; 
------------------------------------------------------3-------------------------------------
 create table Products_Details (
    ProductId int identity(1,1) primary key,
    ProductName varchar(30),
    Price float not null,
    DiscountedPrice float
);
 
create procedure Insert_Products
    @ProductName varchar(100),
    @Price float
as
begin
    declare @ProductId int;
    declare @DiscountedPrice float;
 
    set @DiscountedPrice = @Price - (@Price * 0.10);
    insert into Products_Details(ProductName, Price, DiscountedPrice)
    values (@ProductName, @Price, @DiscountedPrice);
 
    set @ProductId = SCOPE_IDENTITY();
 
    select @ProductId as ProductId, @DiscountedPrice as DiscountedPrice;
end;
select * from Products_Details
