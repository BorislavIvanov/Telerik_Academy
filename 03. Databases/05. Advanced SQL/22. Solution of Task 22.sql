INSERT INTO Users(Username, [Password], Fullname, GroupID)
SELECT  LOWER(LEFT(FirstName,3)+LastName),
        LOWER(LEFT(FirstName,3)+LastName),
        FirstName+' ' + LastName,
        1
FROM Employees