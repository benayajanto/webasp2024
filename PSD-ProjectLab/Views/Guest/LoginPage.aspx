<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSD_ProjectLab.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <br />
                <asp:TextBox ID="password_textbox" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:CheckBox ID="RememberMe" runat="server" />
                <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Don't have an account? "></asp:Label>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click here</asp:LinkButton>
            </div>
            <br />
            <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
            <br />

            <asp:Button ID="submit_button" runat="server" Text="Submit" OnClick="submit_button_Click"/>
        </div>
     </form>
</body>
</html>
