SELECT e.FirstName + ' ' + e.LastName AS [FullName], a.AddressText
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID