CREATE TABLE [dbo].[Order] (
    [Id_Order]        INT           IDENTITY (1, 1) NOT NULL,
    [RealNameManager] NVARCHAR (50) NULL,
    [DateInput]       DATETIME      NULL,
    [SummOrder]       INT           NULL,
    [Status]          BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id_Order] ASC)
);

