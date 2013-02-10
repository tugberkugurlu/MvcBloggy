ALTER TABLE [dbo].[DynamicPages]  
	ADD  CONSTRAINT [FK_DynamicPages_Authors] 
	FOREIGN KEY([AuthorId])
	REFERENCES [dbo].[Authors] ([Id])
	ON DELETE CASCADE
GO

ALTER TABLE [dbo].[DynamicPages] CHECK CONSTRAINT [FK_DynamicPages_Authors] 
GO