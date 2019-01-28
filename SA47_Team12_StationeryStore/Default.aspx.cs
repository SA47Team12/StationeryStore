using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace SA47_Team12_StationeryStore
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpID"] != null)
            {
                String id = HttpContext.Current.User.Identity.GetUserId();

                StationeryStoreEntities context = new StationeryStoreEntities();
                Employee emp = context.Employee.Where(x => x.Id == id).ToList().FirstOrDefault();
                if (emp != null)
                {
                    int empId = emp.EmployeeID;
                    int deptID = (int)emp.DepartmentID;
                    Session["EmpID"] = empId;
                    Session["DeptID"] = deptID;
                }
            }
        }
    }
}