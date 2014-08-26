CREATE DATABASE [BankDatabase]
GO

USE [BankDatabase]
GO

CREATE TABLE Persons(
	PersonID int PRIMARY KEY IDENTITY(1, 1),
	FirstName nvarchar(30),
	LastName nvarchar(30),
	SSN varchar(9)
)

CREATE TABLE Accounts(
	AccountID int PRIMARY KEY IDENTITY(1, 1),
	PersonID int FOREIGN KEY REFERENCES Persons(PersonID)
)

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES 
	('Kiril', 'Metodiev', 627158962),
	('Kaloqn', 'Iliev', 418754963),
	('Marin', 'Krasimirov', 357184698)

INSERT INTO Accounts(PersonID)
VALUES 
	(1),
	(2),
	(3)
GO

CREATE PROC dbo.usp_SelectPersonsFullnames
AS
	SELECT p.FirstName + ' ' + p.LastName AS [PersonsFullNames]
	FROM BankDatabase.dbo.Persons p
GO

EXEC dbo.usp_SelectPersonsFullnames

CREATE TABLE Logs(
	LogID int PRIMARY KEY IDENTITY(1, 1),
	AccountID int FOREIGN KEY REFERENCES Accounts(AccountID),
	OldSum money,
	NewSum money
)
GO

ALTER TABLE BankDatabase.dbo.Accounts
ADD Balance money
GO

CREATE PROC dbo.usp_WithdrawMoney(
	@accountID int,
	@money money,
	@result money OUTPUT
	)
AS
	Declare @currentBalance money
	SET @currentBalance = (
		SELECT a.Balance
		FROM dbo.Accounts a
		WHERE a.AccountID = @accountID
		)
	
	SET @result = @currentBalance - @money

	UPDATE dbo.Accounts
		SET Balance = @result
		WHERE Accounts.AccountID = @accountID
GO

CREATE TRIGGER tr_AccountsUpdate ON BankDatabase.dbo.Accounts FOR UPDATE
AS
	INSERT INTO Logs(OldSum, NewSum, AccountID)
	SELECT d.Balance, i.Balance
	FROM deleted AS d
		JOIN inserted AS i
		ON d.AccountID = i.AccountID
GO
DECLARE @answer money
EXEC dbo.usp_WithdrawMoney 4, 50, @answer OUTPUT
SELECT @answer