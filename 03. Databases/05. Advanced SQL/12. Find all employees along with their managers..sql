SELECT e.FirstName + ' ' + e.LastName AS [Employees Full Name], ISNULL(m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager Full Name]
FROM TelerikAcademy.dbo.Employees e
	LEFT JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID