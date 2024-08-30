<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PSD_ProjectLab.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Welcome,</h1>
        <asp:Label ID="name" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="role" runat="server" Text=""></asp:Label>
        <asp:Panel ID="AdminPanel" runat="server" Visible="false">
            <asp:GridView ID="UserData" runat="server" AutoGenerateColumns="False">
                
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="UserDOB" HeaderText="UserDOB" SortExpression="UserDOB" />
                    <asp:BoundField DataField="UserGender" HeaderText="UserGender" SortExpression="UserGender" />
                    <asp:BoundField DataField="UserRole" HeaderText="UserRole" SortExpression="UserRole" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                </Columns>
                
            </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>
