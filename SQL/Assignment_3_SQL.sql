select * from Customer
select * from  Orders
select * from Products
select * from Orderitem
select * from Employee


Create table Customer
(Id int  primary key, First_Name nvarchar(50),Last_Name nvarchar(50),city nvarchar(50),country nvarchar(50),phone nvarchar(50));


 Create table Orders 
 (Id int primary key, OrderDate datetime, OrderNumber nvarchar(50),Customerid int foreign key references Customer(id),TotalNumber decimal(12,2));

 Create table Products
 (Id int primary key, ProductName nvarchar(50), UnitPrice decimal(12,2),Package nvarchar(40),IsDiscontinued bit);

 Create table Orderitem
 (Id int primary key,OrderId int foreign key references Orders(Id),ProductId int foreign  key references Products(Id),UnitPrice decimal (12,2),Quantity int);

 Create table Employee(
FirstName nvarchar(40), LastName nvarchar(40), Department nvarchar(40), Rating int ,Saalaary int);

 insert into Customer values (1,'Nikita', 'Punde', 'Ahmednagar','India','9091464320');
  insert into Customer values (2,'Amruta', 'Kulkarni', 'Nashik','India','9075464320');
  insert into Customer values (3,'Gauri', 'Devhadrao', 'California','America','9091464320');
  insert into Customer values (4,'Rutuja', 'Thombre', 'Paris','France','7754775655');
  insert into Customer values (5,'Devashree', 'More', 'Pune','India','0300074321');
  insert into Customer values (6,'Apurva', 'Gondkar', 'London','UK','9328874321');
  insert into Customer values (7,'Shweta', 'Hase', 'London','UK','9328874321');

  insert into Orders values(1,'1/1/2018' ,'110',1,764653);
   insert into Orders values(2,'8/8/2019' ,'111',2,764654);
   insert into Orders values(3,'7/3/2018' ,'112',3,764655);
   insert into Orders values(4,'2/6/2020' ,'113',4,764656);
   insert into Orders values(5,'6/11/2020' ,'114',5,764657);
   insert into Orders values(6,'4/16/2021' ,'115',6,764658);
   insert into Orders values(7,'2/18/2022' ,'116',7,764659);

   insert into Products values ( 1,'Chai',654,'RedLabel',1,Null);
   insert into Products values ( 2,'Coffe',350,'Davidoff',15,Null);
   insert into Products values ( 3,'soda',500,'Pitcher',1,Null);
   insert into Products values (4,'Chai',764,'taj',0,'Breakfast');
   insert into Products values (5,'Fish',782,'Shark',0,'Seafood');

   Alter table Products add Category nvarchar(40);

   update Orders set OrderDate = '2020/12/05 12:32:59:20' where Id = 2;
update Orders set OrderDate = '2021/10/05 11:22:59:20' where Id = 3;
update Orders set OrderDate = '2021/11/06 02:52:42:40' where Id = 4;
update Orders set OrderDate = '2022/03/04 11:22:59:20' where Id = 5;

insert into Orderitem values (234,3,1,534,54 );
insert into Orderitem values (764,5,2,874,59 );
insert into Orderitem values (836,4,3,498,87 );
insert into Orderitem values (902,6,4,321,90 );

insert into Employee1 values ('Nikita','Punde','ENTC',5,30000);
insert into Employee1 values ('Gauri','Devhadrao','Civil',4,20000);
insert into Employee1 values ('Rutuja','Thombre','Electrical',3,30000);
insert into Employee1 values ('Apurva','Gondkar','Civil',4,40000);
insert into Employee1 values ('Amruta','Kulkarni','Computer',2,10000);

select * from Orders where CustomerId = (select Id from Customer where Phone ='0300074321');
select * from Employee1
 
 select First_Name,Last_Name as fullname from Employee 
select *from  Products where Category = 'Seafood'
create table Employee1 
 (Id int primary key identity, 
 FirstName nvarchar(50),
 LastName nvarchar(50),
 Department nvarchar(50),
 ManagerId int,
  Salary int);

select * from Orders inner join Customer on Orders.CustomerId=Customer.Id where City != 'London';

 

select * from Orderitem where ProductId = (select Id from Products where ProductName in ('Chai'));

 select FirstName,LastName,Department,Rating from Employee 
 
 1]
 select * from Customer where Country ='Germany'

 2]
   Alter table Customer add Fax nvarchar(40);

   update Customer set Fax = '5656578978' where Id = 4;
   select * from Customer where Fax like '%';
3]
   select * from Customer where First_Name like '_U';

4]
   select * from OrderItem where UnitPrice>10 and UnitPrice<20

5]
   Alter table Orders add ShipName  nvarchar(50), ShippingCompanyName nvarchar(50),ShippingDate Date;
  select * from Orders order by ShippingDate
  update Orders set ShipName = 'Exotic Liquids', ShippingCompanyName = 'La corne dabondance' , ShippingDate = '2022/12/18' where Id = 1;
  update Orders set ShipName = 'Biotix',ShippingCompanyName = 'Corneia',ShippingDate = '2023/1/21' where Id = 2;
  update Orders set ShipName = 'Toxic',ShippingCompanyName = 'Biomatic',ShippingDate = '2023/1/20' where Id = 3;
  update Orders set ShipName = 'Biotix',ShippingCompanyName = 'Corneia',ShippingDate = '2023/1/19' where Id = 4;
  update Orders set ShipName = 'Exotic Liquids',ShippingCompanyName = 'La corne dabondance',ShippingDate = '2023/5/3' where Id = 5;
   update Orders set ShipName = 'Toxic',ShippingCompanyName = 'Biomatic',ShippingDate = '2023/5/6' where Id = 6;
    update Orders set ShipName = 'Biotic',ShippingCompanyName = 'Corneia',ShippingDate = '2023/6/15' where Id = 7;
  

  6]
  select ProductName,ShipName
  from Products 
  left join OrderItem
  On Products.Id = OrderItem.ProductId
  left join Orders
  On Orders.Id=OrderItem.OrderId
  where ShippingCompanyName='Exotic Liquids'

 7]

 select avg(OrderItem.Quantity) as Total, Products.ProductName
 from Products
 left join OrderItem
 ON OrderItem.ProductId =Products.Id
 group by Products.ProductName


 8]
 select ShippingCompanyName,ShipName
 from Orders



 9]
 Create table Employee_2
 (Id int primary key identity(1,1),
 Name nvarchar(50) not null,
 ManagerId int not null)


 10]
 select m.Name,e.Name as ManagerName
 from Employee_2 e
 inner join Employee_2 m
 ON e.Id=m.ManagerId



 11]
 select ProductName,ShippingCompanyName,(Products.Unitprice*Quantity) as TotalPrice
 from Products
 full outer join OrderItem
 on Products.Id=OrderItem.ProductId
 full join Orders
 on Orders.Id=OrderItem.OrderId
 where ShippingCompanyName like 'Exotic Liquids' and Products.UnitPrice>50




 

