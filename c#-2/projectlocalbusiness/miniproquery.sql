CREATE PROCEDURE [dbo].[Insert_User]
      @Username VARCHAR(50),
      @Email VARCHAR(100),
      @Mobile NVARCHAR(20),
      @City NVARCHAR(20),
      @Location NVARCHAR(50),
      @Address NVARCHAR(100),
      @Zip NVARCHAR(10),
      @Password NVARCHAR(20),
      @Roleid NVARCHAR(5)
AS
BEGIN
      SET NOCOUNT ON;
      IF EXISTS(SELECT Id FROM users1 WHERE name = @Username)
      BEGIN
            SELECT -1 -- Username exists.
      END
      ELSE IF EXISTS(SELECT Id FROM users1 WHERE email = @Email)
      BEGIN
            SELECT -2 -- Email exists.
      END
      
      ELSE
      BEGIN
            INSERT INTO [users1]
                     ([name]
                     ,[email]
                     ,[mobile]
                     ,[city]
                     ,[location]
                     ,[address]
                     ,[zipcode]
                     ,[password]
                     ,[roleid]
                     )
            VALUES
                     (@Username
                     ,@Email,
                     @Mobile,
                     @City,
                     @Location,
                     @Address,
                     @zip
                     ,@Password
                     ,@Roleid
                     )
           
            SELECT SCOPE_IDENTITY() -- UserId                 
     END
END