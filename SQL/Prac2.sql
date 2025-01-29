use Practice;
SELECT * FROM Persons;
SELECT * FROM Orders;

SELECT COUNT(*) FROM Persons UNION SELECT COUNT(*)FROM Orders;

SELECT PersonId FROM Persons INTERSECT SELECT PersonId FROM Orders;