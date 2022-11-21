<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="RegistrationNLogin.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Registration"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametext" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Enter Your Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailtextbox" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Enter Your Name"></asp:RequiredFieldValidator>

                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtextbox" Display="Dynamic" ErrorMessage="Invalid EmailID" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Mobile: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="mobiletext" runat="server" MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobiletext" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Enter Your Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Password: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="passtextbox" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="passtextbox" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Enter Your Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Confirm Password: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="confirmtext" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confirmtext" Display="Dynamic" ErrorMessage="*" ForeColor="#FF3300" ToolTip="Enter Your Name"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passtextbox" ControlToValidate="confirmtext" Display="Dynamic" ErrorMessage="Confirm password is not match with password" ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
