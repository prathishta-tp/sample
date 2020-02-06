use healthinsurance

create table usertable
(
id tinyint constraint pk_dbo_usertable_id primary key identity(1,1),--primary key
Firstname varchar(40),
lastname varchar(40),
email varchar(40),
age int not null,
username varchar(40) unique ,
phoneNumber bigint,
upassword varchar(40),
cpassword varchar(40),
city varchar(40),
gender varchar(40)
)
sp_help 'usertable'
select * from usertable
insert usertable(Firstname,lastname,email,age,username,phoneNumber,upassword,cpassword,city,gender)
values('isha','tp','isha@gmail.com',22,'ishatpp',8277051550,'qwer','qwer','mangalore','FEMALE')
--drop table usertable

select id from usertable where username = 'hiih'
select * from usertable