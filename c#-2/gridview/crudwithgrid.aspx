<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crudwithgrid.aspx.cs" Inherits="eComProjectTemplate.crudwithgrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True">
                <Columns>

                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:TemplateField HeaderText="Id" InsertVisible="False" SortExpression="Id">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server">Insert</asp:LinkButton>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="name" SortExpression="name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="gender" SortExpression="gender">
                        <EditItemTemplate>
                            
                            <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Bind("gender") %>'>
                                <asp:ListItem>SelectGender</asp:ListItem>
                                <asp:ListItem>male</asp:ListItem>
                                <asp:ListItem>female</asp:ListItem>
                                <asp:ListItem>other</asp:ListItem>
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("gender") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="footerddlname" runat="server">
                                <asp:ListItem>SelectGender</asp:ListItem>
                                <asp:ListItem>male</asp:ListItem>
                                <asp:ListItem>female</asp:ListItem>
                                <asp:ListItem>other</asp:ListItem>
                            </asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="class" SortExpression="class">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("class") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("class") %>'></asp:Label>
                        </ItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </FooterTemplate>
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" DeleteCommand="DELETE FROM [students] WHERE [Id] = @Id" InsertCommand="INSERT INTO [students] ([name], [gender], [class]) VALUES (@name, @gender, @class)" SelectCommand="SELECT * FROM [students]" UpdateCommand="UPDATE [students] SET [name] = @name, [gender] = @gender, [class] = @class WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="gender" Type="String" />
                    <asp:Parameter Name="class" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="gender" Type="String" />
                    <asp:Parameter Name="class" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
