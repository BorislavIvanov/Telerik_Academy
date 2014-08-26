CREATE PROC [dbo].[usp_FindNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.FirstName AS [FIRST Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.FirstName,
                                        @lettersToSearch)
                                        )
        GO
 
--Procedure to search through Middle Names
CREATE PROC [dbo].[usp_FindMiddleNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.MiddleName AS [Middle Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.MiddleName,
                                        @lettersToSearch)
                                        )
        GO
 
--Procedure to search through Last Names
CREATE PROC [dbo].[usp_FindLastNames](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT e.LastName AS [LAST Names]
                        FROM Employees e
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        e.LastName,
                                        @lettersToSearch)
                                        )
        GO
 
 
--Procedure to search through Towns
CREATE PROC [dbo].[usp_FindTowns](
        @lettersToSearch NVARCHAR(50)
        )
        AS
                DECLARE @valid bit
                SET @valid = 0
                                       
                        SELECT t.Name AS [Towns]
                        FROM Towns t
                        WHERE
                                1 = (SELECT [dbo].[fn_NameContainingLetters](
                                        t.Name,
                                        @lettersToSearch)
               
 
-- The Function For Every String
CREATE FUNCTION [dbo].[fn_NameContainingLetters](
        @name NVARCHAR(50),
        @letters NVARCHAR(50)
        )
        RETURNS bit
AS
BEGIN
        DECLARE @contains bit
        SET @contains = 1
        DECLARE @curLetter NVARCHAR(1)
        DECLARE @counter INT
        SET @counter = 1
 
        WHILE(@counter <= LEN(@name))
                BEGIN
                SET @curLetter = SUBSTRING(@name, @counter, 1)
                IF (CHARINDEX(@curLetter, @letters) = 0)
                        SET @contains = 0
                SET @counter = @counter + 1
                END
        RETURN @contains
END
 
EXEC [dbo].[usp_FindNames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindMiddleames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindLastNames] @letterstosearch = 'oistmiahf'
EXEC [dbo].[usp_FindTowns] @letterstosearch = 'oistmiahf'