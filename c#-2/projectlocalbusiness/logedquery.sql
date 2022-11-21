select * from serviceprovider
select * from serviceprovider where userid=(select Id from users1 where email='shai@gmail.com')
select * from servicebooking;