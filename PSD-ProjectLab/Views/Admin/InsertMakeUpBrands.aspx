<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeUpBrands.aspx.cs" Inherits="PSD_ProjectLab.Views.Admin.InsertMakeUpBrands" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Back_btn" runat="server" Text="Back" OnClick="Back_btn_Click"/>
    <h1>Insert MakeUp Brands</h1>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
    </div>

    <div>
    <asp:Label ID="Label2" runat="server" Text="Rating: "></asp:Label>
    <asp:TextBox ID="rating_txt" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <br />
    <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click"/>
    
</asp:Content>
