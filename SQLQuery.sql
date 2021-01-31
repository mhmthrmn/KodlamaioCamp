--ANSI
SELECT * FROM Customers
SELECT ContactName,CompanyName,City FROM Customers
SELECT ContactName Adi,CompanyName SirketAdi,City Sehir FROM Customers
--case insensitive
Select * From Customers Where City='Berlin'
Select * From Products Where CategoryID=1 or CategoryID=3
Select * From Products Where CategoryID=1 and UnitPrice>=10
Select * From Products Order By CategoryID,ProductName
Select * From Products Order By UnitPrice asc --ascending |asc yazmasanda olur.
Select * From Products Where CategoryID=1 Order By UnitPrice desc
Select count(*) Adet from Products where CategoryID=2  -- products tüm satırları say
Select CategoryID,count(*) From Products where UnitPrice>20 group by CategoryID having count(*)<10 --önce where çalışır.Unitprice 20 büyük olan ürünleri categoryid göre grupla grupta sayıısı 10 az ollanları
Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName From Products inner join Categories on Products.CategoryID=Categories.CategoryID Where Products.UnitPrice>10
-- unitprice 10 dan büyük olanlar için kategorilerle join et ve seçtiğim kategori ismiyle getir
--DTO | Data Transformation Object

Select * From Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID=od.OrderID
                                  --tablo adı ayrı olduğu için köşeli parentez içine alınır.
Select * From Customers c left join Orders o on c.CustomerID=o.CustomerID Where o.CustomerID is null

Select * From Orders o right join Customers c on c.CustomerID=o.CustomerID Where o.CustomerID is null