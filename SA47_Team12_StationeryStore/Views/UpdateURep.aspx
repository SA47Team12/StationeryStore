<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateURep.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.UpdateURep" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">            
    <h2 aria-dropeffect="none">Assign User Representative</h2>
         <div class="well">
            Current User Representative is:
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            Select Your New User Representative<br />
            <asp:DropDownList ID="URDropDownList" runat="server" Height="22px" Width="233px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click"  CssClass="btn btn-primary" Text="Update" />       
        </div>
        </div>
</asp:Content>
