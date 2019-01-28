<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClerkSup_ItemOrdered.aspx.cs" Inherits="SA47_Team12_StationeryStore.Views.ClerkSup_ItemOrdered" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ReportSourceID="CrystalReportSource8" />
    <p>
        <CR:CrystalReportSource ID="CrystalReportSource8" runat="server">
            <Report FileName="~/bin/Reports/ClerkSup_ItemOrderedRpt.rpt">
            </Report>
        </CR:CrystalReportSource>
    </p>
</asp:Content>
