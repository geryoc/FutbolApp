
IF NOT EXISTS (SELECT 1 FROM dbo.Tournament)
BEGIN
    INSERT INTO dbo.Tournament ([Name], CountryId) VALUES ('Apertura Uruguay', 1);
    INSERT INTO dbo.Tournament ([Name], CountryId) VALUES ('Clausura Uruguay', 1);
END

