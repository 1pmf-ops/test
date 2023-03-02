<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="Lib.Database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Form_Database" runat="server">
        <div>
            <asp:Label ID="La_Server" runat="server" Text="Label">Server: </asp:Label>
            <asp:TextBox ID="TxBx_Server" runat="server"></asp:TextBox>
       </div>
        <div>
            <asp:Label ID="La_Port" runat="server" Text="Label">Port: </asp:Label>
            <asp:TextBox ID="TxBx_Port" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="La_Database" runat="server" Text="Label">Database: </asp:Label>
            <asp:TextBox ID="TxBx_Database" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="La_User" runat="server" Text="Label">User: </asp:Label>
            <asp:TextBox ID="TxBx_User" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="La_Password" runat="server" Text="Label">Password: </asp:Label>
            <asp:TextBox ID="TxBx_Password" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Bu_Send" runat="server" Text="Button" OnClick="Bu_Send_Click" />
    </form>
</body>
</html>
