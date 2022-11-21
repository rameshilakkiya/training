<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listsearchcontrol.aspx.cs" Inherits="autocomplete.listsearchcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 479px;
        }
        .auto-style2 {
            width: 200px;
        }
        .auto-style3 {
            width: 649px;
        }
        .MyPromptCss{
            font-style:italic;
            font-weight:bold;
            font-family:Arial;
            color:rebeccapurple;
            background-color:lightgray;
        }
        .auto-style4 {
            width: 200px;
            height: 95px;
        }
        .auto-style5 {
            width: 649px;
            height: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td class="auto-style4">CHOOSE FRUIT:</td>
                    <td class="auto-style5"><asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="178px">
                        
                            <asp:ListItem>ORANGE</asp:ListItem>
                            <asp:ListItem>PEAR</asp:ListItem>
                            <asp:ListItem>PEACH</asp:ListItem>
                            <asp:ListItem>APPLE</asp:ListItem>
                            <asp:ListItem>STRAWBERRY</asp:ListItem>
                            <asp:ListItem>MANGO</asp:ListItem>
                            <asp:ListItem>GRAPES</asp:ListItem>
                            <asp:ListItem>GUAVA</asp:ListItem>
                            <asp:ListItem>KIWI</asp:ListItem>
                            <asp:ListItem>CUSTARD APPLE</asp:ListItem>
                            <asp:ListItem>BANANA</asp:ListItem>
                            <asp:ListItem>BLUEBERRY</asp:ListItem>
                            <asp:ListItem>PINEAPPLE</asp:ListItem>
                            <asp:ListItem>PAPAYA</asp:ListItem>
                            <asp:ListItem>WATERMELON</asp:ListItem>
                        </asp:DropDownList>
                        <ajaxToolkit:ListSearchExtender ID="DropDownList1_ListSearchExtender" runat="server" BehaviorID="DropDownList1_ListSearchExtender" TargetControlID="DropDownList1">
                        </ajaxToolkit:ListSearchExtender></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="ListBox1" runat="server" Height="245px" Width="226px">
                            <asp:ListItem>ORANGE</asp:ListItem>
                            <asp:ListItem>PEAR</asp:ListItem>
                            <asp:ListItem>PEACH</asp:ListItem>
                            <asp:ListItem>APPLE</asp:ListItem>
                            <asp:ListItem>STRAWBERRY</asp:ListItem>
                            <asp:ListItem>MANGO</asp:ListItem>
                            <asp:ListItem>GRAPES</asp:ListItem>
                            <asp:ListItem>GUAVA</asp:ListItem>
                            <asp:ListItem>KIWI</asp:ListItem>
                            <asp:ListItem>CUSTARD APPLE</asp:ListItem>
                            <asp:ListItem>BANANA</asp:ListItem>
                            <asp:ListItem>BLUEBERRY</asp:ListItem>
                            <asp:ListItem>PINEAPPLE</asp:ListItem>
                            <asp:ListItem>PAPAYA</asp:ListItem>
                            <asp:ListItem>WATERMELON</asp:ListItem>
                        </asp:ListBox>
                        <ajaxToolkit:ListSearchExtender ID="ListBox1_ListSearchExtender" runat="server" BehaviorID="ListBox1_ListSearchExtender" TargetControlID="ListBox1" PromptPosition="Bottom" PromptText="Type to Find: " QueryPattern="Contains" QueryTimeout="2000" PromptCssClass="MyPromptCss">
                        </ajaxToolkit:ListSearchExtender>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
