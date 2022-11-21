<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxcalculator.aspx.cs" Inherits="AjaxGettingStarted.ajaxcalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="No1: "></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="No2: "></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
                    <asp:Label ID="Label3" runat="server" visible="false" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
