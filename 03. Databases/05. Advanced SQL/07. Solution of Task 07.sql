SELECT Count(*) AS [Count Of Employees With Manager]
FROM TelerikAcademy.dbo.Employees e
WHERE e.ManagerID IS NOT NULL