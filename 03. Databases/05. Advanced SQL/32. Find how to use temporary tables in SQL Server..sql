BEGIN TRAN
 
CREATE TABLE #EmployeesProjectsTemp(
        EmployeeID int NOT NULL,
        ProjectID int NOT NULL,
        PRIMARY KEY (EmployeeID, ProjectID)
)
 
GO
 
INSERT INTO #EmployeesProjectsTemp (EmployeeID, ProjectID)
SELECT EmployeeID, ProjectID FROM EmployeesProjects
 
SELECT * FROM #EmployeesProjectsTemp
 
DROP TABLE EmployeesProjects
 
GO
 
CREATE TABLE EmployeesProjects(
        EmployeeID int NOT NULL,
        ProjectID int NOT NULL,
        PRIMARY KEY (EmployeeID, ProjectID)
)
 
GO
 
INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
SELECT EmployeeID, ProjectID FROM #EmployeesProjectsTemp
 
SELECT EmployeeID, ProjectID FROM EmployeesProjects