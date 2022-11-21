<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ASPNET_GetttingStarted_1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SignUp Form</h1>
    <table class="nav-justified" border="0" style="border-width: 1px; border-style: solid; background-color: #C0C0C0">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name: " Font-Size="Small" ></asp:Label>
            </td>
            <td style="height: 67px" colspan="3">
                <asp:TextBox ID="nametext" runat="server" Height="32px" Width="143px" ToolTip="Enter Your Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametext" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Email: " Font-Size="Small"></asp:Label>
            </td>
            <td style="height: 78px" colspan="3">
                <asp:TextBox ID="emailtext" runat="server" Height="35px" Width="145px" ToolTip="exam@xyz.com"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailtext" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtext" Display="Dynamic" ErrorMessage="Invalid EmailId" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Password: " Font-Size="Small"></asp:Label>
            </td>
            <td style="height: 74px" colspan="3">
                <asp:TextBox ID="passtext" runat="server" Height="35px" Width="145px" ToolTip="alphanumeric"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="passtext" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="passtext" Display="Dynamic" ErrorMessage="Type Strong password[ex:paSs123]" ForeColor="#FF3300" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Size="Small" Text="Mobile: "></asp:Label>
            </td>
            <td style="height: 74px" colspan="3">
                <asp:TextBox ID="mobile" runat="server" Height="34px" Width="146px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="mobile" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="mobile" Display="Dynamic" ErrorMessage="length must be 10" ForeColor="#FF3300" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Size="Small" Text="D O B: "></asp:Label>
            </td>
            <td style="height: 74px" colspan="3">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server"  Font-Size="Small" Text="Sex: "></asp:Label>
            </td>
            <td style="height: 74px" colspan="2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="gender" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                <asp:RadioButtonList ID="gender" runat="server" Height="55px" RepeatDirection="Horizontal" Width="227px">
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Size="Small" Text="Education: "></asp:Label>
            </td>
            <td style="height: 74px">
                <asp:CheckBox ID="ug" runat="server" Text="UG" />
            </td>
            <td style="height: 74px; width: 180px;">
                <asp:CheckBox ID="pg" runat="server" Text="PG" />
            </td>
            <td style="height: 74px">
                <asp:CheckBox ID="other" runat="server" Text="OTHERS" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Font-Size="Small" Text="Location: "></asp:Label>
            </td>
            <td style="height: 74px" colspan="3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="43px" Width="179px">
                    <asp:ListItem>Bangalore</asp:ListItem>
                    <asp:ListItem>TamilNadu</asp:ListItem>
                    <asp:ListItem>Karnataka</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="*" Font-Size="Larger" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF3300" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td style="height: 87px" colspan="3">
                <asp:Button ID="Button1" runat="server" Height="36px" Text="Submit" Width="103px" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
