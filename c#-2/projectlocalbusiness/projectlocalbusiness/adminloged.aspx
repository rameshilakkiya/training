<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminloged.aspx.cs" Inherits="projectlocalbusiness.adminloged" %>

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

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

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
