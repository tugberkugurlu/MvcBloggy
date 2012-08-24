CREATE FUNCTION [dbo].[UrlReplace] (
	@rawText VARCHAR(MAX)
) RETURNS VARCHAR(MAX)

AS

BEGIN
	DECLARE @outputedText AS NVARCHAR(MAX);		
	
	SET @outputedText = dbo.TRIM(LOWER(@rawText));
	SET @outputedText = REPLACE(@outputedText,' / ','-');
	SET @outputedText = REPLACE(@outputedText,' - ','-');
	SET @outputedText = REPLACE(@outputedText,'="','-');
	SET @outputedText = REPLACE(@outputedText,' = ','-');
	SET @outputedText = REPLACE(@outputedText,' " ','-');
	SET @outputedText = REPLACE(@outputedText,' "','-');
	SET @outputedText = REPLACE(@outputedText,'" ','-');
	SET @outputedText = REPLACE(@outputedText,' . ','-');
	SET @outputedText = REPLACE(@outputedText,' .','');
	SET @outputedText = REPLACE(@outputedText,'. ','-');
	SET @outputedText = REPLACE(@outputedText,' ? ','-');
	SET @outputedText = REPLACE(@outputedText,' ?','-');
	SET @outputedText = REPLACE(@outputedText,' ! ','-');
	SET @outputedText = REPLACE(@outputedText,'! ','-');
	SET @outputedText = REPLACE(@outputedText,' !','-');
	SET @outputedText = REPLACE(@outputedText,' | ','-');
	SET @outputedText = REPLACE(@outputedText,' |','');
	SET @outputedText = REPLACE(@outputedText,' > ','-');
	SET @outputedText = REPLACE(@outputedText,' >','');
	SET @outputedText = REPLACE(@outputedText,' < ','-');
	SET @outputedText = REPLACE(@outputedText,' <','-');
	
	
	SET @outputedText = REPLACE(@outputedText,' ','-');
	SET @outputedText = REPLACE(@outputedText,',','');
	SET @outputedText = REPLACE(@outputedText,'|','');
	SET @outputedText = REPLACE(@outputedText,'&&','');
	SET @outputedText = REPLACE(@outputedText,'&amp;','and');
	SET @outputedText = REPLACE(@outputedText,'&','and');
	SET @outputedText = REPLACE(@outputedText,'(','');
	SET @outputedText = REPLACE(@outputedText,')','');
	SET @outputedText = REPLACE(@outputedText,'!','');
	SET @outputedText = REPLACE(@outputedText,'''','-');
	SET @outputedText = REPLACE(@outputedText,'"','-');
	SET @outputedText = REPLACE(@outputedText,'/','-');
	SET @outputedText = REPLACE(@outputedText,':','-');
	SET @outputedText = REPLACE(@outputedText,'.','-');
	SET @outputedText = REPLACE(@outputedText,'c#','c-sharp');
	SET @outputedText = REPLACE(@outputedText,'#','sharp');
	SET @outputedText = REPLACE(@outputedText,'{','');
	SET @outputedText = REPLACE(@outputedText,'}','');
	SET @outputedText = REPLACE(@outputedText,'[','');
	SET @outputedText = REPLACE(@outputedText,']','');
	SET @outputedText = REPLACE(@outputedText,'?','');
	SET @outputedText = REPLACE(@outputedText,'*','');
	SET @outputedText = REPLACE(@outputedText,';','');
	
	SET @outputedText = REPLACE(@outputedText,'ı','i');
	SET @outputedText = REPLACE(@outputedText,'ü','u');
	SET @outputedText = REPLACE(@outputedText,'ö','o');
	SET @outputedText = REPLACE(@outputedText,'ğ','g');
	SET @outputedText = REPLACE(@outputedText,'ç','c');
	SET @outputedText = REPLACE(@outputedText,'ş','s');
	
	RETURN @outputedText;
END

GO