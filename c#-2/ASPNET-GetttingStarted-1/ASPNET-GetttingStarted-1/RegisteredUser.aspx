<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisteredUser.aspx.cs" Inherits="ASPNET_GetttingStarted_1.RegisteredUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                    <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
                    <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                    <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                    <asp:BoundField DataField="sex" HeaderText="sex" SortExpression="sex" />
                    <asp:BoundField DataField="education" HeaderText="education" SortExpression="education" />
                    <asp:BoundField DataField="location" HeaderText="location" SortExpression="location" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [emp]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
