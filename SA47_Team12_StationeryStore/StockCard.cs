//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA47_Team12_StationeryStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockCard
    {
        public int TransactionID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string ItemID { get; set; }
        public Nullable<int> SCCatID { get; set; }
        public string Description { get; set; }
        public Nullable<int> AdjustedQty { get; set; }
    
        public virtual CatalogueInventory CatalogueInventory { get; set; }
        public virtual SCCategory SCCategory { get; set; }
    }
}