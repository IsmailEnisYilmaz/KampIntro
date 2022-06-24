--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive//büyük küçük harfe duyarsız
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10

select * from Products order by UnitPrice asc --ascending//artan--default'u
select * from Products where CategoryID=1 order by UnitPrice desc --descending//azalan

select count(*) Adet from Products where CategoryID=2


select categoryID,count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--inner join eşleşen kayıtları bir araya getirir.

--DTO//Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID


Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

--6.GunOdev
Select p.ProductName  UrunAdi, sum(od.UnitPrice * od.Quantity) KazanilanToplamMiktar from
[Order Details] od inner join Products p 
on od.ProductID = p.ProductID
inner join Orders o 
on o.OrderID = od.OrderID
group by p.ProductName