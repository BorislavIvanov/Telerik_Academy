<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_01.Calculator___ASP.NET_Web_Forms.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator - Web Forms</title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="calculatorForm" runat="server">
        <div>
            <asp:Label ID="lblFirstNumber" runat="server">FirstNumber:</asp:Label>
            <asp:TextBox ID="tbFirstNumber" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="lblSecondNumber" runat="server">SecondNumber:</asp:Label>
            <asp:TextBox ID="tbSecondNumber" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="submitButton" runat="server" Text="Calculate" OnClick="submitButton_Click"/>
    </form>
    <hr />
    <asp:Label ID="lblResult" runat="server">Result:</asp:Label>
    <asp:Literal ID="litResult" runat="server"></asp:Literal>
</body>
</html>
