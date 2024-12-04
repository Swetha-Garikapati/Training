use Assignment_2
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