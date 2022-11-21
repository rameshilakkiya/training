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
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametext" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="nametext" Display="Dynamic" ErrorMessage="Enter Your Name" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="emailid" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailid" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="emailid" Display="Dynamic" ErrorMessage="Enter Your EmailId" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailid" Display="Dynamic" ErrorMessage="Invalid EmailId" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Mobile:"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobile" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="mobile" Display="Dynamic" ErrorMessage="Enter Your MobileNo" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mobile" Display="Dynamic" ErrorMessage="Length Must be 10" ForeColor="#FF3300" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Address: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="address" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="address" Display="Dynamic" ErrorMessage="Enter Your Address" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Location: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="locc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="locc" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="locc" Display="Dynamic" ErrorMessage="Enter Your Location" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Password: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="passtext" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="passtext" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="passtext" Display="Dynamic" ErrorMessage="Enter Your Password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="passtext" Display="Dynamic" ErrorMessage="Invalid password[Ex:Pass1234]" ForeColor="Red" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Zipcode: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="zip" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="zip" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="zip" Display="Dynamic" ErrorMessage="Enter Your Zipcode" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="zip" Display="Dynamic" ErrorMessage="Valid code" ForeColor="#FF3300" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
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
