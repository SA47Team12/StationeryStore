<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageSupplier.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.ManageSupplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h2 aria-dropeffect="none">Manage Supplier List</h2>
    <br />
    <asp:GridView ID="SupplierGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplierID" CssClass="table table-striped table-bordered"
        OnRowCancelingEdit="SupplierGridView_RowCancelingEdit" OnRowEditing="SupplierGridView_RowEditing" OnRowUpdating="SupplierGridView_RowUpdating"
        EmptyDataText="TThere is no suppliers to display." ShowHeaderWhenEmpty="True"
        AllowPaging="True" OnPageIndexChanging="SupplierGridView_PageIndexChanging" PageSize="5" 
        GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" InsertVisible="False" ReadOnly="True" SortExpression="SupplierID" />
                    <asp:TemplateField HeaderText="Name" SortExpression="Name">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Address" SortExpression="Address">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Phone" SortExpression="Phone">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Phone") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
            </asp:GridView>

</asp:Content>
