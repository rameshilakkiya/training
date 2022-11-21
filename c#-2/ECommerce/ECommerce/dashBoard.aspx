<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashBoard.aspx.cs" Inherits="ECommerce.dashBoard" %>

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
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Product" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log Out" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
