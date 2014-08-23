SELECT e.FirstName + ' ' + e.LastName AS [FullEmployeNames], 
		m.FirstName + ' ' + m.LastName AS [FullManagerNames]
FROM TelerikAcademy.dbo.Employees e
	LEFT JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID