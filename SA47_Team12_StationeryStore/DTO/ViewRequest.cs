using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA47_Team12_StationeryStore
{
    public class ViewRequest
    {
        int id;
        string empName;
        decimal? amount;
        DateTime? submittedTime;
        DateTime? approvedTime;
        string status;

        public ViewRequest()
        {

        }

        public ViewRequest(int id, string name, DateTime? submissionDate, DateTime? approvalDate, decimal? amt, string status)
        {
            this.RequestId = id;
            this.EmployeeName = name;
            this.Amount = amt;
            this.SubmittedTime = submissionDate;
            this.ApprovedTime = approvalDate;
            this.Status = status;
            //this.Remarks = remarks;
        }

        public int RequestId { get => id; set => id = value; }
        public string EmployeeName { get => empName; set => empName = value; }
        public decimal? Amount { get => amount; set => amount = value; }
        public DateTime? SubmittedTime { get => submittedTime; set => submittedTime = value; }
        public DateTime? ApprovedTime { get => approvedTime; set => approvedTime = value; }
        public string Status { get; set; }

        //public string Remarks { get; set; }
    }
}