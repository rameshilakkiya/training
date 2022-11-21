<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstate.aspx.cs" Inherits="state_view.viewstate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 228px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">UserName:</td>
                <td>
                    <asp:TextBox ID="usertext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td>
                    <asp:TextBox ID="passtext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
                </td>
                <td>
                    <asp:Button ID="restore" runat="server" OnClick="restore_Click" Text="Restore" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
