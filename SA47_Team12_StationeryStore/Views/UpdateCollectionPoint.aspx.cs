using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;
using System.Net.Mail;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class UpdateCollectionPoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
            else
            {
                int DepID = (int)HttpContext.Current.Session["DeptID"];
                if (!this.IsPostBack)
                {
                    BindData(DepID);
                }
            }
        }

        protected bool IsDelegated()
        {
            int empID = (int)HttpContext.Current.Session["EmpID"];
            DateTime today = DateTime.Now.Date;
            StationeryStoreEntities context = new StationeryStoreEntities();

            Employee emp = context.Employee.Where(x => x.EmployeeID == empID).ToList().FirstOrDefault();
            Delegation d = context.Delegation.Where(x => x.DepartmentID == emp.DepartmentID && (x.StartDate <= today && x.EndDate >= today)).FirstOrDefault();
            if (d != null) return true;
            else return false;
        }

        protected void BindData(int DepID)
        {
            Label1.Text = SupplierBizLogic.FindCollectionByDepID(DepID).CollectionPoint.ToString();
            CPRadioButtonList.SelectedValue = SupplierBizLogic.FindCollectionByDepID(DepID).CollectionPointID.ToString();

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            //int DepID = 2001;
            int DepID = (int)HttpContext.Current.Session["DeptID"];
            int NewCollectionID = Convert.ToInt32(CPRadioButtonList.SelectedValue);

            UserRepCollection updatedDeptURCollection = new UserRepCollection { }; // must declare a variable here first before using it in try block or else not detectable

            try
            {
                updatedDeptURCollection = SupplierBizLogic.UpdateURcollectiontableCollection(DepID, NewCollectionID); // changed this to return a userrepcollection object
                Response.Write("<script>alert('Collection Point updated!');</script>");
            }
            catch (Exception exp)
            {
                Response.Write(exp.ToString());
            }

            // added code below:
            try
            {
                //to clerk
                string oldCollection = Label1.Text;
                String from = "teststationery47@gmail.com";
                String to1 = "sithulinhtut16@gmail.com";
                String to2 = "yanyuhan96@gmail.com";
                String to3 = "shree.sri23@gmail.com";
                String subject = String.Format("[Auto Notification] Changes on Collection Point for {0}", updatedDeptURCollection.Department.Description);
                String body = String.Format("Collection Point For '{0}' has been changed from '{1}' to '{2}'.\n\nThis is a system generated email, please do not reply", updatedDeptURCollection.Department.Description, oldCollection, updatedDeptURCollection.Collection.Location);

                MailBizLogic.sendMail(from, to1, subject, body);
                MailBizLogic.sendMail(from, to2, subject, body);
                MailBizLogic.sendMail(from, to3, subject, body);

            }
            catch (Exception ex)
            {
                Response.Write("Could not send the e-mail - error: " + ex.Message);
            }
        }
    }
}