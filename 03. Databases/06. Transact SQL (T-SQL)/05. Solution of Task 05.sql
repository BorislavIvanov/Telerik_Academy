CREATE PROC dbo.usp_WithdrawMoney(
	@accountID int,
	@money money,
	@result money OUTPUT
	)
AS
	Declare @currentBalance money
	SET @currentBalance = (
		SELECT a.Balance
		FROM dbo.Accounts a
		WHERE a.AccountID = @accountID
		)
	
	SET @result = @currentBalance - @money

	UPDATE dbo.Accounts
		SET Balance = @result
		WHERE Accounts.AccountID = @accountID
GO

DECLARE @answer money
EXEC usp_WithdrawMoney 1, 50, @answer OUTPUT
SELECT @answer

////////////////////////////////////////////

CREATE PROC dbo.usp_DepositMoney(
	@accountID int,
	@money money,
	@result money OUTPUT
	)
AS
	Declare @currentBalance money
	SET @currentBalance = (
		SELECT a.Balance
		FROM dbo.Accounts a
		WHERE a.AccountID = @accountID
		)
	
	SET @result = @currentBalance + @money

	UPDATE dbo.Accounts
		SET Balance = @result
		WHERE Accounts.AccountID = @accountID
GO

DECLARE @answer money
EXEC usp_DepositMoney 1, 50, @answer OUTPUT
SELECT @answer