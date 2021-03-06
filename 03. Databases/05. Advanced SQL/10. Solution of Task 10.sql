SELECT e.DepartmentID AS [Department ID], Count(*) AS [Employees Count], t.Name AS [Town Name]
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Addresses a
		ON e.AddressID = a.AddressID
	JOIN TelerikAcademy.dbo.Towns t
		ON a.TownID = t.TownID
GROUP BY e.DepartmentID, t.Name
ORDER BY e.DepartmentID