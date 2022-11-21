CREATE PROCEDURE [dbo].[Validate_User]
      @Username NVARCHAR(20),
      @Password NVARCHAR(20)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @UserId INT, @LastLogin DATETIME, @RoleId INT
     
      SELECT @UserId = Id,@LastLogin=lastlogin, @RoleId = roleid
      FROM users1 WHERE name = @Username AND [password] = @Password
     
      IF @UserId IS NOT NULL
      BEGIN
            IF NOT EXISTS(SELECT Id FROM UserActivation WHERE Id = @UserId)
            BEGIN
                  UPDATE users1 set lastlogin=GETDATE()

                 WHERE Id=@UserId
                  SELECT @UserId [Id]
                               -- User Valid
            END
            ELSE
            BEGIN
                  SELECT -2  -- User not activated.
            END
      END
      ELSE
      BEGIN
            SELECT -1   -- User invalid.
      END
END