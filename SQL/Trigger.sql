use InSession;

CREATE TABLE Users(
UserId INT IDENTITY(1,1) PRIMARY KEY,
UserName VARCHAR(20) NOT NULL,
Email VARCHAR(30) UNIQUE NOT NULL,
Updated DATETIME NULL
);

CREATE TABLE UserLog(
LogId INT IDENTITY(1,1) PRIMARY KEY,
UserId INT NULL,
Type VARCHAR(10),
LogDate DATETIME DEFAULT GETDATE(),
FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE PROCEDURE procUsers
@UserName VARCHAR(20),
@Email VARCHAR(30)
AS
BEGIN
IF EXISTS (SELECT 1 FROM Users WHERE Email = @Email)
	BEGIN
		UPDATE Users
		SET UserName = @UserName,
		Updated = GETDATE()
		WHERE Email = @Email;
	END
ELSE
	BEGIN
		INSERT INTO Users(UserName, Email) VALUES
		(@UserName, @Email);
	END
END;

ALTER TRIGGER trgDeleteUsers
ON Users
AFTER DELETE
AS
BEGIN
	INSERT INTO UserLog(UserId, Type) 
	SELECT deleted.UserId, 'DELETED' from deleted;
END;


CREATE TRIGGER trgInsertUsers
ON Users
AFTER INSERT
AS
BEGIN
	INSERT INTO UserLog(UserId, Type)
	SELECT inserted.UserId, 'INSERT' FROM inserted;
END;

CREATE TRIGGER trgUpdateUsers
ON Users
AFTER UPDATE
AS
BEGIN
	INSERT INTO UserLog(UserId, Type)
	SELECT inserted.UserId, 'Update' FROM inserted;
END;

INSERT INTO Users (UserName, Email) 
VALUES 
('ABC', 'abc@example.com'),
('Shreyas', 'shreyas@example.com');

EXEC procUsers @UserName = 'Test3',
			   @Email = 'test2@gmail.com';

SELECT * FROM Users;
SELECT * FROM UserLog;

DELETE FROM Users WHERE Email='xyz@gmail.com';

ALTER TABLE UserLog DROP CONSTRAINT FK__UserLog__UserId__6383C8BA;