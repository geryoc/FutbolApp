

IF NOT EXISTS (SELECT 1 FROM dbo.Country)
BEGIN
    INSERT INTO dbo.Country VALUES ('Uruguay');
    INSERT INTO dbo.Country VALUES ('Argentina');
    INSERT INTO dbo.Country VALUES ('Brasil');
    INSERT INTO dbo.Country VALUES ('Inglaterra');
END