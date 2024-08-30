<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="ordermakeup.aspx.cs" Inherits="PSD_ProjectLab.Views.Customer.ordermakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Makeup</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
           
            <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="MakeupType.MakeupTypeName" />
            <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="MakeupBrand.MakeupBrandName" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" runat="server" Width="50px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Actions">
                <ItemTemplate>
                    <asp:Button ID="btnBuy" runat="server" Text="Buy" CommandName="Buy" CommandArgument='<%# Container.DataItemIndex %>' />
                    <asp:Label ID="errormessage" runat="server" Text=""></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
        </Columns>

    </asp:GridView>
    <div>
        <h1>My Carts</h1>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="MakeupName" SortExpression="Makeups.MakeupName" />
                <asp:BoundField DataField="Makeup.MakeupPrice" HeaderText="MakeupPrice" SortExpression="Makeups.MakeupPrice" />
                <asp:BoundField DataField="Makeup.MakeupWeight" HeaderText="MakeupWeight" SortExpression="Makeups.MakeupWeight" />
                <asp:BoundField DataField="Makeup.MakeupType.MakeupTypeName" HeaderText="MakeupTypeName" SortExpression="Makeups.MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="Makeup.MakeupBrand.MakeupBrandName" HeaderText="MakeupBrandName" SortExpression="Makeups.MakeupBrand.MakeupBrandName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
        <br />
        <asp:Label ID="errormessage2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="clear_btn" runat="server" Text="Clear all Cart" OnClick="clear_btn_Click"/>
        <asp:Button ID="checkout_btn" runat="server" Text="Checkout" OnClick="checkout_btn_Click"/>
    </div>
</asp:Content>
