<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="providerloged.aspx.cs" Inherits="projectlocalbusiness.providerloged" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topnav" style="font-style: italic; font-variant: small-caps">
            <img src="images/crop.png" class="log" alt="logo" />&nbsp;
                Lucky
            
            <a href="landing.aspx" class="split">Logout</a>
            <a href="pro.aspx" class="split">Profile</a>
            <a href="services.aspx" class="split">Services</a>
            <a href="showsprovider.aspx" class="split">MyDetails</a>
            <a href="serviceprovider.aspx" class="split">ServiceProvider</a>
            
           
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td>Your Services:</td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                </tr>
                <tr>
                    <td>ServiceName:</td>
                    <td>
                        <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>AboutService:</td>
                    <td>
                        <asp:TextBox ID="destext" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
    <footer>
        <p>
            information on this website cannot be commercially used without the prior consent of Flatworld Solutions Pvt. Ltd.
        <a href="landing.aspx">Home</a>
        </p>
    </footer>
</body>
</html>
