use healthinsurance
create table payment(
paymentid  bigint constraint pk_dbo_payment_id primary key identity(109400,1),
rpolicyid  int constraint fk_dbo_usertable_payment FOREIGN KEY references policytable(policyID),
cardholderName varchar(40),
amount float
)


select * from payment
drop table payment