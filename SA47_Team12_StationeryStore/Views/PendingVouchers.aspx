<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PendingVouchers.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.PendingVouchers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView DataKeyNames="VoucherId" CssClass="table table-striped table-bordered" ID="PendingVouchersGridView" runat="server" 
        AutoGenerateColumns="False" OnRowDeleting="PendingVouchersGridView_RowDeleting"
        EmptyDataText="There are no pending vouchers" ShowHeaderWhenEmpty="True"
        AllowPaging="True" OnPageIndexChanging="PendingVouchersGridView_PageIndexChanging" PageSize="5" 
        GridLines="None" CellPadding="4" ForeColor="#333333">
         <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="SerialNo" HeaderText="Serial No." />
                    <asp:BoundField DataField="VoucherId" HeaderText="Voucher Id" />
                    <asp:BoundField DataField="SubmissionDate" HeaderText="Submission Date" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" HeaderText="Delete" />
                </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#284775" ForeColor="White" />
        <HeaderStyle BackColor="#284775" ForeColor="White" />
        <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
            </asp:GridView>

</asp:Content>
