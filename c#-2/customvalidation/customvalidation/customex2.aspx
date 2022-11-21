<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customex2.aspx.cs" Inherits="customvalidation.customex2" %>

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
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Enter Even Number: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="numtext" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="numtext" Display="Dynamic" ErrorMessage="Enter number" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="numtext" Display="Dynamic" ErrorMessage="Not even Number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
