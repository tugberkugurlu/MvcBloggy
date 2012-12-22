/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DECLARE @languagesCount AS INT;
SELECT @languagesCount = COUNT(*) FROM Languages;

IF @languagesCount <= 0
BEGIN

	INSERT INTO Languages (DisplayName, Culture, CultureOne, [Order], IsApproved, CreatedOn)
	VALUES('English', 'en-US', 'en', 1, 1, SYSDATETIMEOFFSET());
	INSERT INTO Languages (DisplayName, Culture, CultureOne, [Order], IsApproved, CreatedOn)
	VALUES('Türkçe', 'tr-TR', 'tr', 2, 1, SYSDATETIMEOFFSET());

	DECLARE @enLangId AS UNIQUEIDENTIFIER;
	DECLARE @trLangId AS UNIQUEIDENTIFIER;

	SELECT @enLangId = lng.[Key] FROM Languages lng WHERE lng.CultureOne = 'en';
	SELECT @trLangId = lng.[Key] FROM Languages lng WHERE lng.CultureOne = 'tr';

	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@enLangId, 'archive', SYSDATETIMEOFFSET());
	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@enLangId, 'control', SYSDATETIMEOFFSET());
	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@enLangId, 'contact', SYSDATETIMEOFFSET());

	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@trLangId, 'archive', SYSDATETIMEOFFSET());
	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@trLangId, 'control', SYSDATETIMEOFFSET());
	INSERT INTO RestrictedPageNames (LanguageKey, Term, CreatedOn)
	VALUES(@trLangId, 'contact', SYSDATETIMEOFFSET());

END