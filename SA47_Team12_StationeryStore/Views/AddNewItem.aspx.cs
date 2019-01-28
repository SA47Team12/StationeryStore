using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class AddNewItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
        }

        protected void AddNewButton_Click(object sender, EventArgs e)
        {
            string ItemID = ItemIdTextBox.Text;
            int CatID = Convert.ToInt32(CategoryDropDownList.SelectedItem.Value);
            string Item_Description = DescTextBox.Text;
            string UnitOfMeasure = UoMTextBox.Text;
            double UnitCost = Convert.ToDouble(UPTextBox.Text);
            int Priority1 = Convert.ToInt32(Priority1DropDownList.SelectedItem.Value);
            int Priority2 = Convert.ToInt32(Priority2DropDownList.SelectedItem.Value);
            int Priority3 = Convert.ToInt32(Priority3DropDownList.SelectedItem.Value);

            List<String> l = SupplierBizLogic.ListAllItem();
            Boolean check = true;
            for (int i = 0; i < l.Count; i++)
            {
                if (ItemID == l[i])
                {
                    check = false;

                }
            }
            if (check == true)
            {
                try
                {
                    SupplierBizLogic.AddItem(ItemID, CatID, Item_Description, UnitOfMeasure, UnitCost, Priority1,
                        Priority2, Priority3);
                    //Response.Redirect("Default2.aspx?username=" + user);
                    Response.Write("<script>alert('Item Added to Inventory!');</script>");
                    ItemIdTextBox.Text = "";
                    CategoryDropDownList.SelectedIndex = 0;
                    DescTextBox.Text = "";
                    UoMTextBox.Text = "";
                    UPTextBox.Text = "";
                    Priority1DropDownList.SelectedIndex = 0;
                    Priority2DropDownList.SelectedIndex = 0;
                    Priority3DropDownList.SelectedIndex = 0;

                    //send mail to clerk
                    String from = "teststationery47@gmail.com";
                    String to = "yazh25894@gmail.com";
                    String subject = "Added new item";
                    String body = "New item has been added to the inventory. Check inventory for further details.";

                    MailBizLogic.sendMail(from, to, subject, body);
                    //Response.Write("E-mail sent!");

                }
                catch (Exception exp)
                {
                    Response.Write(exp.ToString());
                }
            }
            else
            {
                Response.Write("<script>alert('Item Already Exist');</script>");
            }

        }

        protected void CategoryDropDownList_DataBound(object sender, EventArgs e)
        {
            DropDownList list = sender as DropDownList;
            if (list != null)
                list.Items.Insert(0, "--Select--");
        }

        protected void Priority1DropDownList_DataBound(object sender, EventArgs e)
        {
            DropDownList list = sender as DropDownList;
            if (list != null)
                list.Items.Insert(0, "--Select 1st Priority--");
        }

        protected void Priority2DropDownList_DataBound(object sender, EventArgs e)
        {
            DropDownList list = sender as DropDownList;
            if (list != null)
                list.Items.Insert(0, "--Select 2nd Priority--");
        }

        protected void Priority3DropDownList_DataBound(object sender, EventArgs e)
        {
            DropDownList list = sender as DropDownList;
            if (list != null)
                list.Items.Insert(0, "--Select 3rd Priority--");
        }
    }
}