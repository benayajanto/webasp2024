<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="PSD_ProjectLab.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Profile Information</h1>
        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Gender:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
             <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
             <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Calendar ID="DOBCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="update_btn" runat="server" Text="Update Profile"  OnClick="update_btn_Click"/>
    </div>

    <div>
        <h1>Change Password</h1>
        <asp:Label ID="lblOldPassword" runat="server" Text="Old Password:"></asp:Label>
        <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="lblNewPassword" runat="server" Text="New Password:"></asp:Label>
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm New Password:"></asp:Label>
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="errormessage2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnUpdatePassword" runat="server" Text="Update Password" OnClick="btnUpdatePassword_Click" />
    </div>
</asp:Content>
