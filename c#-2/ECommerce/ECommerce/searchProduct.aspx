<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchProduct.aspx.cs" Inherits="ECommerce.searchProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .search{
            background-image: url('C:\Users\ilakkiya.r\Desktop\training\images\sear.jfif');
            background-repeat: no-repeat;
            padding-left: 20px;
            border:1px solid #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="&lt;--Back" />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Search Here" ></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="oo" CssClass="search"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="searchtext" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Search By Name</asp:ListItem>
                            <asp:ListItem>Search By Manufacturer</asp:ListItem>
                            <asp:ListItem>All Products</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
