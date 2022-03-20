Create table Registration(
fullName	varchar(30),	 
email	varchar(30),	 
number	 Numeric(20),	 
address	varchar(30),	 
reg_id	 Numeric(18)primary key  ,
cardtype varchar(30),
bank varchar(30),
accno varchar(20) unique,
IFSC_code varchar(30),
userid	 Numeric(18),
foreign key(userid)References Logintype(userid),
)
drop table Registration
select * from Registration
 ---------------------------------------------------------
 ----------------------------------------------------------

Create table Logintype(
Userid	 Numeric(18)primary key,
password varchar(30),
usertype_id	 Numeric(18),
foreign key(usertype_id)References User_Type(usertype_id)
)
select * from Logintype
drop table  Logintype
---------------------------------------------------
--------------------------------------------------

Create table User_Type(
usertypename	varchar(30),
usertype_id	  Numeric(18)primary key,
)
insert into User_Type values('regular',101);
insert into User_Type values('regular',102);

drop table   User_Type
select * from User_Type
-------------------------------------------------------
-----------------------------------------------------------

Create table Products(
Product_id	 Numeric(18)primary key,
Name	varchar(30),	 
price	decimal(10,4),	 
image	 varchar(30),	 
status	varchar(30),	 
 
)
insert into Products values (1,'Dellxp',35000,'https://merchantfly.com/wp-content/uploads/2015/08/Dell-XPS-13_021.jpeg','available');
insert into Products values (2,'Lenovothinkpad',50000,'https://i5.walmartimages.com/asr/483eea15-3313-4481-8a4d-a557229fcd71_1.a42c4a0f7445c4fe50e7acc3cac63c02.jpeg','available');
insert into Products values (3,'Hp',35000,'https://tse4.mm.bing.net/th?id=OIP.cQU3uEk3l6y6Ylx60F_0JgHaF6&pid=Api&P=0&w=216&h=172','Not available');
drop table  Products
select * from Products
------------------------------------------------
-------------------------------------------------
Create table Orders(
orderid  Numeric(20)primary key,
OrderAmount	decimal(10,3),
orderdate	 varchar(20),	 
Reg_id	 Numeric(18) ,
product_id Numeric(18),
foreign key(product_id)References Products(product_id)
)

drop table  Orders
select * from Orders

--------------------------------------------------
----------------------------------------------------
Create table Emi_Table(
emi_id	 Numeric(10),
emiAmount	decimal(10,3), 
emitype_id	 Numeric(20)primary key,	 
orderid	 Numeric(20),
reg_id Numeric(18),
foreign key(reg_id) References Registration(reg_id),
paymentid	Numeric(18),
foreign key(paymentid) References  Payments( paymentid)
)
drop table Emi_Table
select * from Emi_Table
-----------------------------------------------------
-------------------------------------------------------
Create table Emi_Type(
emiduration	varchar(30),
emitype_id	Numeric(20),
foreign key (emitype_id) References  Emi_Table(emitype_id)
)


drop table Emi_Type
select * from Emi_Type
----------------------------------------------------
-----------------------------------------------------
Create table Payments(
paymentid Numeric(18)primary key,
downpayment decimal(10,3),
remainingbalance decimal(10,2),
orderid Numeric(20),
--orderid varchar(20)foreign key(orderid)References Orders 
FOREIGN KEY(orderid) REFERENCES Orders(orderid)
);

drop table Payments
select *from Payments