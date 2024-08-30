<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeUpType.aspx.cs" Inherits="PSD_ProjectLab.Views.Admin.InsertMakeUpType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Back_btn" runat="server" Text="Back" OnClick="Back_btn_Click"/>
    <br />
    <h1>Insert Makeup Type</h1>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
    <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click"/>
</asp:Content>
