SELECT e.DepartmentID AS [Department ID], AVG(e.Salary) AS [Average Salary]
FROM TelerikAcademy.dbo.Employees e
GROUP BY e.DepartmentID