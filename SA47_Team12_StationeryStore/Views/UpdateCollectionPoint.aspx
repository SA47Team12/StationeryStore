<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateCollectionPoint.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.UpdateCollectionPoint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-horizontal">
            
    <h2 aria-dropeffect="none">Manage Collection Point</h2>
         <div class="well">
            Current Collection Point is :
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            Select Your New Collection Point
             <asp:RadioButtonList ID="CPRadioButtonList" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="Location" DataValueField="CollectionID">
            </asp:RadioButtonList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                SelectCommand="SELECT [CollectionID], [Location] FROM [Collection]"></asp:SqlDataSource>
            <br />
            <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click"  CssClass="btn btn-primary" Text="Update" />        
        </div>
        </div>

</asp:Content>
