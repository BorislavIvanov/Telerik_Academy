SELECT e.FirstName + ' ' + e.LastName AS [EmployeeFullName], 
		m.FirstName + ' ' + m.LastName AS [ManagerFullName]
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Employees m
		ON e.ManagerID = m.EmployeeID