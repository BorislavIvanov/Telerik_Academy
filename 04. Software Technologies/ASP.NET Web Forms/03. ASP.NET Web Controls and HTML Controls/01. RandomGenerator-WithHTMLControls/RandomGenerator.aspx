<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomGenerator.aspx.cs" Inherits="_01.RandomGenerator_WithHTMLControls.RandomGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="firstForm" runat="server">
        <label>Min Random Number: </label>
        <input type="text" id="inpMin" runat="server" />
        <br />
        <br />
        <label>Max Random Number: </label>
        <input type="text" id="inpMax" runat="server" />
        <hr />
        <button id="btnGenerate" runat="server" onserverclick="btnGenerate_ServerClick">Generate random number!</button>
        <br />
        <br />
        <div id="divGeneratedNumber" runat="server"></div>
    </form>
</body>
</html>
