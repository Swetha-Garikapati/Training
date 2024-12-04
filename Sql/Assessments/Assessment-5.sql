use Assignment_2
select * from emp
select * from dept
---------------------1------------------------------
declare @Birthday date = '2001-10-15'; 
select @Birthday as 'Birthday',
datename(weekday, @Birthday) as 'Day of Week';
------------------2---------------------------------
declare @Birthdate date = '2001-10-15'; 
select datediff(day, @Birthdate,getdate())as 'Age In Days';
-------------3-----------------------------------
select * from emp
where year(getdate()) - year(hiredate) > 5
  AND month(hiredate) = month(getdate());
--------------4------------------------------------
Begin transaction   
create table  Employee(
empno int primary key,
ename varchar(50),
sal float,
DOJ DATE
)
insert into Employee
values(1,'ss',6300,'15-oct-2001'),
       (2,'mm',5400,'15-aug-2002'),
	   (3,'gg',8700,'18-may-2000'),
	   (4,'aa',3200,'18-may-2001')
	   select * from employee
 Begin transaction   
update employee
set sal=sal+(sal*0.15)
where empno=2
 
delete from employee
where empno=1
 
rollback
 
commit
-----------------------------------------5-----------------------------------------
create Function Calculate_Bonus
(
  @deptno int,
  @sal decimal(18,2)
  )
  returns decimal(18,2)
  as 
  begin
  declare @Bonus float;
  if  @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;
 select empno, ename,dbo.Calculate_Bonus(deptno,sal) as BONUS from emp
 ------------------------------------6---------------------------------
 create procedure  Sal_update      
  as
  begin
    update emp
    set sal=sal+500
	where deptno=(select deptno from dept where dname='SALES') and sal<1500
  end
 
  Exec Sal_update
  select *from emp
 