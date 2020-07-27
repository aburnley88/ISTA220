# Name: Arnold Burnley

## FileName: sqlhomework04

## Date: 22 July 2020


### TSQL Homework 04 Chapter 4, T-SQL Query Fundamentals Readings


**Read Chapter 4 in the T-SQL Query Fundamentals book.**

**Homework questions**

1. In your own words, what is a subquery?

A subquery is a nested query. The inner query is considered the subquery. 

2. In your own words, what is a self contained subquery?

A self contained sub query is one that is independent of the outer query but can still print output.

3. In your own words, what is a correlated subquery?

Correlated subqueries cannot be invoked independently because they are dependent on the outer query.

4. Give an example of a subquery that returns a single value. When would you use this kind of subquery?

select e.empid, e.firstname from hr.employees e 
where o.orderdate =
(Select max(orderdate) from sales.orders)
order by o.empid;

5. Give an example of a subquery that returns multiple values. When would you use this kind of subquery?

select  o.custid, o.orderid, o.orderdate, o.empid
	from sales.orders o where o.custid = 
(select top (1) custid from sales.orders group by custid order by count(orderid) desc);

6. Give an example of a subquery that returns table values. When would you use this kind of subquery?

select e.empid, e.firstname, e.lastname from HR.Employees e 
where e.empid not in
(select o.empid from Sales.Orders o where o.orderdate >= '2016-05-01');

In this example we're looking for employees that didnt have any sales this day. There could be some investigative purpose to this.

7. What does the exists predicate do? Give an example.

The predicate returns true if the subquery returns any rows and flase otherwise.

Select custid, companyname
from Sales.Customers AS C
Where country = N'Spain'


8. What happens if we use the not operator before a predicate? Give an example.

Select custid, companyname
From Sales.Customers
where custid Not IN(select o.custid
					from Sales.Orders As O);
Not in searches where attributes are not.


