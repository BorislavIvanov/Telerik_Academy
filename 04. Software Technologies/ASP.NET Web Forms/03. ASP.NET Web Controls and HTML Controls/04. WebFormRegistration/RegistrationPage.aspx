<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="_04.WebFormRegistration.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="registrationBox" runat="server">
            <asp:Label ID="lblFirstName" runat="server">First name </asp:Label>
            <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblLastName" runat="server">Last name </asp:Label>
            <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblFacultyNumber" runat="server">Faculty number </asp:Label>
            <asp:TextBox ID="tbFacultyNumber" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblUniversity" runat="server">University </asp:Label>
            <asp:DropDownList ID="ddlUniversity" runat="server">
                <asp:ListItem>University 1</asp:ListItem>
                <asp:ListItem>University 2</asp:ListItem>
                <asp:ListItem>University 3</asp:ListItem>
                <asp:ListItem>University 4</asp:ListItem>
                <asp:ListItem>University 5</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Label ID="lblSpecialty" runat="server">Specialty </asp:Label>
            <asp:DropDownList ID="ddlSpecialty" runat="server">
                <asp:ListItem>Specialty 1</asp:ListItem>
                <asp:ListItem>Specialty 2</asp:ListItem>
                <asp:ListItem>Specialty 3</asp:ListItem>
                <asp:ListItem>Specialty 4</asp:ListItem>
                <asp:ListItem>Specialty 5</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Label ID="lblCourses" runat="server">Courses </asp:Label>
            <asp:DropDownList ID="ddlCourses" runat="server">
                <asp:ListItem>Courses 1</asp:ListItem>
                <asp:ListItem>Courses 2</asp:ListItem>
                <asp:ListItem>Courses 3</asp:ListItem>
                <asp:ListItem>Courses 4</asp:ListItem>
                <asp:ListItem>Courses 5</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <div id="submittedForm" runat="server"></div>
    </form>
</body>
</html>