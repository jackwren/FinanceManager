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