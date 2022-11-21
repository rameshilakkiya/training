alter  table serviceprovider add rating int,comment varchar(100); 
select * from serviceprovider;
update serviceprovider set rating=3,comment='good' where serviceid=2;
update serviceprovider set rating=5,comment='okkk' where serviceid=3
select * from servicebooking;
update servicebooking set status='accept' where Id=5;