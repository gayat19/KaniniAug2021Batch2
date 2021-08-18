select * from titles
select title, price from titles
select title Book_Name, price Book_Price from titles
select title 'Book Name', price 'Book Price' from titles

select * from titles where price>10
--write a query to get all teh titles that have price less than 5
select * from titles where price < 5
--write a query to get all teh titles that have price less than 10 but greater than 5
select * from titles where price>=5 and price <= 10
select * from titles where price between 5  and  10
--Get all the details of titles that have price > 10 and type is psychology  
select * from titles where price>5 and type='psychology'

--select only name and price of boks that have advance > 3500
select title,pricefrom titleswhere advance >3500 
--slect the titles that are of type business or mod_cook    
select * from titles where type='business' or type='mod_cook'   
select *from titleswhere type in('business','mod_cook')

select * from titles where pubdate > '1991-06-12'
select * from authors

--Select all from authors table
-- select teh authors who are from CA
--select authors from Oakland and Salt Lake City
select * from authors where  state='CA'
select * from authors where city='Oakland' or city='Salt Lake City' 
select * from authors where city in('Oakland','Salt Lake City' )

--select sales that have quantity > 2
select * from sales where qty>2

select * from titles

select title, price from titles where price is null


select * from authors where  state='CA'

select count(au_id) from authors where  state='CA'
select count(au_id) 'Number of authors from CA' from authors where  state='CA'

select * from titles

select min(price) from titles
--fint the maximum, average price from titles
select avg(price) as 'Average Price' from titles
--Find average price of book of type business or mod_cook 
select min(price) 'Min price', 
max(price) 'Max Price', 
avg(price) 'Average price' from titles 
where type in ('business','mod_cook')

select type from titles
select distinct type from titles

--Get the average price of every type
select type,avg(price) from titles 
group by type

--Get the min quantity sold for every title(use the sales table)
select title_id,min(qty) from sales
group by title_id

-- count the number authors from every city
select city,count(*) 'Number of authors' 
from authors group by city

--Get the number of books and their average price 
--for every pulisher
select pub_id,count(*) as 'Number of books', avg(price) as 'Average Price' from titlesgroup by pub_id

--Find the first hiring date of every publisher
select pub_id,min(hire_date) as 'First Hire Date' from employee group by pub_id


select type,avg(price) from titles 
group by type

select type,avg(price) from titles 
group by type
having avg(price)>15
--Get the number of employee in every publisher if they have more than 2
select pub_id,count(*) as 'Number of Employee' 
from employee 
group by pub_id 
having count(*)>2
-- Get the average quantity sold for every title that is greater than 4
select title_id,avg(qty) as 'average quantity' 
from sales group by title_id having avg(qty) > 4 

--get the count of books sold by every publisher 
--which are in type 'business' or type='mod_cook'  
-- where the count is greater than 2
select pub_id,count(title_id) 'no of books published'from titleswhere type in ('business','mad_cook')group by pub_idhaving count(*)>2

select * from titles order by price
select * from titles order by price desc


--select the titles that are priced> 15 and sort them by published date
select title from titles where price >15 order by pubdate

---Get the number of employee in every publisher if they have more than 2
--order them by the number od employees
select pub_id,count(*) as 'Number of Employee' 
from employee 
group by pub_id 
having count(*)>2
order by 2

select * from publishers

select pub_id from publishers where pub_name = 'Algodata Infosystems'

select * from titles where pub_id = '1389'

select * from titles 
where pub_id = (select pub_id from publishers where pub_name = 'Algodata Infosystems')



select * from titles 
where pub_id in (select pub_id from publishers where country = 'USA')

-- print all the sales for titles that are priced >10
select * from sales where title_id in(select title_id  from titles where price>10) 

--select the authors who are from same city as the publisher name Algodata Infosystems
select * from authors where city in(select city from publishers where pub_name='Algodata Infosystems')

select concat(fname,' ',lname) from employee

--print the employee name  who work for teh publishe who published Straight Talk About Computers
select concat(fname,lname) as 'emp_name' from employee 
where pub_id in(select pub_id from publishers 
where pub_id in(select pub_id from titles where title='Straight Talk About Computers'))



