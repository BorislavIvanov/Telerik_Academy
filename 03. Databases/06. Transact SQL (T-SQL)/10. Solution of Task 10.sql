DECLARE @name nvarchar(MAX);
SET @name = N'';
SELECT @name+=e.FirstName+N','
FROM Employees e
SELECT LEFT(@name,LEN(@name)-1);