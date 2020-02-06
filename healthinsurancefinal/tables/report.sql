use healthinsurance

create table report
(
policyID int constraint fk_dbo_usertable_report FOREIGN KEY references policytable(policyID),
question varchar(100),
description varchar(100)

)
select * from report
drop table report