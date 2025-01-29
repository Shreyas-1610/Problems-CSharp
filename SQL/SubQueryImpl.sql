USE shreyasdb;
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    City VARCHAR(50)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderAmount DECIMAL(10,2),
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY,
    CustomerID INT,
    PaymentAmount DECIMAL(10,2),
    PaymentDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Customers (CustomerID, CustomerName, City) VALUES
(1, 'John Doe', 'New York'),
(2, 'Jane Smith', 'Los Angeles'),
(3, 'Mike Johnson', 'Chicago'),
(4, 'Emily Davis', 'Houston');

INSERT INTO Orders (OrderID, CustomerID, OrderAmount, OrderDate) VALUES
(101, 1, 500.00, '2024-01-10'),
(102, 2, 750.00, '2024-01-12'),
(103, 3, 300.00, '2024-01-15'),
(104, 1, 900.00, '2024-01-18');

INSERT INTO Payments (PaymentID, CustomerID, PaymentAmount, PaymentDate) VALUES
(201, 1, 400.00, '2024-01-12'),
(202, 2, 500.00, '2024-01-14'),
(203, 3, 300.00, '2024-01-16'),
(204, 1, 800.00, '2024-01-20');

SELECT CustomerName FROM Customers WHERE CustomerID IN (SELECT CustomerID FROM Orders WHERE OrderAmount > 700);

SELECT CustomerID, (SELECT SUM(OrderAmount) FROM Orders O WHERE O.CustomerID = C.CustomerID) AS TotalOrders FROM Customers C;

SELECT CustomerID, AVG(OrderAmount) AS AvgOrderAmount FROM (SELECT CustomerID, OrderAmount FROM Orders) AS OrderSummary GROUP BY CustomerID;

SELECT C.CustomerID, C.CustomerName
FROM Customers C WHERE (SELECT SUM(PaymentAmount) FROM Payments P WHERE P.CustomerID = C.CustomerID) = 
(SELECT SUM(OrderAmount) FROM Orders O WHERE O.CustomerID = C.CustomerID);

SELECT CustomerName FROM Customers C WHERE EXISTS (SELECT 1 FROM Orders O WHERE O.CustomerID = C.CustomerID);

SELECT CustomerName FROM Customers C WHERE NOT EXISTS (SELECT 1 FROM Orders O WHERE O.CustomerID = C.CustomerID);



