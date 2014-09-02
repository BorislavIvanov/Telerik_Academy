INSERT INTO Logs(LogDate, LogText) VALUES ('1990-01-01', 'Sample log ');

DECLARE @Counter int = 0
WHILE (SELECT COUNT(*) FROM Logs) < 1000000
BEGIN
  INSERT INTO Logs(LogDate, LogText)
  SELECT DATEADD(MONTH, @Counter + 3, LogDate), LogText + CONVERT(varchar, @Counter) FROM Logs
  SET @Counter = @Counter + 1
END

CHECKPOINT; DBCC DROPCLEANBUFFERS; 

SELECT LogText FROM Logs WHERE LogDate 
		BETWEEN CONVERT(datetime, '1990-01-01') AND CONVERT(datetime, '1995-01-01');