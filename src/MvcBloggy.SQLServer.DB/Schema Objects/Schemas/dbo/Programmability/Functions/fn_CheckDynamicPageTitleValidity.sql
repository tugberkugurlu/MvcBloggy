CREATE FUNCTION [dbo].[fn$CheckDynamicPageTitleValidity] (
	@input NVARCHAR(500)
)
RETURNS INT
AS
BEGIN
	
	DECLARE @retrivedVal INT;

	SELECT 
		@retrivedVal = COUNT(rpn.RestrictedPageNameId) 
	FROM dbo.RestrictedPageNames rpn
	WHERE 
		dbo.UrlReplace(rpn.RestrictedPageTerm) = dbo.UrlReplace(@input);

	RETURN @retrivedVal;

END

GO