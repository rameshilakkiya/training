select u.name as Name,s.name as Servicename,description as Describe,status as STatus from users1 u,services s;
 select users1.name
        , services.name as ProviderName,description,status 
 from users1
      cross join services
 where users1.roleid = 3
 
 select users1.name,email,mobile,city,location,address,zipcode
        , services.name as ProviderName
 from users1
      cross join services
 where users1.roleid = 2 and services.name='plumbing'

  select tableA.column1
        , tableD.column9
 from tableA
      cross join tableD
 where tableA.column1 = 'C'
 and tableD.column9 > 30