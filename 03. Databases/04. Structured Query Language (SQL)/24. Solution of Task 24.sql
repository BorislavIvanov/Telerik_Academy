SELECT FirstName + ' ' + LastName AS [Full Employee Name]
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND (YEAR(e.HireDate) > 1995 AND YEAR(e.HireDate) < 2005)