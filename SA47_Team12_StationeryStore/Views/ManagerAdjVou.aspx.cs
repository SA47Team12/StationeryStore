using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class ManagerAdjVou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
            
        }

        protected void ViewButton_Click(object sender, EventArgs e)
        {
            AdjVouDetailsGridView.Visible = false;
            ApproveButton.Visible = false;
            RejectButton.Visible = false;
            RemarkTextBox.Visible = false;
            Label3.Visible = false;
            string status = StatusRadioButtonList.SelectedValue;
            AdjVouGridView.DataSource = AdjustmentBizLogic.ListVouchers(status);
            AdjVouGridView.DataBind();
            if (AdjVouGridView.Rows.Count == 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('No Requests');window.location ='ManagerAdjVou.aspx';", true);
            }
        }

        protected void AdjVouGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find which orderID has been clicked
            int VoucherId = (int)AdjVouGridView.SelectedDataKey.Value;
            AdjVouDetailsGridView.Visible = true;
            AdjVouDetailsGridView.DataSource = AdjustmentBizLogic.ListVoucherDetails(VoucherId);
            AdjVouDetailsGridView.DataBind();
            if (StatusRadioButtonList.SelectedValue == "Approved")
            {
                ApproveButton.Visible = false;
                RejectButton.Visible = false;

            }
            else if (StatusRadioButtonList.SelectedValue == "Pending Manager Approval")
            {
                ApproveButton.Visible = true;
                RejectButton.Visible = true;
                RemarkTextBox.Visible = true;
                Label3.Visible = true;
            }
        }

        protected void AdjVouGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AdjVouGridView.PageIndex = e.NewPageIndex;
            AdjVouGridView.DataBind();
            //BindGrid();
        }

        protected void AdjVouDetailsGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void AdjVouDetailsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AdjVouDetailsGridView.PageIndex = e.NewPageIndex;
            AdjVouDetailsGridView.DataBind();
            //BindGrid();
        }

        protected void RejectButton_Click(object sender, EventArgs e)
        {
            string remarks = RemarkTextBox.Text;
            foreach (GridViewRow row in AdjVouDetailsGridView.Rows)
            {
                int voucherId = (int)AdjVouDetailsGridView.DataKeys[row.RowIndex].Values["VoucherID"];
                //string remarks = GridView2.DataKeys[row.RowIndex].Values["Remarks"].ToString();
                DateTime dt = DateTime.Now;
                AdjustmentBizLogic.RejectVoucher(voucherId, dt, remarks);

            }
            //mail to employee who raised request
            String from = "teststationery47@gmail.com";
            String to = "yazh25894@gmail.com";
            String subject = "Voucher Status";
            String body = "Sorry! Your Voucher has been rejected.";

            MailBizLogic.sendMail(from, to, subject, body);

            //to generate popup page and then refresh page again
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Voucher Rejected');window.location ='ManagerAdjVou.aspx';", true);           
        }

        protected void ApproveButton_Click(object sender, EventArgs e)
        {
            string remarks = RemarkTextBox.Text;
            foreach (GridViewRow row in AdjVouDetailsGridView.Rows)
            {
                string itemId = AdjVouDetailsGridView.DataKeys[row.RowIndex].Values["ItemID"].ToString();
                int actualqty = (int)AdjVouDetailsGridView.DataKeys[row.RowIndex].Values["ActualQty"];
                int adjqty = (int)AdjVouDetailsGridView.DataKeys[row.RowIndex].Values["AdjQty"];
                int voucherId = (int)AdjVouDetailsGridView.DataKeys[row.RowIndex].Values["VoucherID"];
                DateTime dt = DateTime.Now;
                actualqty = actualqty + adjqty;
                AdjustmentBizLogic.ApproveVoucher(itemId, actualqty, voucherId, dt, remarks);
            }
            //mail to employee who raised request
            String from = "teststationery47@gmail.com";
            String to = "yazh25894@gmail.com";
            String subject = "Voucher Status";
            String body = "Your Voucher has been approved.";

            MailBizLogic.sendMail(from, to, subject, body);

            //to generate popup page and then refresh page again
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Voucher Approved');window.location ='ManagerAdjVou.aspx';", true);            
        }
    }
}