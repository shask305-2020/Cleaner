CREATE TABLE [dbo].[Login]
(
	[Username] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NULL, 
    [Role] NVARCHAR(50) NULL, 
    [RealName] NVARCHAR(50) NULL
)
