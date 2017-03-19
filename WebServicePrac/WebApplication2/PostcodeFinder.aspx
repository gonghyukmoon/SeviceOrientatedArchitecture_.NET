<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostcodeFinder.aspx.cs" Inherits="WebApplication2.PostcodeFinder1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/PostcodeFinderService.asmx"/>
            </Services>
        </asp:ScriptManager>

        Task3: Postcode Finder<br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Brisbane</asp:ListItem>
            <asp:ListItem>New Farm</asp:ListItem>
            <asp:ListItem>Bowen Hills</asp:ListItem>
            <asp:ListItem>Hamilton</asp:ListItem>
            <asp:ListItem>Eagle Farm</asp:ListItem>
            <asp:ListItem>Albion Bc</asp:ListItem>
            <asp:ListItem>Clayfield</asp:ListItem>
            <asp:ListItem>Lutwyche</asp:ListItem>
            <asp:ListItem>Alderley</asp:ListItem>
            <asp:ListItem>Kelvin Grove</asp:ListItem>
            <asp:ListItem>Ashgrove</asp:ListItem>
            <asp:ListItem>Milton</asp:ListItem>
            <asp:ListItem>Bardon</asp:ListItem>
            <asp:ListItem>St Lucia</asp:ListItem>
            <asp:ListItem>Uni of Queensland</asp:ListItem>
            <asp:ListItem>Highgate Hill</asp:ListItem>
            <asp:ListItem>Dutton Park</asp:ListItem>
            <asp:ListItem>East Brisbane</asp:ListItem>
            <asp:ListItem>Cannon Hill</asp:ListItem>
            <asp:ListItem>Balmoral</asp:ListItem>
            <asp:ListItem>Murarrie</asp:ListItem>
        </asp:DropDownList>
        <input id="btnFind" runat="server" type="button" value="ShowPostCode" onclick="findPostcode()"/>
        <br />
        <asp:Label ID="lblPostcode" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblTime" runat="server"></asp:Label>
        <script type="text/javascript">
            var findPostcode = function () {
                var e = document.getElementById("DropDownList1");
                var suburb = e.options[e.selectedIndex].text;
         
                WebApplication2.PostcodeFinderService.FindPostcode(suburb, onSuccess, onFailed);
            }
            var onSuccess = function (result) {
                document.getElementById("lblPostcode").innerHTML = result;
            }
            var onFailed = function (result) {
                document.getElementById("lblPostcode").innerHTML = "Invalid Input!";
            }
            </script>
    </div>
    </form>
</body>
</html>
