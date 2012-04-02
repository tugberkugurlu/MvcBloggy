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
INSERT INTO Languages (DisplayName,LanguageCulture,LanguageCultureOne,LanguageOrder,IsApproved,CreatedOn)
VALUES('English', 'en-US', 'en', 1, 1, SYSDATETIMEOFFSET());
INSERT INTO Languages (DisplayName,LanguageCulture,LanguageCultureOne,LanguageOrder,IsApproved,CreatedOn)
VALUES('Türkçe', 'tr-TR', 'tr', 2, 1, SYSDATETIMEOFFSET());

INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1000, 'archive', SYSDATETIMEOFFSET());
INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1000, 'control', SYSDATETIMEOFFSET());
INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1000, 'contact', SYSDATETIMEOFFSET());

INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1001, 'archive', SYSDATETIMEOFFSET());
INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1001, 'control', SYSDATETIMEOFFSET());
INSERT INTO RestrictedPageNames (LanguageId, RestrictedPageTerm, CreatedOn)
VALUES(1001, 'contact', SYSDATETIMEOFFSET());