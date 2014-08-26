CREATE VIEW RecentUsers
AS
        SELECT Username, DAY(GETDATE() - LastLogin) AS DayDifference
        FROM Users
        WHERE DAY(GETDATE() - LastLogin) = 1