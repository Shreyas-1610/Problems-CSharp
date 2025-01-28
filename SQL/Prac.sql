CREATE DATABASE Practice;

USE Practice;

CREATE TABLE Prac(
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NAME VARCHAR(20) NOT NULL,
ADDRESS VARCHAR(20) NOT NULL,
AGE INT CHECK(AGE >= 18 AND AGE <=100));

INSERT INTO Prac( NAME, ADDRESS, AGE) 
VALUES('Shreyas','Pillai',21),
('Kulkarni','Dombivli',22);

SELECT * FROM Prac;

UPDATE Prac SET AGE = 19
WHERE NAME = 'Shreyas';

INSERT INTO Prac( NAME, ADDRESS, AGE) 
VALUES('ABC','Panvel',18);

DELETE FROM Prac WHERE Id = 3;

BEGIN TRANSACTION;
DELETE FROM Prac;
ROLLBACK;

CREATE TABLE Persons(
PersonId INT NOT NULL PRIMARY KEY,
LastName VARCHAR(20) NOT NULL,
FirstName VARCHAR(20) NOT NULL,
AGE INT NOT NULL);

INSERT INTO Persons( PersonId, LastName, FirstName, AGE) 
VALUES(1,'Kulkarni','Shreyas',21),
(2,'XYZ','ABC',22);

CREATE TABLE Orders(
OrderId INT NOT NULL PRIMARY KEY,
OrderNumber INT NOT NULL,
PersonId INT FOREIGN KEY REFERENCES Persons(PersonId));

INSERT INTO Orders( OrderId, OrderNumber, PersonId) 
VALUES(1,0021,1),
(2,0022,1),
(3,0023,2);

SELECT * FROM Orders;