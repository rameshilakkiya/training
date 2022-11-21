<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rating.aspx.cs" Inherits="autocomplete.rating" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 937px;
        }
        .StarEmpty{
            background-image:url('images/img2.jfif');
/*            background-color:rebeccapurple;
*/          height:100px;
            width:100px;

        }
        .StarFilled{
            background-image:url('images/img1.jfif');
            
            height:100px;
            width:100px;

        }

        .auto-style2 {
            height: 167px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Rate our Service:</td>
                    <td class="auto-style2">
                        <ajaxToolkit:Rating ID="Rating1" runat="server" CurrentRating="1" AutoPostBack="True" StarCssClass="StarEmpty" FilledStarCssClass="StarFilled" EmptyStarCssClass="StarEmpty" WaitingStarCssClass="StarFilled" OnChanged="Rating1_Changed" OnClick="Rating1_Click">
                        </ajaxToolkit:Rating>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
