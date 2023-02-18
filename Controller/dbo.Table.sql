CREATE TABLE [dbo].Login
(
	[UserID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(50) NOT NULL, 
    [Password] NCHAR(50) NOT NULL
)
