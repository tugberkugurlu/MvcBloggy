CREATE TABLE [dbo].[Languages] (
	
	[LanguageId] INT IDENTITY NOT NULL,
	[DisplayName] NVARCHAR (50) NULL,
	[Culture] NVARCHAR (10) NOT NULL,
	[CultureOne] NVARCHAR (10) NOT NULL,
	[Order] INT NULL,
	[IsApproved] BIT NULL,
	[CreatedOn] DATETIMEOFFSET NULL,
	CONSTRAINT [PK_Languages] PRIMARY KEY ([LanguageId])

)