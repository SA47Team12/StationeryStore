<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryByDept.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.DeliveryByDept" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <br />
        <br />
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2001" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2001_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2001_RowCancelingEdit"
            OnRowUpdating="DeliveryDepTable2001_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2001_PageIndexChanging" PageSize="5" 
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2001" runat="server" Text="Confirm" OnClick="Confirm2001_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />
    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2002" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2002_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2002_RowCancelingEdit"
            OnRowUpdating="DeliveryDepTable2002_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2002_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2002" runat="server" Text="Confirm" OnClick="Confirm2002_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />
    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2003" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2003_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2003_RowCancelingEdit"
            OnRowUpdating="DeliveryDepTable2003_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2003_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2003" runat="server" Text="Confirm" OnClick="Confirm2003_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />

    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2004" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2004_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2004_RowCancelingEdit" OnRowUpdating="DeliveryDepTable2004_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2004_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2004" runat="server" Text="Confirm" OnClick="Confirm2004_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />
    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2005" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2005_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2005_RowCancelingEdit" OnRowUpdating="DeliveryDepTable2005_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2005_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2005" runat="server" Text="Confirm" OnClick="Confirm2005_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />
    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2006" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2006_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2006_RowCancelingEdit" OnRowUpdating="DeliveryDepTable2006_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2006_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2006" runat="server" Text="Confirm" OnClick="Confirm2006_Click" CssClass="btn btn-primary" Visible="false" />
    </div>
    <br />
    <br />
    <div>
        <asp:GridView DataKeyNames="DisbursementID" ID="DeliveryDepTable2007" runat="server" CssClass="table table-striped table-bordered"
            Visible="false" AutoGenerateColumns="False" OnRowEditing="DeliveryDepTable2007_RowEditing"
            OnRowCancelingEdit="DeliveryDepTable2007_RowCancelingEdit" OnRowUpdating="DeliveryDepTable2007_RowUpdating"
            EmptyDataText="There are no items need to Deliver." ShowHeaderWhenEmpty="True"
            AllowPaging="True" OnPageIndexChanging="DeliveryDepTable2007_PageIndexChanging" PageSize="5"
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="DepartmentDes" ReadOnly="true" HeaderText="Department" />
                <asp:BoundField DataField="ItemDes" ReadOnly="true" HeaderText="Description" />

                <asp:TemplateField HeaderText="Disbursed Qty">
                    <EditItemTemplate>
                        <div>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:TextBox>
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
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DisbursedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />

            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Confirm2007" runat="server" Text="Confirm" OnClick="Confirm2007_Click" CssClass="btn btn-primary" Visible="false" />

    </div>

</asp:Content>
