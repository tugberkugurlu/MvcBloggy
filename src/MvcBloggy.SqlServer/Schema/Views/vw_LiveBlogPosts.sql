CREATE VIEW [dbo].[vw$LiveBlogPosts]
	AS

	SELECT 
		bp.BlogPostId, 
		bp.LanguageId,
		bp.SecondaryId,
		bp.Title,
		bp.BriefInfo,
		bp.Content,
		bp.ImagePath,
		dbo.UrlReplace(bp.Title) AS URLString,
		bp.CreationIp,
		bp.CreatedOn,
		bp.LastUpdatedOn,
		lang.DisplayName,
		lang.Culture,
		lang.CultureOne
	FROM dbo.BlogPosts bp
	INNER JOIN Languages lang ON bp.LanguageId = lang.LanguageId
	WHERE (lang.IsApproved = 1) 
		AND (bp.IsApproved = 1);