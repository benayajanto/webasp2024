<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="PSD_ProjectLab.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>  
            <br />
            <asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="email_textbox" runat="server" TextMode="Email"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList" runat="server">
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="password_textbox" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
            <br />
            <asp:TextBox ID="confirmpass_textbox" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="DOB_Cal" runat="server"></asp:Calendar>
        </div>
        <br />
        <div>
            <asp:Label ID="Label7" runat="server" Text="Already have an account? "></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click here</asp:LinkButton>
        </div>
        <br />
        <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="register_btn" runat="server" Text="Register" OnClick="register_btn_Click"/>

    </form>
</body>
</html>
