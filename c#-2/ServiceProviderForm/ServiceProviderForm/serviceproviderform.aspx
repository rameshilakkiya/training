<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceproviderform.aspx.cs" Inherits="ServiceProviderForm.serviceproviderform" StyleSheetTheme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            height: 53px;
        }
        .auto-style4 {
            height: 31px;
        }
        .auto-style6 {
            height: 50px;
            width: 134px;
        }
        .auto-style7 {
            height: 53px;
            width: 134px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div align = "center">
        </div>
        <table class="auto-style1" align = "center"  valign = "middle" border="1" style="border-top-style: solid; border-bottom-style: solid">
            <tr>
                <td class="auto-style4" align="center" valign="middle" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Service Provider Form"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="sernam" runat="server" Text="Name: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametext" Display="Dynamic" ErrorMessage="Name is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="seremail" runat="server" Text="Email: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="mailtext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="mailtext" Display="Dynamic" ErrorMessage="Email is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="mailtext" Display="Dynamic" ErrorMessage="Invalid EmailId" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="sermob" runat="server" Text="Mobile: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="phonetext" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phonetext" Display="Dynamic" ErrorMessage="MobileNo is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="phonetext" Display="Dynamic" ErrorMessage="Length Must be 10" ForeColor="#FF3300" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label5" runat="server" Text="ServiceType: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Electronics</asp:ListItem>
                        <asp:ListItem>Software</asp:ListItem>
                        <asp:ListItem>Electrical</asp:ListItem>
                        <asp:ListItem>Home Appliances</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Select Service Type" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label6" runat="server" Text="Address: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="addtext" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="addtext" Display="Dynamic" ErrorMessage="Address is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="Location: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>ShivajiNagar</asp:ListItem>
                        <asp:ListItem>Malliswaram</asp:ListItem>
                        <asp:ListItem>IndhiraNagar</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList2" Display="Dynamic" ErrorMessage="Select Your Location" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label8" runat="server" Text="City: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="citytext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="citytext" Display="Dynamic" ErrorMessage="City is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label9" runat="server" Text="Zip-Code: "></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="ziptext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ziptext" Display="Dynamic" ErrorMessage="Zip-Code is Mandatory" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="ziptext" Display="Dynamic" ErrorMessage="Length must be 6" ForeColor="#FF3300" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                </td>
            </tr>
        </table>
        <div align="right" valign = "middle">
            
            
            <a href="ServicesearchForm.aspx">-->Go for Search!!</a>
        </div>
    </form>
</body>
 
</html>
