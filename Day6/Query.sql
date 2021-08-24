create table tblTriggerCheck
(f1 int identity(1,1) primary key,
f2 varchar(20))

create trigger trg_CheckInsert
on tblTriggerCheck
for Insert
as
begin
   print 'Hello from Insert trigger'
end

insert into tblTriggerCheck(f2) values('One')

alter trigger trg_CheckInsert
on tblTriggerCheck
for Insert
as
begin
  declare
     @name varchar(10)
	 set @name = (select f2 from inserted)
   print 'Hello '+@name
end


insert into tblTriggerCheck(f2) values('Jack')

create table tblSalary
(id varchar(4) primary key,
BAsic float,
HRA float,
Da float,
Deductions float)

insert into tblSalary values('S001',10000,5000,5000,1500)
insert into tblSalary values('S002',15000,7500,6000,2000)
insert into tblSalary values('S003',12000,6000,6000,1750)

Create table tblEmpl
(id int identity(1,1) primary key,
name varchar(20))

insert into tblEmpl(name) values('James')
insert into tblEmpl(name) values('Jill')
insert into tblEmpl(name) values('Jack')

create table emplSal
(empid int references tblEmpl(id),
salId varchar(4) references tblSalary(id),
salDate date,
totalSal float)

select * from tblSalary
select * from tblEmpl

alter trigger trg_InsertEmplSal
on emplSal
for insert
as
begin
  declare 
  @totalSalary float
  set @totalSalary = (select (basic+hra+da-Deductions) from tblSalary where id = (select salid from inserted))
  update emplSal set totalsal = @totalSalary where empid = (select empid from inserted) and 
  salid = (select salid from inserted)
end

insert into emplSal(empid,salid,saldate) values(1,'S001',GETDATE())
insert into emplSal(empid,salid,saldate) values(2,'S002',GETDATE())

select * from emplSal


declare 
@empId int,@salId varchar(4),@totalSal float,@salDate Date,@empName varchar(20)
print 'Salary details'
declare cur_empsal cursor for
select * from emplSal

open cur_empsal

fetch next from cur_empsal into @empId,@salId,@salDate,@totalSal
while (@@FETCH_STATUS=0)
	begin
	   set @empName = (Select name from tblempl where id= @empId)
	   print 'Employee Id '+cast(@empId as varchar(5))
	    print 'Employee Id '+ @empName
	   print 'Salary ID '+@salId
	   print 'Salary '+cast(@totalSal as varchar(5))
	   print 'Salary Date '+cast(@salDate as varchar(20))
	   print '-----------------------------'
	   fetch next from cur_empsal into @empId,@salId,@salDate,@totalSal
	end
close cur_empsal
Deallocate cur_empsal


--create a trigger in employee table insert the employee id and name in to another table
--(tblAnoterEmployee-Please create this table)


--Create a cursor that will print the sale data in teh following format
--Book Name : abc
--Book price : 20
--Author : XXX
--Author : yyy
--Quantity : 2
--Total Price - 20*2 - 40
------------------------------------
