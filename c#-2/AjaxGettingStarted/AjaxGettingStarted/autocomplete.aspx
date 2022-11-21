<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="autocomplete.aspx.cs" Inherits="AjaxGettingStarted.autocomplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
        }
        .auto-style2 {
            width: 118px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td class="auto-style2">Select City: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <ajaxToolkit:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" BehaviorID="TextBox1_AutoCompleteExtender" CompletionInterval="100" DelimiterCharacters="" MinimumPrefixLength="1" ServicePath="" TargetControlID="TextBox1">
                        </ajaxToolkit:AutoCompleteExtender>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
