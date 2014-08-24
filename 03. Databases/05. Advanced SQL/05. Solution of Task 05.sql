SELECT AVG(Salary)
FROM TelerikAcademy.dbo.Employees e
	JOIN TelerikAcademy.dbo.Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'