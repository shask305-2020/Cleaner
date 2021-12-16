CREATE TABLE [dbo].[Service] (
    [Id_Service] INT           IDENTITY (1, 1) NOT NULL,
    [Service]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Service] ASC)
);

