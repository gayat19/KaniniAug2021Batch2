use pubs
--Complies and generated the excution plan only once
--Encapsulate the underlying tables
--No Data Injection - more secure

create procedure proc_example
as
begin
  print 'hello world'
end

execute proc_example

create procedure proc_example_parameter(@username varchar(20))
as
begin
  print 'hello '+@username
end

execute proc_example_parameter 'James'

create procedure proc_example_out_parameter(@username varchar(20),@msg varchar(100) out)
as
begin
  set @msg =  'hello '+@username
end

declare
  @myMsg varchar(100)
  exec proc_example_out_parameter 'James', @myMsg out
  print @myMsg

create proc proc_Get_All_Authors
as
   select * from authors

exec proc_Get_All_Authors

create proc proc_Get_Author_By_Id(@aid varchar(20))
as
  select * from authors where au_id = @aid


  exec  proc_Get_Author_By_Id '172-32-1176'
 
--create a proc to get the title using title id
create proc get_authors_titleid (@titleid varchar(20))asselect title from titles where title_id=@titleidexecute get_authors_titleid 'BU1032'--create a proc get the full name ans out of author using the author idcreate proc proc_get_authorname_by_id(@aid varchar(20),@auname varchar(50) out)as    set @auname = (select concat(au_fname,' ',au_lname) from authors where au_id = @aid)declare@aname varchar(50)execute proc_get_authorname_by_id '213-46-8915', @aname outprint @anamecreate proc proc_Get_Total_Qty_Price(@tid varchar(20),@tqty int out,@tprice float out)asbegin    set @tqty = (select sum(qty) from sales where title_id= @tid)	set @tprice = (select price from titles where title_id= @tid)enddeclare  @price float,@qty int,@amy floatbegin    exec  proc_Get_Total_Qty_Price 'BU1032', @price out, @qty out  set @amy = @price * @qty  print 'The book price is '+cast(@price as varchar(100))  print 'The quantity sold is '+cast(@qty as varchar(100))  print '-----------------------------------'  print 'The total amount is '+ cast(@amy as varchar(100))endcreate table tblEmpSample(id int identity(101,1) primary key,name varchar(20),age int)--create a proc that will insert records into the table tblEmpSamplealter proc proc_Insert_Employee (@name varchar(30),@age int)as    insert into tblEmpSample(name,age) values(@name,@age)exec proc_Insert_Employee 'Raja',21--create a proc that will update the age of employee by taking t he idcreate proc update_records_in_tblemp(@eid int, @eage int)asbegin    update tblEmpSample    set age = @eage    where id = @eidendexec update_records_in_tblemp '101', 22select * from tblEmpSample--scalar function or table valued functionscreate function fn_sample()returns varchar(10)asbegin   return 'hello'endselect dbo.fn_sample()alter function fn_sample_with_value(@name varchar(20))returns varchar(20)asbegin   return 'hello '+@nameendselect dbo.fn_sample_with_value('James')select * from tblEmpSampleselect * from titlescreate function fn_Cal_Tax(@value float)returns floatasbegindeclare  @net float  set @net = @value+(@value*12.3/100)  return @netendselect dbo.fn_Cal_Tax(advance) from titles--create a function that willcalculate the the advance - price) and use it in the titles tableCREATE FUNCTION fn_Cal_Adv_Sub_Price(@adv FLOAT, @price Float)RETURNS float    ASBEGINDECLARE    @net FLOAT    SET @net = @adv-@price    RETURN @netENDSELECT dbo.fn_Cal_Adv_Sub_Price(advance,price) 'Result' FROM dbo.titles--Table valued functioncreate function fn_Table_Sample(@id int,@name varchar(5))returns  @myTable table (f1 int,f2 varchar(10))asbegin   insert into @myTable values(@id,concat('hi ',@name))   returnendselect * from dbo.fn_Table_Sample(1,'James')create function fn_GetSaleDetails(@tid varchar(20))returns @saleTable table (ordernumber varchar(10), quantity int, price float)as begin	insert into @saleTable    select ord_num, qty,price from sales join titles on sales.title_id = titles.title_id    where sales.title_id=@tid   returnendselect * from titlesselect * from dbo.fn_GetSaleDetails('BU1032')