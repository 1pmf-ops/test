<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editEntry.aspx.cs" Inherits="Lib.editEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="La_Authors">Authors: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_Authors"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_Title">Title: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_Title"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_ReDate">Release date: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_ReDate"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_ISBN">ISBN: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_ISBN"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_Format">Format: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_Format"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_Pages">Pages: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_Pages"></asp:TextBox>
        </div>
        <div>
            <asp:Label runat="server" ID="La_Desc">Description: </asp:Label>
            <asp:TextBox runat="server" ID="TxBx_Desc"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" ID="Bu_Edit" Text="Change" OnClick="Edit"/>
            <asp:Button runat="server" ID="Bu_Back" Text="Back" OnClick="Back"/>
        </div>
    </form>
</body>
</html>
