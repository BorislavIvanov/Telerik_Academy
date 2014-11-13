<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomGenerator.aspx.cs" Inherits="_02.RandomGenerator_WithWebControls.RandomGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="firstForm" runat="server">
        <asp:Label ID="lblMin" runat="server">Min Random Number: </asp:Label>
        <asp:TextBox ID="tbMin" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMax" runat="server">Max Random Number: </asp:Label>
        <asp:TextBox ID="tbMax" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="btnGenerate" runat="server" Text="Generate random number!"  OnClick="btnGenerate_Click"/>
        <br />
        <br />
        <asp:Literal ID="litGeneratedNumber" runat="server"></asp:Literal>
    </form>
</body>
</html>
