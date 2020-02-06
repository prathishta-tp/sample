use healthinsurance
create table renewal(
rpolicyid  int constraint fk_dbo_usertable_renew FOREIGN KEY references policytable(policyID),
renewdate datetime
)


select * from renewal
drop table renewal