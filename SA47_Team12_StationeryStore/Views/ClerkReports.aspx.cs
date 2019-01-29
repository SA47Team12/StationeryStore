using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class ClerkReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReportButton_Click(object sender, EventArgs e)
        {
            if (ClerkReportsDropDownList.SelectedValue == "Item Stock")
            {
                Response.Redirect("~/Views/Clerk_ItemStockRpt.aspx");
            }

            else if (ClerkReportsDropDownList.SelectedValue == "Item Ordered")
            {
                Response.Redirect("~/Views/ClerkSup_ItemOrderedRpt.aspx");
            }
        }
    }
}