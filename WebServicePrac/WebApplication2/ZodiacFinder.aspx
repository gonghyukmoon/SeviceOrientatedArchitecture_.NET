<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZodiacFinder.aspx.cs" Inherits="WebApplication2.ZodiacFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Task1&amp;2:Zodiac Finder<br />
        <br />
        Find Date by Name:<br />
        Name:<asp:TextBox ID="Name1" runat="server"></asp:TextBox>
        <asp:Button ID="GetDate" runat="server" OnClick="GetDate_Click" Text="GetDate" />
&nbsp;Date:<asp:TextBox ID="Date" runat="server"></asp:TextBox>
        <br />
        <br />
        Find Name by Date:<br />
        Mon:<asp:TextBox ID="Mon" runat="server"></asp:TextBox>
&nbsp;Day:<asp:TextBox ID="Day" runat="server"></asp:TextBox>
        <asp:Button ID="GetName" runat="server" OnClick="GetName_Click" Text="GetName" />
&nbsp;Name:<asp:TextBox ID="Name2" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
