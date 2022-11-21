<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="ECommerce.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            height: 49px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Registeration Page"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="emailid" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Mobile:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Address: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="address" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Location: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="locc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="passtext" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Zipcode: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="zip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Button ID="submit" runat="server" OnClick="Submit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
