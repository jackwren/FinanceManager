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

DECLARE @username VARCHAR(50)
DECLARE @password VARCHAR(50)

SET @username = 'test'
SET @password = 'test'

IF NOT EXISTS(SELECT 1 FROM [dbo].[Users]
				WHERE username = 'test')
BEGIN
	INSERT INTO [dbo].[Users]([username], [password])
	SELECT @username, @password
END
ELSE 
BEGIN 
	PRINT 'No data to insert'
END
GO
