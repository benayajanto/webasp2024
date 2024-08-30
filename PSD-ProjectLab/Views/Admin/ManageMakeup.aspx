<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="PSD_ProjectLab.Views.Admin.ManageMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Makeup</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupBrandID" HeaderText="MakeupBrandID" SortExpression="MakeupBrandID" />
                <asp:CommandField HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" ButtonType="Button" />
            </Columns>

        </asp:GridView>
        <br />
        <asp:Button ID="insertMakeup_btn" runat="server" Text="Insert Makeup" OnClick="insertMakeup_btn_Click"/>
    </div>

    <div>
        <h1>Makeup Type</h1>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView2_RowDeleting" OnRowEditing="GridView2_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="MakeupTypeID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupTypeName" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>

        </asp:GridView>
        <br />
        <asp:Button ID="insertMakeuptype_btn" runat="server" Text="Insert Makeup Type"  OnClick="insertMakeuptype_btn_Click"/>
    </div>

    <div>
        <h1>Makeup Brand</h1>
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView3_RowDeleting" OnRowEditing="GridView3_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupBrandsID" HeaderText="MakeupBrandsID" SortExpression="MakeupBrandsID" />
                <asp:BoundField DataField="MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="MakeupBrandRating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="insertMakeupBrand_btn" runat="server" Text="Insert Makeup Brand" OnClick="insertMakeupBrand_btn_Click"/>
    </div>
</asp:Content>
