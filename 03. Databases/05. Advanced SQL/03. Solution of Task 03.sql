SELECT FirstName + ' ' + LastName AS [FullNames], Salary, DepartmentID
FROM TelerikAcademy.dbo.Employees e
WHERE Salary <=
	(SELECT MIN(Salary) 
	 FROM TelerikAcademy.dbo.Employees
	 WHERE DepartmentID = e.DepartmentID)