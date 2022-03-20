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