using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class AddSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
        }

        protected void AddNewSupButton_Click(object sender, EventArgs e)
        {
            string name = SupplierName.Text;
            string add = SupplierAdd.Text;
            string phone = SupplierPhone.Text;

            {
                try
                {
                    SupplierBizLogic.AddSupplier(name, add, phone);
                    //Response.Redirect("Default2.aspx?username=" + user);
                    Response.Write("<script>alert('New Supplier has been Added!');</script>");
                    SupplierName.Text = "";
                    SupplierAdd.Text = "";
                    SupplierPhone.Text = "";
                }
                catch (Exception exp)
                {
                    Response.Write(exp.ToString());
                }
            }
        }
    }
}