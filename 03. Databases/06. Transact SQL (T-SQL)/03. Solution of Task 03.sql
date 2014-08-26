CREATE PROC dbo.usp_CalcolateNewSum(
	@sum int = 0,
	@interest int = 0,
	@monthsN int = 0,
	@result int OUTPUT
)
AS
	SET @result = @sum + (@monthsN / 12) * ((@interest * @sum) / 100)
GO

DECLARE @answer int

EXEC dbo.usp_CalcolateNewSum 600, 19, 22, @answer OUTPUT

SELECT @answer