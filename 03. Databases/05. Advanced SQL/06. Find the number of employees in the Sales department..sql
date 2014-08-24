SELECT  d.Name AS [Department Name], Count(*) AS [Count Of Employees]
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
GROUP BY d.Name