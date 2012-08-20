CREATE FUNCTION [dbo].[fn$CheckDynamicPageTitleValidity] (
	@input NVARCHAR(500)
)
RETURNS INT
AS
BEGIN
	
	DECLARE @retrivedVal INT;

	SELECT 
		@retrivedVal = COUNT(rpn.[Key]) 
	FROM dbo.RestrictedPageNames rpn
	WHERE 
		dbo.UrlReplace(rpn.Term) = dbo.UrlReplace(@input);

	RETURN @retrivedVal;

END

GO