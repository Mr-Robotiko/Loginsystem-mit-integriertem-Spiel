CREATE TABLE [dbo].Nutzer
(
	[User_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Prename] NVARCHAR(50) NOT NULL, 
    [Birthday] DATE NOT NULL, 
    [Rights_Status] NCHAR(10) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL
)
