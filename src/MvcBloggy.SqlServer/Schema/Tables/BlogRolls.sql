CREATE TABLE [dbo].[BlogRolls] (

	[BlogRollId] INT IDENTITY NOT NULL,
	[LanguageId] INT NOT NULL,
	[BlogName] NVARCHAR(300) NOT NULL,
	[BlogAuthor] NVARCHAR(100) NULL,
	[BlogUrl] NVARCHAR(300) NOT NULL,
	[FeedUrl] NVARCHAR(300) NULL,
	[Order] INT NULL,
	[IsApproved] BIT NOT NULL,
	CONSTRAINT [PK_BlogRolls] PRIMARY KEY ([BlogRollId])

)