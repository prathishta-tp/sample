use healthinsurance

create table policytable
(
policyID int constraint pk_dbo_policytable_id primary key identity(11,1),
userid  tinyint constraint fk_dbo_usertable_id FOREIGN KEY references usertable(id),
cusName varchar(40),
cusAge int,
username varchar(40),
policyType varchar(40),
policyPeriod varchar(20),
insuredAmount int,
coInsurance varchar(20),
premium float,
policyStartDate datetime,
policyEndDate datetime
)


sp_help 'usertable'
select * from policytable
--drop table policytable
