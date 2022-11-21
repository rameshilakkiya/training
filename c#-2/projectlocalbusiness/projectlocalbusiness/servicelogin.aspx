<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servicelogin.aspx.cs" Inherits="projectlocalbusiness.servicelogin" %>

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
            height:auto;
            text-align: center;
            padding: 3px;
            background-color: gray;
            color: white;
              z-index: 1;

            
        }

        /*.sty {
            border: 1px solid #c4c4c4;
            padding: 2px 2px 2px 2px;
            border-radius: 4px;
            box-shadow: 0px 0px 8px #d9d9d9;
            background-color: #F0F0FF;
        }*/

            /*.sty:focus {
                outline: none;
                border: 1px solid #7bc1f7;
                box-shadow: 0px 0px 8px #7bc1f7;
                background-color: #FFF2FF;
            }*/

        

        

        /*iuoioiuo*/
        @import url('https://fonts.googleapis.com/css?family=Montserrat:400,800');

* {
	box-sizing: border-box;
}

.main {
	background: #f3e0e2;
	display: flex;
	justify-content: center;
	align-items: center;
	flex-direction: column;
	font-family: 'Montserrat', sans-serif;
	height: 100vh;
	margin: -20px 0 50px;
    overflow:hidden;
    display:flex;
}

h1 {
	font-weight: bold;
	margin: 0;
}

p {
	font-size: 14px;
	font-weight: 100;
	line-height: 20px;
	letter-spacing: 0.5px;
	margin: 20px 0 30px;
}

span {
	font-size: 12px;
}

a {
	color: #333;
	font-size: 14px;
	text-decoration: none;
	margin: 15px 0;
}

button {
	border-radius: 20px;
	border: 1px solid #FF4B2B;
	background-color: #FF4B2B;
	color: #FFFFFF;
	font-size: 12px;
	font-weight: bold;
	padding: 12px 45px;
	letter-spacing: 1px;
	text-transform: uppercase;
	transition: transform 80ms ease-in;
}

form {
	background-color: #FFFFFF;
	display: flex;
	align-items: center;
	justify-content: center;
	flex-direction: column;
	padding: 0 50px;
	height: 100%;
	text-align: center;
    overflow:hidden;
}

input {
	background-color: #eee;
	border: none;
	padding: 12px 15px;
	margin: 8px 0;
	width: 100%;
    box-shadow: 0px 0px 8px #7bc1f7;
}

.container {
	background-color: #fff;
	border-radius: 10px;
  	box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);
	position: relative;
	overflow: hidden;
	width: 768px;
	max-width: 100%;
	min-height: 480px;
}

.form-container {
	position: absolute;
	top: 0;
	height: 100%;
    
}

.log-in-container {
	left: 0;
	width: 50%;
	z-index: 2;
}


.overlay-container {
	position: absolute;
	top: 0;
	left: 50%;
	width: 50%;
	height: 100%;
}


.overlay {
	background: #FF416C;
	background: -webkit-linear-gradient(to right, #FF4B2B, #FF416C);
	background: linear-gradient(to right, #FF4B2B, #FF416C);
	background-repeat: no-repeat;
	background-size: cover;
	background-position: 0 0;
	color: #FFFFFF;
	position: relative;
	left: -100%;
	height: 100%;
	width: 200%;
}

.overlay-panel {
	position: absolute;
	display: flex;
	align-items: center;
	justify-content: center;
	flex-direction: column;
	padding: 0 40px;
	text-align: center;
	top: 0;
	height: 100%;
	width: 50%;
}


.overlay-right {
	right: 0;
}
        .auto-style1 {
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);
            position: relative;
            overflow: hidden;
            width: 859px;
            max-width: 100%;
            min-height: 480px;
            left: 0px;
            top: 0px;
            height: 490px;
        }
    </style>
</head>
<body>
    

        
    <div class="topnav" style="font-style: italic; font-variant: small-caps">
            <img src="images/crop.png" class="log" alt="logo" />&nbsp;
                Lucky
            <a href="#about" class="split">Help</a>
            <a href="servicelogin.aspx" class="split">Service Provider</a>
            <a href="customer.aspx" class="split">Customer</a>
        </div>
    <div class="main">
    <div class="auto-style1" id="container">
        <div class="form-container log-in-container">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
       <h1>Login As a ServiceProvider</h1>
                <!-- <div class="social-container">
					<a href="#" class="social"><i class="fa fa-facebook fa-2x"></i></a>
					<a href="#" class="social"><i class="fab fa fa-twitter fa-2x"></i></a>
				</div> -->
                
                <!-- <div class="social-container">
					<a href="#" class="social"><i class="fa fa-facebook fa-2x"></i></a>
					<a href="#" class="social"><i class="fab fa fa-twitter fa-2x"></i></a>
				</div> -->
                <span>or use your account</span>
                
        <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                
        <asp:TextBox ID="passtext" runat="server"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" runat="server" />
                <a href="#">Forgot your password?</a>
                
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <a href="register/register.aspx">
            new user register here!!
        </a>
            </ContentTemplate>
    </asp:UpdatePanel>

    </form>
            </div>
        <div class="overlay-container">
            <div class="overlay">
                <div class="overlay-panel overlay-right">
                    <h1>Make it simple:)</h1>
                    <p>Available Services </p>
                    <ul>
                        <li>Home services</li>
                        <li>Plumbing services</li>
                        <li>Health services</li>
                        <li>Mechanic services</li>
                        <li>Electrician services</li>
                        <li>Computer services</li>
                    </ul>
                    
                </div>
            </div>
        </div>
    </div>
    </div>
            
   
</body>
</html>
