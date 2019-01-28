<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateCollectionPoint.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.UpdateCollectionPoint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
     <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
     <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <div class="form-horizontal">
            
    <h2 aria-dropeffect="none">Manage Collection Point</h2>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>

        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>

         <div class="well">
              <%--<%if (IsDelegated()){ %>--%>
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
          <%--  <%} %> --%>           
        </div>
        </div>

</asp:Content>
