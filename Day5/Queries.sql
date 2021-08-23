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
create proc get_authors_titleid (@titleid varchar(20))