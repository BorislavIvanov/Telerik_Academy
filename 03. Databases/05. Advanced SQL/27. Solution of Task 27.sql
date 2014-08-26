SELECT TOP(1) t.Name, COUNT(e.EmployeeID) AS WorkingEmployees
FROM TelerikAcademy.dbo.Employees e
	INNER JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID
	INNER JOIN TelerikAcademy.dbo.Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY WorkingEmployees DESC