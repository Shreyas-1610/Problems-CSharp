CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    ManagerID INT NULL
);

CREATE NONCLUSTERED INDEX IX_Employee_Name  
ON Employees(Name);

CREATE UNIQUE INDEX IX_Employee_Salary  
ON Employees(Salary);

CREATE NONCLUSTERED INDEX IX_Employee_Name_Department  
ON Employees(Name, Department);


INSERT INTO Employees (Name, Department, Salary, ManagerID)
VALUES 
    ('Alice', 'HR', 60000, NULL),
    ('Bob', 'IT', 75000, 1),
    ('Charlie', 'Finance', 70000, 1),
    ('David', 'IT', 80000, 2),
    ('Eve', 'Finance', 72000, 3),
    ('Frank', 'IT', 85000, 2);

WITH HighSalaryEmployees AS (
    SELECT EmployeeID, Name, Department, Salary
    FROM Employees
    WHERE Salary > 70000
)
SELECT * FROM HighSalaryEmployees;

WITH EmployeeHierarchy AS (
    SELECT EmployeeID, Name, ManagerID, 1 AS Level
    FROM Employees
    WHERE ManagerID IS NULL 

    UNION ALL

    SELECT e.EmployeeID, e.Name, e.ManagerID, eh.Level + 1
    FROM Employees e
    INNER JOIN EmployeeHierarchy eh ON e.ManagerID = eh.EmployeeID
)
SELECT * FROM EmployeeHierarchy ORDER BY Level;

WITH DeptSalary AS (
    SELECT Department, SUM(Salary) AS TotalSalary
    FROM Employees
    GROUP BY Department
)
SELECT * FROM DeptSalary;

WITH MaxSalaries AS (
    SELECT Department, MAX(Salary) AS MaxSalary
    FROM Employees
    GROUP BY Department
)
SELECT e.*
FROM Employees e
JOIN MaxSalaries m ON e.Department = m.Department AND e.Salary = m.MaxSalary;

WITH NoManager AS (
    SELECT EmployeeID, Name, Department, Salary
    FROM Employees
    WHERE ManagerID IS NULL
)
SELECT * FROM NoManager;

WITH ManagerEmployees AS (
    SELECT EmployeeID, Name, Department, Salary
    FROM Employees
    WHERE ManagerID = 2
)
SELECT * FROM ManagerEmployees;

WITH DeptCount AS (
    SELECT Department, COUNT(*) AS EmployeeCount
    FROM Employees
    GROUP BY Department
)
SELECT * FROM DeptCount WHERE EmployeeCount > 1;
