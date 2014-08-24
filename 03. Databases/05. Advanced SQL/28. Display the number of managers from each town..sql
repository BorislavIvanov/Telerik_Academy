SELECT t.Name, COUNT(e.ManagerID) AS [Count of Managers]
FROM TelerikAcademy.dbo.Employees e
	INNER JOIN TelerikAcademy.dbo.Addresses a
	ON e.AddressID = a.AddressID
	INNER JOIN TelerikAcademy.dbo.Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name, e.ManagerID
ORDER BY [Count of Managers] DESC