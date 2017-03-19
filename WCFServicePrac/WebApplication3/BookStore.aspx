<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookStore.aspx.cs" Inherits="WebApplication3.BookStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            function addRow() {
                var rowCount = $('#Table1 tr').length
                var html = '<tr>' +
                            '<td>Nook Number</td>' +
                            '<td><input type="text" id="numbertxt' + (rowCount + 1) + '" name="numbertxt' + (rowCount + 1) + '"></td>' +
                            '<td>Amount</td>' +
                            '<td><input type="text" id="amounttxt' + (rowCount + 1) + '" name="amounttxt' + (rowCount + 1) + '"></td>' +
                            '</tr>'
                $(html).appendTo($("#Table1"))
            };
            $("#btnMore").click(addRow);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        All books in Store<br />
        <asp:Table ID="bookTable" runat="server" Height="16px" Width="102px">
            <asp:TableHeaderRow 
                runat="server" 
                ForeColor="Snow"
                BackColor="OliveDrab"
                Font-Bold="true"
                >
            </asp:TableHeaderRow>
        </asp:Table>
        <asp:Label ID="errorlbl" runat="server"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="idtxt" Display="Dynamic" ErrorMessage="ID required" ValidationGroup="add"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="66px" OnClick="btnAdd_Click" ValidationGroup="add" />
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="idtxt" runat="server" ValidationGroup="add"></asp:TextBox>
&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nametxt" runat="server" ValidationGroup="add"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="authortxt" runat="server" ValidationGroup="add"></asp:TextBox>
&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Year"></asp:Label>
        <asp:TextBox ID="yeartxt" runat="server" ValidationGroup="add"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="pricetxt" runat="server" ValidationGroup="add"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="stocktxt" runat="server" ValidationGroup="add"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="65px" OnClick="btnDelete_Click" />
&nbsp;
        <asp:DropDownList ID="deleteddl" runat="server">
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Year</asp:ListItem>
            <asp:ListItem>Price</asp:ListItem>
            <asp:ListItem>Stock</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="deletetxt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="67px" OnClick="btnSearch_Click" />
&nbsp;
        <asp:DropDownList ID="searchddl" runat="server">
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Author</asp:ListItem>
            <asp:ListItem>Year</asp:ListItem>
            <asp:ListItem>Price</asp:ListItem>
            <asp:ListItem>Stock</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="searchtxt" runat="server"></asp:TextBox>
    
        <br />
        <br />
        <br />
        Purchase books<br />
        <br />
        Total Budget
        <asp:TextBox ID="budgettxt" runat="server"></asp:TextBox>
        <br />
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"> Book Number</asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="numbertxt1" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell runat="server"> Amount</asp:TableCell>
                <asp:TableCell runat="server"><asp:TextBox ID="amounttxt1" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
            <asp:Button ID="btnMore" runat="server" Text="More" Width="78px" OnClientClick="return false" />
        <br />
        <br />
        <asp:Button ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" Text="Purchase" />
        <asp:TextBox ID="responsetxt" runat="server" Width="406px"></asp:TextBox>
        <br />
    
    </div>
    </form>
    
</body>
</html>
