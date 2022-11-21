<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landing.aspx.cs" Inherits="projectlocalbusiness.landing" %>

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

        .images {
            display: flex;
            flex-wrap: wrap;
            margin: 0 50px;
            padding: 30px;
        }

        .photo {
            max-width: 31.333%;
            padding: 0 10px;
            height: 240px;
        }

            .photo img {
                width: 100%;
                height: 80%;
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

        .intro {
            color: blueviolet;
            font-size: 20px;
        }

        .log {
            height: 40px;
            border-radius: 60%;
        }

        @media only screen and (max-width:320px) {
            /* For tablets: */
            .images {
                width: 20%;
                padding: 0;
                
            }

            
        }

        @media only screen and (max-width:500px) {
            /* For mobile phones: */
             .images{
                width: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="topnav" style="font-style: italic; font-variant: small-caps">
            <img src="images/crop.png" class="log" alt="logo" />&nbsp;
                Lucky
            <a href="#about" class="split">Help</a>
            <a href="servicelogin.aspx" class="split">Service Provider</a>
            <a href="customer.aspx" class="split">Customer</a>
            <a href="adminlogin.aspx" class="split">Admin</a>
        </div>
        <div class="intro">
            <center>
                <p>We are waiting to serve you!!</p>
            </center>

        </div>
        <div class="images">
            <div class="photo">
                <img src="images/doctor.jfif" alt="photo" />
            </div>

            <div class="photo">
                <img src="images/cab.jpeg" alt="photo" />
            </div>

            <div class="photo">
                <img src="images/house.jfif" alt="photo" />

            </div>
            <div class="photo">
                <img src="images/hard.jfif" alt="photo" />

            </div>
            <div class="photo">
                <img src="images/mech.jfif" alt="photo" />
            </div>
            <div class="photo">
                <img src="images/plum.jfif" alt="photo" />
            </div>

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
