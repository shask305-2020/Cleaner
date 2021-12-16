CREATE TABLE [dbo].[Product]
(
	[Id_Product] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product] NVARCHAR(50) NOT NULL, 
    [Id_Category] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([Id_Category]) REFERENCES [Category]([Id_Category])
)
