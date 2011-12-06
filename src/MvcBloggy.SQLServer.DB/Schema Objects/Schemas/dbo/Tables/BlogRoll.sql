CREATE TABLE [dbo].[BlogRolls] (

	[BlogRollID] INT IDENTITY(1000,1) NOT NULL,
	[LanguageID] INT NOT NULL,
	[BlogName] NVARCHAR(300) NULL,
	[BlogAuthor] NVARCHAR(100)  NULL,
	[BlogURL] NVARCHAR(300) NULL,
	[Order] INT NULL,
	[IsApproved] BIT NOT NULL,
	CONSTRAINT [PK_BlogRolls] PRIMARY KEY CLUSTERED (
		[BlogRollID] ASC
	) ON [PRIMARY]

) ON [PRIMARY]

GO