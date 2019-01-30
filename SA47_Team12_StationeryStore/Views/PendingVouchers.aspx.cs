﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class PendingVouchers : System.Web.UI.Page
    {
        /* Change: Added BindGrid(string stateOfRadioButton) */
        private void BindGrid(string stateOfRadioButton)
        {
            if (stateOfRadioButton == "latest")
            {
                int EmpID = (int)HttpContext.Current.Session["EmpID"];
                List<PendingVoucherRequest> latestVoucherRequest = new List<PendingVoucherRequest>();
                latestVoucherRequest.Add(VoucherBizLogic.ListPendingVoucherRequests(EmpID).Last());
                PendingVouchersGridView.DataSource = latestVoucherRequest;  // hardcoded employeeid for now, need to retrieve later
                PendingVouchersGridView.DataBind();
            }

            else if (stateOfRadioButton == "all")
            {
                int EmpID = (int)HttpContext.Current.Session["EmpID"];
                PendingVouchersGridView.DataSource = VoucherBizLogic.ListPendingVoucherRequests(EmpID); // hardcoded employeeid for now, need to retrieve later
                PendingVouchersGridView.DataBind();
            }
        }

        /* Change: Added BindGridAuto() */
        private void BindGridAuto()
        {
            if (radioButtonLatest.Checked) BindGrid("latest");
            else if (radioButtonAll.Checked) BindGrid("all");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");

            /* Change: Added two else-if statements */
            else if (!IsPostBack)
            {
                BindGrid("latest");
                PendingVoucherItemsGridView.Visible = false;
            }

            else if (IsPostBack)
            {
                BindGridAuto();
                PendingVoucherItemsGridView.Visible = false;

            }
        }

        /*Change: added PendingVouchersGridView_SelectedIndexChanged */
        protected void PendingVouchersGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int voucherId = Convert.ToInt32(PendingVouchersGridView.DataKeys[PendingVouchersGridView.SelectedRow.RowIndex].Values[0]);
            PendingVoucherItemsGridView.DataSource = VoucherBizLogic.ListVoucherDetails((int)HttpContext.Current.Session["EmpID"], voucherId);
            PendingVoucherItemsGridView.DataBind();
            PendingVoucherItemsGridView.Visible = true;
        }

        /*Change: added PendingVouchersGridView_SelectedIndexChanging */
        protected void PendingVouchersGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            PendingVoucherItemsGridView.Visible = true;

        }

        protected void PendingVouchersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int voucherId = Convert.ToInt32(PendingVouchersGridView.DataKeys[e.RowIndex].Values[0]);
            VoucherBizLogic.DeletePendingVoucher(voucherId);
            /*Change: Changed bindgrid() to bindgridauto() */
            BindGridAuto();
        }

        protected void PendingVouchersGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PendingVouchersGridView.PageIndex = e.NewPageIndex;
            PendingVouchersGridView.DataBind();
            /*Change: Changed bindgrid() to bindgridauto() */
            BindGridAuto();
        }

        protected void PendingVoucherItemsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PendingVoucherItemsGridView.PageIndex = e.NewPageIndex;
            PendingVoucherItemsGridView.DataBind();
            /*Change: Changed bindgrid() to bindgridauto() */
            BindGridAuto();
        }

        //protected void PendingVoucherItemsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    PendingVoucherItemsGridView.PageIndex = e.NewPageIndex;
        //    PendingVoucherItemsGridView.DataBind();
        //    /*Change: Changed bindgrid() to bindgridauto() */
        //    BindGridAuto();
        //}

    }
}