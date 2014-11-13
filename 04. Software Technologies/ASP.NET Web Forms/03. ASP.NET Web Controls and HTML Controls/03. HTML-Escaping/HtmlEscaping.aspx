<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="HtmlEscaping.aspx.cs" Inherits="_03.HTML_Escaping.HtmlEscaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbInput" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btmSubmit" runat="server" Text="Submit" OnClick="btmSubmit_Click"/>
            <hr />
            <asp:TextBox ID="tbOutput" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOutput" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
