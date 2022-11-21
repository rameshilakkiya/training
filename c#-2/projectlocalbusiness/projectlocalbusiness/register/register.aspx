<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="projectlocalbusiness.serviceloginaspx" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <style>
        .auto-style1 {
            width: 100%;
        }

        .main {
            background-color:gray ;
            display: flex;
            justify-content: center;
            align-items: center;
            flex-direction: column;
            font-family: 'Montserrat', sans-serif;
            height: 100vh;
            margin: -20px 0 50px;
            overflow: hidden;
            display: flex;
            border:2px solid gray;
        }
        .auto-style2 {
            width: 296px;
            height: 78px;
        }
    </style>
</head>
<body>


    <div class="main">
        <form id="form1" runat="server">

            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="nametext" runat="server" placeholder="Enter Your Name"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="emailtext" runat="server" placeholder="Enter Your EmailID"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="mobiletext" runat="server" placeholder="Enter Your PhoneNo"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="citytext" runat="server" placeholder="Enter Your City"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="loctext" runat="server" placeholder="Enter Your Location"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="addtext" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="ziptext" runat="server" placeholder="Enter Your Zipcode"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="passtext" runat="server" placeholder="Enter Your Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:TextBox ID="repasstext" runat="server" placeholder="Confirm Your Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="3">As a Customer</asp:ListItem>
                            <asp:ListItem Value="2">As a ServiceProvider</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                    </td>
                </tr>
                
            </table>
            <a href="../servicelogin.aspx">
                    already registered click here!!
                </a>

        </form>
    </div>

</body>
</html>
