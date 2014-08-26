CREATE TABLE Users(
	UserID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Username nvarchar(20) UNIQUE NOT NULL,
	[Password] nvarchar(20) CHECK(LEN([Password]) > 4) NOT NULL,
	Fullname nvarchar(100) NOT NULL,
	LastLogin datetime
)