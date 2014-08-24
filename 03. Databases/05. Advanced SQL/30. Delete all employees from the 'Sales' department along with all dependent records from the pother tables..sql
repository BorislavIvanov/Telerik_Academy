USE TelerikAcademy
GO
 
BEGIN TRAN DeleteEmployees
 
DECLARE @id int, @managerId int
SET @id = (SELECT DepartmentID FROM Departments
WHERE Name = 'Sales')
SET @managerId = (SELECT ManagerID
FROM Departments WHERE DepartmentID = @id)
 
DELETE FROM Employees
WHERE DepartmentID = @id AND EmployeeID != @managerId
 
ROLLBACK TRAN DeleteEmployees