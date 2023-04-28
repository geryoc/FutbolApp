CREATE TABLE [dbo].[Tournament] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (500) NOT NULL,
    [CountryId] BIGINT        NULL,
    CONSTRAINT [PK_Tournament] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tournament_Country_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] ([Id])
);

