SELECT MIN(e.Salary), d.Name, e.JobTitle, MIN(e.FirstName + ' ' + e.LastName) as [Full Name]
FROM TelerikAcademy.dbo.Employees e
INNER JOIN TelerikAcademy.dbo.Departments d
ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name