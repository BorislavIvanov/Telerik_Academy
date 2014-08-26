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