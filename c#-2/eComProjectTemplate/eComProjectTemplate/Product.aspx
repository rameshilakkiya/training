<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="eComProjectTemplate.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 308px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Amazon sale 50% offer!!!</h1>
    <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Products"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Code: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="codtext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="nametext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Description: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="descrip" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Manufacturer: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="manu" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Price: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="pri" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="code" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="2">
                        <Columns>
                            <asp:BoundField DataField="code" HeaderText="code" ReadOnly="True" SortExpression="code" />
                            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                            <asp:BoundField DataField="manufacturer" HeaderText="manufacturer" SortExpression="manufacturer" />
                            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        </Columns>
                        <PagerSettings Mode="NumericFirstLast" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" DeleteCommand="DELETE FROM [productnew] WHERE [code] = @code" InsertCommand="INSERT INTO [productnew] ([code], [name], [description], [manufacturer], [price]) VALUES (@code, @name, @description, @manufacturer, @price)" SelectCommand="SELECT * FROM [productnew]" UpdateCommand="UPDATE [productnew] SET [name] = @name, [description] = @description, [manufacturer] = @manufacturer, [price] = @price WHERE [code] = @code">
                        <DeleteParameters>
                            <asp:Parameter Name="code" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="code" Type="Int32" />
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="description" Type="String" />
                            <asp:Parameter Name="manufacturer" Type="String" />
                            <asp:Parameter Name="price" Type="Int32" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="name" Type="String" />
                            <asp:Parameter Name="description" Type="String" />
                            <asp:Parameter Name="manufacturer" Type="String" />
                            <asp:Parameter Name="price" Type="Int32" />
                            <asp:Parameter Name="code" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
        </table>
    


</asp:Content>
