Create Procedure spAuthenticateUser
@UserName nvarchar(100),
@Password nvarchar(100)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(name) from users1
 where [name] = @UserName and [password] = @Password
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End