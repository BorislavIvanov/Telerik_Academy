SELECT FirstName + ' ' + LastName AS [FullNames], Salary
FROM TelerikAcademy.dbo.Employees
WHERE Salary <=
	(SELECT MIN(Salary) FROM TelerikAcademy.dbo.Employees) * 1.1