ALTER TABLE [dbo].[Authors]  
	ADD  CONSTRAINT [FK_Authors_Users] 
	FOREIGN KEY([Id])
	REFERENCES [dbo].[Users] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Authors] CHECK CONSTRAINT [FK_Authors_Users]
GO