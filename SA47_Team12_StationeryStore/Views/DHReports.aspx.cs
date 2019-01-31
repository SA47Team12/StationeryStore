using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class DHReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
        }

        protected void ReportButton_Click(object sender, EventArgs e)
        {
            if (DHReportsDropDownList.SelectedValue == "Requests Sort by Frequency")
            {
                Response.Redirect("~/Views/DH_GenerateReport.aspx");
            }

            else if (DHReportsDropDownList.SelectedValue == "Requests Sort by Total Amt")
            {
                Response.Redirect("~/Views/DH_GenerateReport2.aspx");
            }
        }
    }
}