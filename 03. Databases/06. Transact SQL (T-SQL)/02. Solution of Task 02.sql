CREATE PROC dbo.usp_UsersWithMoreMoneyThan(@lowerLimitOfMoney int >= 0)
AS
	SELECT FirstName + ' ' + LastName AS [FullPersonName]
	FROM dbo.Persons p
		INNER JOIN dbo.Accounts a
		ON p.PersonID = a.PersonID
	WHERE a.Salary >= @lowerLimitOfMoney
GO

EXEC dbo.usp_UsersWithMoreMoneyThan 650