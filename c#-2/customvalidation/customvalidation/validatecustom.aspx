<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validatecustom.aspx.cs" Inherits="customvalidation.validatecustom" %>

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
        </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametext" Display="Dynamic" ErrorMessage="Enter Your Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="mailtext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="mailtext" Display="Dynamic" ErrorMessage="Enter Your EmailID" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="mailtext" Display="Dynamic" ErrorMessage="Invalid EmailID" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Re-Enter Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="remailtext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="remailtext" Display="Dynamic" ErrorMessage="Re enter Your EmailID" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="mailtext" ControlToValidate="remailtext" Display="Dynamic" ErrorMessage="Mail not matched" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Class: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="clastext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="clastext" Display="Dynamic" ErrorMessage="Enter Your Class" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="clastext" Display="Dynamic" ErrorMessage="Range between 1-12" ForeColor="Red" MaximumValue="12"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Fees: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="feestext" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="feestext" Display="Dynamic" ErrorMessage="Enter Your Fees" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Gender: "></asp:Label>
                </td>
                <td>
                    <asp:RadioButton ID="Female" runat="server" GroupName="gender" Text="Female" />
                    <asp:RadioButton ID="Male" runat="server" GroupName="gender" Text="Male" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="select your Gender!!" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
