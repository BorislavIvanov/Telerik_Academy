CREATE INDEX IDX_OnLogsDateColumn ON Logs(LogDate);

--Empty the SQL Server cache
CHECKPOINT; DBCC DROPCLEANBUFFERS; 

--Test search by date after adding index
SELECT LogText FROM Logs WHERE LogDate 
		BETWEEN CONVERT(datetime, '2013-07-19 11:59:21') AND CONVERT(datetime, '2013-07-19 11:59:25');