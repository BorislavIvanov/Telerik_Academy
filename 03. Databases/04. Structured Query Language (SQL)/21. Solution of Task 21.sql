SELECT e.FirstName + ' ' + e.LastName AS [Employees e], 
		m.FirstName + ' ' + m.LastName AS [Employees m],
		 a.AddressText
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Employees m
		ON e.ManagerID = m.EmployeeID
	JOIN TelerikAcademy.dbo.Addresses a
		ON e.AddressID = a.AddressID