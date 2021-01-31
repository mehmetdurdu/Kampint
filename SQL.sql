--Select
--ANSI
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products where CategoryID=1 order by UnitPrice desc   --ascending(asc) --descending(desc)

Select count(*) Adet from Products where CategoryID = 2

Select categoryID,count(*) UrunSayisi from Products where UnitPrice>20 group by CategoryID having count(*)<10   --Ürün sayısı 10 dan küçük olan kategorileri listele

Select Products.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od	--left joın sol tarafta olan ancak sağ tarafta bulunmayanları getir.
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o	--Sisteme kayıtlı ancak ürün siparişi oluşturmamış müşteriler.
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Orders o right join Customers c 	--right joın sağ tarafta olan ancak sol tarafta bulunmayanları getir.
on c.CustomerID = o.CustomerID
where o.CustomerID is null