using System;
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
        private void BindGrid()
        {
            int EmpID = (int)HttpContext.Current.Session["EmpID"];
            PendingVouchersGridView.DataSource = VoucherBizLogic.ListPendingVoucherRequests(EmpID); // hardcoded employeeid for now, need to retrieve later
            PendingVouchersGridView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
            else
            {
                BindGrid();
            }
        }

        protected void PendingVouchersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int voucherId = Convert.ToInt32(PendingVouchersGridView.DataKeys[e.RowIndex].Values[0]);
            VoucherBizLogic.DeletePendingVoucher(voucherId);
            BindGrid();
        }

        protected void PendingVouchersGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PendingVouchersGridView.PageIndex = e.NewPageIndex;
            PendingVouchersGridView.DataBind();
            BindGrid();
        }
    }
}