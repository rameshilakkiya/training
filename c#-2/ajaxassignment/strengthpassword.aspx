<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="strengthpassword.aspx.cs" Inherits="AjaxGettingStarted.strengthpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
.barBorder
 {
      border: solid 1px red;
      width: 300px;
 }
 .poor{
     background-color:darkred;
 }
 .weak{
     background-color:red;
 }
 .average{
     background-color:yellow;
 }
 .nice{
     background-color:lightgreen;
 }
 .strong{
     background-color:green;
 }
 </style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Enter Your Password"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <ajaxToolkit:PasswordStrength ID="PasswordStrength1" runat="server" TargetControlID="TextBox1" HelpStatusLabelID="Label2" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="2" MinimumSymbolCharacters="2" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" PrefixText="PasswordStrength: " RequiresUpperAndLowerCaseCharacters="True" StrengthIndicatorType="BarIndicator" DisplayPosition="BelowLeft" BarBorderCssClass="barBorder" TextStrengthDescriptions="poor;weak;average;nice;strong" StrengthStyles="poor;weak;average;nice;strong" />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
