SELECT  JobTitle, DepartmentID, AVG(Salary) AS [Average Salary]
FROM TelerikAcademy.dbo.Employees e
GROUP BY e.DepartmentID, e.JobTitle