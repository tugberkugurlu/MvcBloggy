ALTER TABLE [dbo].[TagsForDynamicPages]
	ADD CONSTRAINT [FK_TagsForDynamicPages_Tags] 
	FOREIGN KEY([TagId])
	REFERENCES [dbo].[Tags] ([Id])
	--NOTE: Specify ON DELETE NO ACTION 
	--      or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
	--ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForDynamicPages] CHECK CONSTRAINT [FK_TagsForDynamicPages_Tags]
GO