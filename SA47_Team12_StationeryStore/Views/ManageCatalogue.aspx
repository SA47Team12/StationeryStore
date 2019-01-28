<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageCatalogue.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.ManageCatalogue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblSearchByCategoryName" runat="server" Text="Search By Category Name:"></asp:Label>
        <div style="border: 5px solid; padding: 10px; margin-right: 65%">
            <asp:TextBox ID="SearchTextBox" runat="server" placeholder=" Type to search here..." Width="550px" Height="30px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" CssClass="btn btn-primary" Width="76px" />
        </div>
        <br />
        <br />
        <asp:GridView DataKeyNames="ItemNo" ID="ManageCatalogueGridView" runat="server" CssClass="table table-striped table-bordered"
            AutoGenerateColumns="False" OnRowEditing="ManageCatalogueGridView_RowEditing"
            OnRowCancelingEdit="ManageCatalogueGridView_RowCancelingEdit"
            OnRowUpdating="ManageCatalogueGridView_RowUpdating" EmptyDataText="There are no catalogue items" ShowHeaderWhenEmpty="True"
            CellPadding="4" ForeColor="#333333" GridLines="None"
            OnPageIndexChanging="ManageCatalogueGridView_PageIndexChanging" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="SerialNo" ReadOnly="true" HeaderText="Serial No." />
                <asp:BoundField DataField="ItemNo" ReadOnly="true" HeaderText="Item No." />
                <asp:BoundField DataField="CategoryDescription" ReadOnly="true" HeaderText="Category Description" />
                <asp:BoundField DataField="ItemDescription" ReadOnly="true" HeaderText="Item Description" />
                <asp:TemplateField HeaderText="Reorder Level">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ReorderLevel") %>'></asp:TextBox>
                        </div>
                        <div>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="TextBox1" ErrorMessage="Input must be a number" Font-Bold="False" ForeColor="Red"></asp:CompareValidator>
                        </div>
                        <div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                ErrorMessage="Input cannot be empty" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ReorderLevel") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reorder Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ReorderQty") %>'></asp:TextBox>
                        </div>
                        <div>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="TextBox2" ErrorMessage="Input must be a number" Font-Bold="False" ForeColor="Red"></asp:CompareValidator>
                        </div>
                        <div>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                                ErrorMessage="Input cannot be empty"></asp:RequiredFieldValidator>
                        </div>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ReorderQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="UnitOfMeasure" ReadOnly="true" HeaderText="Unit of Measure" />
                <asp:BoundField DataField="UnitCost" ReadOnly="true" HeaderText="Unit Cost" />
                <asp:BoundField DataField="ActualQty" ReadOnly="true" HeaderText="Actual Qty" />
                <asp:CommandField EditText="Update Reorder Level/Qty" ShowEditButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>


        <%-- <asp:Button ID="btnSearch" runat="server" OnClick="" Text="Search" />--%>
    </div>
</asp:Content>
