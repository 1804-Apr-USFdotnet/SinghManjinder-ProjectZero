use PersonDB;
go

-- Show data within the database
select * from Contact.Person;

--create a new schema
create schema Product;

-- Create a new table called Products
create table Product.Products
(
	ID int primary key identity(1,1),
	[Name] nvarchar(50),
	[Price] int
);

--create a new table called Custmomers
create table Product.Customers
(
	ID int primary key identity(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50)
);

--create a new table called Orders
create table Product.Orders
(
	ID int primary key identity(1,1),
	ProductID int foreign key references Product.Products(ID),
	CustomerID int foreign key references Product.Customers(ID)
);


-- Insert 3 records in each table
-- Product.Products
insert into Product.Products([Name], Price) values('Briva', 1234);
insert into Product.Products([Name], Price) values('Mouse', 85);
insert into Product.Products([Name], Price) values('Monitor', 124);

-- Product.Customers
insert into Product.Customers(FirstName, LastName) values('Kyle', 'Ott');
insert into Product.Customers(FirstName, LastName) values('Hello', 'World');
insert into Product.Customers(FirstName, LastName) values('Richard', 'Quintia');

-- Product.Orders
insert into Product.Orders(ProductID, CustomerID) values(1, 3);
insert into Product.Orders(ProductID, CustomerID) values(2, 2);
insert into Product.Orders(ProductID, CustomerID) values(3, 1);

-- See all of the records in Product.Products
select * from Product.Products;

-- See all of the records in Product.Orders
select * from Product.Orders;

-- Add iphone to products
insert into Product.Products([Name], Price) values('iPhone', 200);

-- Add Tina Smith to Customers
insert into Product.Customers(FirstName, LastName) values('Tina', 'Smith');

-- Tina bought an iPhone
insert into Product.Orders(ProductID, CustomerID) values (4, 4);

select * from Product.Customers;
select * from Product.Products;
select * from Product.Orders;

select c.FirstName from Product.Customers c join (select p.[Name] from Product.Products p, Product.Orders o where o.ProductID = p.ID) as [Order];


update Product.Products
set Price = 250
where [Name] = 'iPhone';