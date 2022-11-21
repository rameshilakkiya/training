select users1.name as UserName,users1.Id as userid ,email,mobile,city,location,address,zipcode ,services.name as ServiceName,services.Id as serviceid,description ,serviceprovider.Id as spid,serviceprovider.status from users1 cross join services,serviceprovider  where users1.roleid = 2 and  users1.email='manju@gmail.com';
select users1.name as UserName,users1.Id as userid ,email,mobile,city,location,address,zipcode, services.name as ServiceName,services.Id as serviceid,description ,serviceprovider.Id as spid,serviceprovider.status from users1 cross join services,serviceprovider  where users1.roleid = 2 and users1.email='manju@gmail.com' and  services.name='plumbing';
select * from servicebooking;
select * from services;
select * from serviceprovider;
Insert into serviceprovider(serviceid,userid,status,date,rating,comment)Values(4,'',@sta,@da,@rat,@com)
select userid=2 from users1;

INSERT INTO serviceprovider
SELECT Id,description,status
FROM services
WHERE NOT EXISTS(SELECT * 
         FROM serviceprovider 
         WHERE (services.id=serviceprovider.serviceid and
               services.description=serviceprovider.comment and
               services.status=serviceprovider.status
               )
        )
   update serviceprovider set status='r',date='2020-10-07',rating=3,comment='goood'
from serviceprovider s,services c,users1 u where s.serviceid=(select Id from services where name='plumbing') and u.Id=(select Id from users1 where email='manju@gmail.com');     
select * from serviceprovider;
delete from services where Id=10;
select * from services;
select * from services where Id=( select serviceid from serviceprovider where userid=(select Id from users1 where email=@nam))
select * from serviceprovider where serviceid=( select id from services where userid=(select Id from users1 where email=@nam))       
select serviceprovider.serviceid,userid,serviceprovider.status,date,rating,comment,services.name as serviceName,users1.name as ProviderName from users1 cross join services,serviceprovider where serviceprovider.userid=(select Id from users1 where name='smithy') and services.Id=(select serviceid from serviceprovider where userid=(select Id from users1 where name='smithy')) and users1.Id=(select Id from users1 where name='smithy');
select * from serviceprovider where userid=(select Id from users1 where name='sadhan');
select * from serviceprovider;
select * from users1 where name='sadhan';
select serviceprovider.serviceid,userid,serviceprovider.status,date,rating,comment,services.name as serviceName,users1.name as ProviderName from users1 cross join services,serviceprovider where serviceprovider.serviceid=2 and services.Id=2 and users1.Id=(select Id from users1 where name='smithy');
select * from serviceprovider;
select Id from services where name='homeservices';
select services.name as ServiceName,services.Id as serviceid,description ,serviceprovider.Id as spid,serviceprovider.status from users1 cross join services,serviceprovider  where users1.roleid = 2;
update serviceprovider set status='r',date='2020-01-10',rating=3,comment='fine',serviceid=(select Id from services where name='homeservices'),userid=(select Id from users1 where email='sadhan@gmail.com')from serviceprovider s,services c,users1 u where s.serviceid=(select Id from services where name='homeservices') and u.Id=(select Id from users1 where email='sadhan@gmail.com');
insert into serviceprovider(status,date,rating,comment,serviceid,userid)Values('r','2020-01-10',3,'testing',5,16); 
INSERT INTO 
    serviceprovider (serviceid,userid,status,date,rating,comment) 
    
SELECT
serviceid,userid,status,date,rating,comment
FROM
    services,
    users1
WHERE
    services.Id=(select Id from services where name='plumbing') and  users1.Id=(select Id from users1 where name='smithy' ) and status='r' and date='2019-01-10' and rating=3 and comment='slightly';

    
