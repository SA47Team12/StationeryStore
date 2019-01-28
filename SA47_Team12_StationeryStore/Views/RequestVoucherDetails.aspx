<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RequestVoucherDetails.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.RequestVoucherDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div>
            
        <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="ValidateAddVoucher" 
            ShowMessageBox="False" ShowSummary="True" />
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="ValidateAddVoucher_ServerValidate"
            ShowMessageBox="False" ShowSummary="True" />
        </div>

        <div>
        <asp:Label ID="Label1" runat="server" Text="ItemCode"></asp:Label>
        </div>

        <div>
        <asp:TextBox ID="ItemCodeTextBox" runat="server" ReadOnly="true" AutoPostBack="true" 
            CausesValidation="true" ValidationGroup="ValidateAddVoucher_ServerValidate" ></asp:TextBox>
        </div>

        <div>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            OnServerValidate="CustomValidator1_ServerValidate" ErrorMessage="Please enter a valid item code e.g. E035"
            ControlToValidate="ItemCodeTextBox" Display="None" ValidationGroup="ValidateAddVoucher_ServerValidate">
        </asp:CustomValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator0" runat="server" ControlToValidate="ItemCodeTextBox" 
            ErrorMessage="ItemCode must not be empty" ValidationGroup="ValidateAddVoucher" Display="none"></asp:RequiredFieldValidator>
        </div>
            
        <div>
        <asp:Label ID="Label2" runat="server" Text="AdjustedQty"></asp:Label>
        </div>

        <div>
        <asp:TextBox ID="AdjQtyTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="AdjustedQty must be a number" 
               ControlToValidate="AdjQtyTextBox" Operator="DataTypeCheck" Type="Integer"  ValidationGroup="ValidateAddVoucher" Display="None">
            </asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="AdjQtyTextBox"
                ErrorMessage="AdjustedQty must not be empty" ValidationGroup="ValidateAddVoucher" Display="None"></asp:RequiredFieldValidator>
        </div>
            
        <div>
        <asp:Label ID="Label3" runat="server" Text="Reason"></asp:Label>
        </div>

        <div>
        <asp:TextBox ID="ReasonTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ReasonTextBox" 
                ErrorMessage="Reason must not be empty" ValidationGroup="ValidateAddVoucher" Display="None"></asp:RequiredFieldValidator>
        </div>

        <div>
        <asp:Button ID="AddVouButton1" runat="server" Text="Add Voucher Item" OnClick="AddVouButton1_Click" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="ValidateAddVoucher"/>
            <br />
            <br />
        </div>
     </div>   

        <asp:Button ID="AddVouButton2" runat="server" Text="Add Voucher Item" OnClick="AddVouButton2_Click" CssClass="btn btn-primary" Width="157px"/>
        <br />
        <br />
        <asp:GridView DataKeyNames="VoucherDetailId" ID="RaiseVouReqGridView" runat="server" CssClass="table table-striped table-bordered"
            AutoGenerateColumns="False" OnRowDeleting="RaiseVouReqGridView_RowDeleting" OnRowCancelingEdit="RaiseVouReqGridView_RowCancelingEdit" 
            OnRowEditing="RaiseVouReqGridView_RowEditing" OnRowUpdating="RaiseVouReqGridView_RowUpdating" 
            EmptyDataText="There are no items"  ShowHeaderWhenEmpty="True" Width="513px"
            AllowPaging="True" OnPageIndexChanging="RaiseVouReqGridView_PageIndexChanging" PageSize="5" 
            GridLines="None" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField Visible="false" DataField="VoucherDetailId" HeaderText="VoucherDetail Id" Readonly="true"/>
                <asp:BoundField DataField="SerialNo" HeaderText="Serial No." Readonly="true"/>
                <asp:BoundField DataField="ItemId" HeaderText="Item Code" Readonly="true"/>
                <asp:TemplateField HeaderText="Adjusted Qty">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("AdjustedQty") %>'></asp:TextBox>
                        <div>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" Operator="DataTypeCheck" Type="Integer" 
                             ControlToValidate="TextBox1" ErrorMessage="1Input must be a number" Font-Bold="False" ForeColor="Red">
                            </asp:CompareValidator>
                        </div>
                        <div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextBox1" runat="server" 
                            ErrorMessage="1Input must not be empty" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AdjustedQty") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remarks">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Remarks") %>'></asp:TextBox>
                        <div>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox2" 
                            ErrorMessage="Input must not be empty" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Remarks") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" HeaderText="Update" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" HeaderText="Delete" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#284775" ForeColor="White" />
            <HeaderStyle BackColor="#284775" ForeColor="White" />
            <PagerStyle BackColor="#5D7B9D" ForeColor="White" HorizontalAlign="Center" />
        </asp:GridView>
    <br />
        <asp:Button ID="RaiseVouReqButton" runat="server" Text="Raise Voucher Request" OnClick="RaiseVouReqButton_Click" CssClass="btn btn-primary" Width="155px" />
        
</asp:Content>
