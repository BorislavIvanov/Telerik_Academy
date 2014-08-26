CREATE PROC dbo.usp_GiveInterest (
        @id INT = 4,
        @interest INT,
        @RESULT money OUTPUT
        )
 
        AS
 
        DECLARE @sumz money
        SET @sumz = (SELECT a.Balance
                        FROM dbo.Accounts a
                                INNER JOIN dbo.Persons p
                                ON p.PersonID = a.PersonID
                                        AND p.PersonID = @id)
   
        EXEC dbo.usp_CalcolateNewSum
                @sumz,
                @interest,
                24,
                @RESULT OUTPUT         
        GO
       
DECLARE @final money
EXEC usp_GiveInterest 1, 10, @final OUTPUT
SELECT @final