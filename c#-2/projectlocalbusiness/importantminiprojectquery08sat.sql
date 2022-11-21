select * from servicebooking;
select * from serviceprovider;
select * from services;
UPDATE serviceprovider
SET serviceprovider.status = 'r'
FROM serviceprovider E, servicebooking C,services s
WHERE E.serviceid = C.serviceid;
update services set services.status='r' from services s, serviceprovider E, servicebooking C
where s.Id=E.serviceid;
UPDATE servicebooking
SET servicebooking.status = 'r'
FROM serviceprovider E, servicebooking C,services s
WHERE E.serviceid = C.serviceid;
update serviceprovider set status='r',date='2022-10-07',rating=3,comment='goood'
from serviceprovide s,services c,users1 u where s.serviceid=c.Id and u.Id=(select Id from users! where email='manju@gmail.com');
select Id from users1 where email='ilak@gmail.com';
select * from serviceprovider where userid=1;
select * from users1;
select Id from users1 where Id=(select userid from serviceprovider where serviceid=1);
select * from services where Id=( select serviceid from serviceprovider where userid=(select Id from users1 where email='ilak@gmail.com'));
 select serviceid from serviceprovider where userid=(select Id from users1 where email='ilak@gmail.com');
 update test set name = 'john' where id = 3012
IF @@ROWCOUNT = 0
   insert into test(name) values('john');
update serviceprovider set serviceid=Id where userid=(select Id from users1 where email='ilak@gmail.com')
select * from services;
select * from servicebooking;
insert into servicebooking(date,serviceid,spid,userid,description,status,providerdescription)Values('2022-09-22',3,2,5,'tapproblem','a','asap'); 
select * from servicebooking where date='2022-10-07 06:34:10.637' and serviceid=(select serviceid from serviceprovider where  userid=(select Id from users1 where email='ilak@gmail.com'));
select * from serviceprovider where userid=(select Id from users1 where email='ilak@gmail.com')
select * from users1;

            
