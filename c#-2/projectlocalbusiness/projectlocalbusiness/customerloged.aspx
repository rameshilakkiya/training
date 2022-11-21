<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerloged.aspx.cs" Inherits="projectlocalbusiness.customerloged" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .topnav {
            overflow: hidden;
            background-color: #333;
            color: white;
        }


            .topnav a {
                float: left;
                color: #f2f2f2;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                font-size: 17px;
            }

                .topnav a.split:hover {
                    background-color: #ddd;
                    color: black;
                }

                /* Create a right-aligned (split) link inside the navigation bar */
                .topnav a.split {
                    float: right;
                    background-color: gray;
                    color: white;
                }
                .log {
            height: 40px;
            border-radius: 60%;
        }
                footer {
            position: fixed;
            bottom: 0;
            width: 100%;
            text-align: center;
            padding: 3px;
            background-color: gray;
            color: white;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 188px;
        }
        .auto-style3 {
            width: 99px;
        }
        .auto-style4 {
            width: 407px;
        }
        .auto-style5 {
            width: 291px;
        }
        .auto-style6 {
            width: 101px;
        }
        .auto-style7 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topnav" style="font-style: italic; font-variant: small-caps">
            <img src="images/crop.png" class="log" alt="logo" />&nbsp;
                Lucky
            
            <a href="customer.aspx" class="split">Logout</a>
            <a href="myservices.aspx" class="split">My Services</a>
            <a href="customer.aspx" class="split">Profile</a>
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Services: </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Choose an Option</asp:ListItem>
                            <asp:ListItem>plumbing</asp:ListItem>
                            <asp:ListItem>electrician</asp:ListItem>
                            <asp:ListItem>doctor</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">Search By Name: </td>
                    <td>
                        <asp:TextBox ID="find" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>

        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7" TextMode="MultiLine" Visible="False"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" runat="server" Text="view" OnClick="Button2_Click1" />
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Book" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
    <footer>
        <p>
            information on this website cannot be commercially used without the prior consent of Flatworld Solutions Pvt. Ltd.
        <a href="#contact">Contact Us</a>
        </p>
    </footer>
</body>
</html>
