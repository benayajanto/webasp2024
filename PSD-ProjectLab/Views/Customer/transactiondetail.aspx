<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="transactiondetail.aspx.cs" Inherits="PSD_ProjectLab.Views.Customer.transactiondetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Transaction Detail</h1>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" />
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" SortExpression="TransactionID" />
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="MakeupName" SortExpression="Makeup.MakeupName" />
                <asp:BoundField DataField="Makeup.MakeupPrice" HeaderText="MakeupPrice" SortExpression="Makeup.MakeupPrice" />
                <asp:BoundField DataField="Makeup.MakeupWeight" HeaderText="MakeupWeight" SortExpression="Makeup.MakeupWeight" />
                <asp:BoundField DataField="Makeup.MakeupType.MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
