<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="security1.aspx.cs" Inherits="formbasesecurity.security1" %>

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
                <td>
                    <asp:Label ID="Label1" runat="server" Text="UserName: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passtext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Register Me" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td><a href="Registration/registration.aspx">Registration</a></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
            
        </div>
    </form>
</body>
</html>
