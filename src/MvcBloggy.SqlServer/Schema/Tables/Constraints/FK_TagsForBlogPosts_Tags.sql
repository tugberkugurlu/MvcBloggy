ALTER TABLE [dbo].[TagsForBlogPosts]
	ADD CONSTRAINT [FK_TagsForBlogPosts_Tags] 
	FOREIGN KEY([TagId])
	REFERENCES [dbo].[Tags] ([Id])
	--NOTE: Introducing FOREIGN KEY constraint 'FK_TagsForBlogPosts_Tags' on table 'TagsForBlogPosts' 
	--      may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION 
	--      or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
	--ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TagsForBlogPosts] CHECK CONSTRAINT [FK_TagsForBlogPosts_Tags]
GO