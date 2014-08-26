CREATE TABLE UsersTowns (
        ID INT IDENTITY,
        FullName NVARCHAR(50),
        TownName NVARCHAR(50)
)
INSERT INTO UsersTowns
SELECT e.FirstName + ' ' + e.LastName, t.Name
                FROM Employees e
                        INNER JOIN Addresses a
                                ON a.AddressID = e.AddressID
                        INNER JOIN Towns t
                                ON t.TownID = a.TownID
                GROUP BY t.Name, e.FirstName, e.LastName
 
 
 
-- Nested cursors to fetch info
DECLARE @name NVARCHAR(50)
        DECLARE @town NVARCHAR(50)
 
        DECLARE empCursor1 CURSOR READ_ONLY FOR
                SELECT DISTINCT ut.TownName
                        FROM UsersTowns ut     
 
        OPEN empCursor1
        FETCH NEXT FROM empCursor1
                INTO @town
 
                WHILE @@FETCH_STATUS = 0
                BEGIN
                        PRINT @town
 
                        DECLARE empCursor2 CURSOR READ_ONLY FOR
                                SELECT ut.FullName
                                FROM UsersTowns ut
                                        WHERE ut.TownName = @town
                        OPEN empCursor2
                       
                        FETCH NEXT FROM empCursor2
                                INTO @name
                               
                                WHILE @@FETCH_STATUS = 0
                                BEGIN
                                        PRINT '   ' + @name
                                        FETCH NEXT FROM empCursor2 INTO @name
                                END
 
                                CLOSE empCursor2
                                DEALLOCATE empCursor2
                        FETCH NEXT FROM empCursor1 INTO @town
                END
 
        CLOSE empCursor1
        DEALLOCATE empCursor1