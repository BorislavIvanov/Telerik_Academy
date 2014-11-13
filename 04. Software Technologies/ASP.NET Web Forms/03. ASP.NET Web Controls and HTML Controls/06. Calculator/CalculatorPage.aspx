<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorPage.aspx.cs" Inherits="_06.Calculator.CalculatorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        form{
            width: 226px;
            height: 170px;
            margin: auto;
        }
            .divResult{
                width: 200px;
                height: 25px;
                font-size: 20px;
                border: 1px solid black;
            }
            .divBox{
                border: 1px solid black;
                padding: 5px 10px;
                text-align: center;
            }
                .calcBtn{
                    width: 48px;
                }
                .lastBtn{
                    width:200px;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal ID="numOne" runat="server" Visible="false" />
        <asp:Literal ID="numTwo" runat="server" Visible="false" />
        <asp:Literal ID="currentOperator" runat="server" Visible="false" />
        <div class="divBox">
            <div class="divResult">
                <asp:Literal ID="litResultScreen" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="divBox">
            <asp:Button ID="btnOne" CssClass="calcBtn" runat="server" Text="1" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnTwo" CssClass="calcBtn" runat="server" Text="2" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnThree" CssClass="calcBtn" runat="server" Text="3" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnPlus" CssClass="calcBtn" runat="server" Text="+" OnClick="OperatorClicked" />
            <br />
            <asp:Button ID="btnFour" CssClass="calcBtn" runat="server" Text="4" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnFive" CssClass="calcBtn" runat="server" Text="5" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnSix" CssClass="calcBtn" runat="server" Text="6" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnMinus" CssClass="calcBtn" runat="server" Text="-" OnClick="OperatorClicked" />
            <br />
            <asp:Button ID="btnSeven" CssClass="calcBtn" runat="server" Text="7" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnEight" CssClass="calcBtn" runat="server" Text="8" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnNine" CssClass="calcBtn" runat="server" Text="9" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnMultiply" CssClass="calcBtn" runat="server" Text="x" OnClick="OperatorClicked" />
            <br />
            <asp:Button ID="btnClear" CssClass="calcBtn" runat="server" Text="Clear" OnClick="ClearClicked" />
            <asp:Button ID="btnZero" CssClass="calcBtn" runat="server" Text="0" OnClick="DigitButtonClicked" />
            <asp:Button ID="btnDivision" CssClass="calcBtn" runat="server" Text="/" OnClick="OperatorClicked" />
            <asp:Button ID="btnRadical" CssClass="calcBtn" runat="server" Text="√" OnClick="RootClicked" />
        </div>
        <div class="divBox">
            <asp:Button ID="btnResult" CssClass="lastBtn" runat="server" Text="=" OnClick="resultButtonClicked" />
        </div>
    </form>
</body>
</html>
