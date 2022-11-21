<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="RegistrationNLogin.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text="Login Page"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="UserName: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passtext" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="passtext" Display="Dynamic" ErrorMessage="Type Strong password[ex:paSs123]" ForeColor="#FF3300" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="Registration.aspx">Not Registered yet ? Click Here</a>
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Login" />
                </td>
            </tr>
        </table>
        <div>
            <a href="userDetail.aspx">Do You want to know registered usersdetails? Click Here</a>
        </div>
    </form>
</body>
</html>
