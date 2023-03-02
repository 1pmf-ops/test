<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Lib.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridV_Select" runat="server" OnRowCommand="Modify">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Ed" Text="Edit" />
                <asp:ButtonField ButtonType="Button" CommandName="Del" Text="Delete" />
            </Columns>
        </asp:GridView>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Add"/>
            <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Search"/>
        </div>
    </form>
</body>
</html>
