CREATE TABLE Groups(
	GroupID int PRIMARY KEY IDENTITY(1,1),
	GroupName varchar(40) UNIQUE NOT NULL
)