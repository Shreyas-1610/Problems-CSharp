SELECT * FROM Users;

SELECT * FROM Users WHERE gender = 'Male';

SELECT carModel,COUNT (*)
FROM Users
WHERE state = 'FL'
GROUP BY carModel
	ORDER BY COUNT(*) DESC;


SELECT carModel,COUNT (*) AS carCount FROM Users WHERE state = 'CA' GROUP BY carModel HAVING COUNT(*) > 5 ORDER BY carCount DESC;

SELECT Name, carYear FROM Users ORDER BY Name, carYear OFFSET 10 ROWS;

SELECT Name, carYear FROM Users ORDER BY Name, carYear OFFSET 10 ROWS FETCH NEXT 10 ROWS ONLY;

SELECT Name, carYear FROM Users ORDER BY Name, carYear OFFSET 0 ROWS FETCH FIRST 10 ROWS ONLY;

SELECT DISTINCT TOP 5 carYear, carModel FROM Users ORDER BY carYear;

SELECT Name, state,carModel, carYear FROM Users WHERE carYear BETWEEN 2005 AND 2012 ORDER BY carYear;

SELECT Name, state,carModel, carYear FROM Users WHERE carYear NOT BETWEEN 2005 AND 2012 ORDER BY carYear;

SELECT id, Name, carModel FROM Users WHERE carModel LIKE 'C%';