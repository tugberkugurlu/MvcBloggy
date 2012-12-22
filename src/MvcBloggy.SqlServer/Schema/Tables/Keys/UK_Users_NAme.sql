ALTER TABLE [dbo].[Users]
	ADD CONSTRAINT [UK_Users_Name]
	UNIQUE (Name)
GO