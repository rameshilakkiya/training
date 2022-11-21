<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="ECommerce.products" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Products"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Code: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="codtext" runat="server"></asp:TextBox>
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
                    <asp:Label ID="Label3" runat="server" Text="Description: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="descrip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Manufacturer: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="manu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Price: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="pri" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
