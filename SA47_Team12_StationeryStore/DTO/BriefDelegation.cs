﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SA47_Team12_StationeryStore
{
    public class BriefDelegation
    {
        public int DelegationID { get; set; }
        public int? EmpID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Name { get; set; }
       
    }
}