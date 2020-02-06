use healthinsurance
create table claim(
cusid tinyint constraint fk_dbo_usertable_cusidclaim FOREIGN KEY references usertable(id),
polId int constraint fk_dbo_policytable_polidclaim FOREIGN KEY references policytable(policyID),
policyType varchar(40),
periodpol varchar(30),
polenddatee datetime,
claim_status varchar(30)

)
select * from claim