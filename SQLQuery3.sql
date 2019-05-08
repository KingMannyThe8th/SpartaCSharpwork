/*SUM*/
select * from products
select SUM(UnitPrice) from Products
/*AVG*/
select AVG(UnitPrice) from Products
/*MIN/MAX*/
select MIN(UnitPrice) from Products
select MAX(UnitPrice) from Products
/*COUNT*/
select COUNT(UnitsInStock) from Products 
/*GROUP BY*/
select COUNT(UnitsInStock), ProductID from Products group by UnitsInStock, ProductID
/*HAVING*/
SELECT ProductID,ProductName FROM Products GROUP BY  ProductName HAVING COUNT(ProductID) > 4 
 
/*INNER JOIN*/
select * from orders inner join Employees on orders.EmployeeID=Employees.EmployeeID;

