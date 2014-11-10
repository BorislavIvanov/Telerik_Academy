<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloPage.aspx.cs" Inherits="_01.Hello.HelloPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="FirstForm" runat="server">
    <div>
        <asp:Label ID="lblInputName" runat="server">Your Name:</asp:Label>
        <asp:TextBox ID="tbInputName" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="btnGenerate" runat="server" Text="Generate :)" OnClick="btnGenerate_Click"/>
    </div>
    </form>
    <br />
    <asp:Label ID="lblResult" runat="server">Result:</asp:Label>
    <asp:Literal ID="litResult" runat="server"></asp:Literal>
</body>
</html>
