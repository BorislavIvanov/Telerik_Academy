SELECT e.FirstName, e.LastName, e.EmployeeID
FROM TelerikAcademy.dbo.Employees e
WHERE 5 = (SELECT COUNT(*)
		   FROM TelerikAcademy.dbo.Employees
		   WHERE ManagerID = e.EmployeeID)