create database dbCompany17Aug

use dbCompany17Aug

--(),[],{},<>

Create table Areas
(area varchar(20),
zip char(5)
)

sp_help Areas

alter table Areas
alter column area varchar(20) not null

alter table Areas
add constraint pk_Area primary key(area)

drop table Areas

Create table Areas
(area varchar(20) primary key,
zip char(5)
)
Create table Areas
(area varchar(20) constraint pk_Area primary key,
zip char(5)
)

Create table Employees
(id int identity(101,1) primary key,
name varchar(20),
phone varchar(15),
employee_area varchar(20) foreign key references Areas(area))

sp_help Employees

create table Skills
(skill varchar(20) primary key,
SkillDescription varchar(1000))

create table EmployeeSkill
(Employee_id int foreign key references Employees(id),
Skill_Name varchar(20) foreign key references Skills(skill),
Skill_Level float default(3),
primary key(Employee_id,Skill_name))

sp_help EmployeeSkill

select * from areas

insert into areas values('AAA','12345')
insert into areas(area,zip) values('BBB','12445')
insert into areas(zip,area) values('12123','CCC')
--Will not work
insert into areas values('AAA','12345')
insert into areas values(null,'12345')
insert into areas values('DDD','2353454645654')

insert into employees(name,phone,employee_area) values('James','1234567890','AAA')
insert into employees(name,phone,employee_area) values('Jack','9876543210','BBB')
--Failed inserts
insert into employees(name,phone,employee_area) values('Jack','9876543210','DDD')

insert into Skills values('SQL','RDBMS'),('C','PLT'),('Java','Web')

select * from Skills

insert into EmployeeSkill values(101,'C',7)
insert into EmployeeSkill values(101,'SQL',8)
insert into EmployeeSkill values(102,'C',default)
	
select * from EmployeeSkill


create table Occation
(id int identity(1,1) primary key,
name varchar(20),
start_date datetime,
end_date datetime,
description varchar(2000))

insert into Occation(name,start_date,end_date,description) 
values('Christmas','12-12-2021','12-28-2021','Christmas gifts and decors')

select * from Occation

