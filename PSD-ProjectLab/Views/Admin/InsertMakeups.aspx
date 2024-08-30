<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeups.aspx.cs" Inherits="PSD_ProjectLab.Views.Admin.InsertMakeups" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="back_btn" runat="server" Text="Back" OnClick="back_btn_Click"/>
    <br />
    <h1>Insert Makeups</h1>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="price_txt" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Weight: "></asp:Label>
        <asp:TextBox ID="weight_txt" runat="server" TextMode="Number"></asp:TextBox>
    </div>  
    <div>
        <asp:Label ID="Label4" runat="server" Text="Type ID: "></asp:Label>
        <asp:TextBox ID="typeid_txt" runat="server"></asp:TextBox>
    </div>
     <div>
         <asp:Label ID="Label5" runat="server" Text="Brand ID: "></asp:Label>
         <asp:TextBox ID="brand_txt" runat="server"></asp:TextBox>
     </div>
    <br />
    <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />
</asp:Content>
