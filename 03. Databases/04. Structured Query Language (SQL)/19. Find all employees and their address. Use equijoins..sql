SELECT e.FirstName + ' ' + e.LastName AS [FullName], a.AddressText
FROM TelerikAcademy.dbo.Employees e, TelerikAcademy.dbo.Addresses a
WHERE e.AddressID = a.AddressID