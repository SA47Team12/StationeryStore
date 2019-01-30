using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class RequestVoucherDetails : System.Web.UI.Page
    {
        static string itemId;

        private void BindGrid()
        {

            RaiseVouReqGridView.DataSource = VoucherBizLogic.ListVoucherDetails((int)HttpContext.Current.Session["EmpID"]); // previously hardcoded as 1005
            RaiseVouReqGridView.DataBind();
            if (RaiseVouReqGridView.Rows.Count == 0)
            {
                RaiseVouReqButton.Visible = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
            else
            {
                if (!IsPostBack)
                {
                    if (!Request.Url.ToString().Contains("?Id")) // coming direct to request adjustment voucher page
                    {
                        // make add voucher detail page non-visible                    
                        Label1.Visible = false;
                        Label2.Visible = false;
                        Label3.Visible = false;

                        ItemCodeTextBox.Visible = false;
                        AdjQtyTextBox.Visible = false;
                        ReasonTextBox.Visible = false;

                        AddVouButton1.Visible = false;

                        // make raise request page visible
                        AddVouButton2.Visible = true;
                        RaiseVouReqGridView.Visible = true;
                        RaiseVouReqButton.Visible = true;
                        ViewPendingVouchersButton.Visible = true;

                        BindGrid();
                    }

                    else
                    {
                        itemId = Request.QueryString["Id"];  // retrieve query string from raise voucher button on manage inventory page
                        ItemCodeTextBox.Text = itemId;

                        //make raise request page non-visible // see UI screen
                        AddVouButton2.Visible = false;
                        RaiseVouReqGridView.Visible = false;
                        RaiseVouReqButton.Visible = false;
                        ViewPendingVouchersButton.Visible = false;
                    }
                }
            }
        }

        protected void AddVouButton1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) // CustomValidator1.IsValid
            {
                // add voucher detail and retrieve list of voucher details not yet raised
                itemId = ItemCodeTextBox.Text;
                int adjustedQty = Convert.ToInt32(AdjQtyTextBox.Text);
                string Remarks = ReasonTextBox.Text;

                VoucherBizLogic.CreateVoucherDetail(itemId, adjustedQty, Remarks, (int)HttpContext.Current.Session["EmpID"]);// previously hardcoded employeeid as 1005; to retrieve employeeID from login later
                BindGrid();

                // make add voucher detail page non-visible
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;

                ItemCodeTextBox.Visible = false;
                AdjQtyTextBox.Visible = false;
                ReasonTextBox.Visible = false;

                AddVouButton1.Visible = false;

                // make raise request page visible
                AddVouButton2.Visible = true;
                RaiseVouReqGridView.Visible = true;
                RaiseVouReqButton.Visible = true;
                ViewPendingVouchersButton.Visible = true;
            }
        }

        protected void AddVouButton2_Click(object sender, EventArgs e)
        {
            ItemCodeTextBox.Text = "";
            ItemCodeTextBox.ReadOnly = false; // when coming to add voucher detail page from direct route, not the click adjust voucher button route
            AdjQtyTextBox.Text = "";
            ReasonTextBox.Text = "";


            // make add voucher detail page visible
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            ItemCodeTextBox.Visible = true;
            AdjQtyTextBox.Visible = true;
            ReasonTextBox.Visible = true;
            AddVouButton1.Visible = true;

            // make raise request page non-visible
            AddVouButton2.Visible = false;
            RaiseVouReqGridView.Visible = false;
            RaiseVouReqButton.Visible = false;
            ViewPendingVouchersButton.Visible = false;
        }

        //to raise request
        protected void RaiseVouReqButton_Click(object sender, EventArgs e)
        {
            BindGrid();
            if (RaiseVouReqGridView.Rows.Count != 0)
            {
                int EmpID = (int)HttpContext.Current.Session["EmpID"];
                VoucherBizLogic.CreateVoucher(EmpID);
                Response.Redirect("~/Views/PendingVouchers.aspx");
            }
            else
            {
                RaiseVouReqButton.Visible = false;
                Response.Write("<script>alert('No voucher items to add');</script>");
            }
        }

        protected void RaiseVouReqGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int voucherDetailId = Convert.ToInt32(RaiseVouReqGridView.DataKeys[e.RowIndex].Values[0]);
            VoucherBizLogic.DeleteVoucherDetail(voucherDetailId);
            BindGrid();
        }

        protected void RaiseVouReqGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            RaiseVouReqGridView.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void RaiseVouReqGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            RaiseVouReqGridView.EditIndex = -1;
            BindGrid();
        }

        protected void RaiseVouReqGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = RaiseVouReqGridView.Rows[e.RowIndex];
            int voucherDetailId = Convert.ToInt32(RaiseVouReqGridView.DataKeys[e.RowIndex].Values[0]);
            int adjustedQty = Convert.ToInt32((row.FindControl("TextBox1") as TextBox).Text);
            string remarks = (row.FindControl("TextBox2") as TextBox).Text;
            VoucherBizLogic.UpdateVoucherDetail(voucherDetailId, adjustedQty, remarks);

            RaiseVouReqGridView.EditIndex = -1;
            BindGrid();
        }

        // Check if itemCode entered is valid or not
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string itemId = args.Value;

            if (CatalogueBizLogic.CheckIfItemExists(itemId))
            {
                args.IsValid = true;
            }

            else
            {
                args.IsValid = false;
            }
        }

        protected void RaiseVouReqGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RaiseVouReqGridView.DataSource = VoucherBizLogic.ListVoucherDetails((int)HttpContext.Current.Session["EmpID"]); // previously hardcoded as 1005
            RaiseVouReqGridView.PageIndex = e.NewPageIndex;
            RaiseVouReqGridView.DataBind();
            BindGrid();
        }

        protected void ViewPendingVouchersButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/PendingVouchers.aspx");
        }
    }
}