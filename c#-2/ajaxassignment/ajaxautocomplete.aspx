<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxautocomplete.aspx.cs" Inherits="autocomplete.ajaxautocomplete" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
        }
        .AutoExtenderList{
            font-family:Verdana,Arial, Helvetica, sans-serif;
            font-size:.8em;
            margin:0px;
            font-weight:normal;
            border:solid 1px gray;
            line-height:20px;
            padding:0px;
            background-color:white;
        }
        .AutoExtenderListItem{
           border-bottom:dotted 1px #006699;
           cursor:pointer;
           color:maroon;
           left:auto;
           margin:0px;
        }
        .AutoExtenderHighlight{
            color:white;
            background-color:#006699;
            cursor:pointer;
            margin:0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="2" class="auto-style1">

                <tr>
                    <td>Select City: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

                        <ajaxToolkit:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" BehaviorID="TextBox1_AutoCompleteExtender" CompletionInterval="100" DelimiterCharacters="" MinimumPrefixLength="1" ServiceMethod="GetCompletionList" ServicePath="" TargetControlID="TextBox1" CompletionListCssClass="AutoExtenderList" CompletionListItemCssClass="AutoExtenderListItem" CompletionListHighlightedItemCssClass="AutoExtenderHighlight">
                        </ajaxToolkit:AutoCompleteExtender>

                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
