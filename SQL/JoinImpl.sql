use Practice;

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    City VARCHAR(50)
);

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50),
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
);

CREATE TABLE Mentors (
    MentorID INT PRIMARY KEY,
    MentorName VARCHAR(50),
    StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
);

INSERT INTO Students (StudentID, Name, Age, City) VALUES
(5, 'Eve', 21, 'New York'),       -- Same city as Alice
(6, 'Frank', 22, 'Los Angeles'),  -- Same city as Bob
(7, 'Grace', 23, 'Chicago'); 

INSERT INTO Courses (CourseID, CourseName, StudentID) VALUES
(101, 'Math', 1),
(102, 'Science', 2),
(103, 'History', 3);

INSERT INTO Mentors (MentorID, MentorName, StudentID) VALUES
(201, 'Dr. Smith', 1),
(202, 'Prof. Johnson', 2),
(203, 'Dr. Adams', 4);

SELECT S.StudentID, S.Name, C.CourseName
FROM Students S
LEFT JOIN Courses C ON S.StudentID = C.StudentID;

SELECT S.StudentID, S.Name, C.CourseName
FROM Students S
RIGHT JOIN Courses C ON S.StudentID = C.StudentID;

SELECT S.StudentID, S.Name, C.CourseName
FROM Students S
FULL OUTER JOIN Courses C ON S.StudentID = C.StudentID;

SELECT S1.Name AS Student1, S2.Name AS Student2, S1.City
FROM Students S1
JOIN Students S2 ON S1.City = S2.City AND S1.StudentID <> S2.StudentID;


