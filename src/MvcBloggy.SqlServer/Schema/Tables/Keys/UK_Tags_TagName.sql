ALTER TABLE [dbo].[Tags]
	ADD CONSTRAINT [UK_Tags_TagName]
	UNIQUE (TagName)
GO
