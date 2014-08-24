UPDATE Users
SET [Password] = NULL
FROM Users
WHERE LastLogin < CONVERT(datetime, '10-03-2010')
	AND [Password] IS NOT NULL