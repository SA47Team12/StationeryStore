﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StationeryStoreEntities : DbContext
    {
        public StationeryStoreEntities()
            : base("name=StationeryStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CatalogueInventory> CatalogueInventory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Collection> Collection { get; set; }
        public virtual DbSet<Delegation> Delegation { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Disbursement> Disbursement { get; set; }
        public virtual DbSet<Outstanding> Outstanding { get; set; }
        public virtual DbSet<PO> PO { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestDetail> RequestDetail { get; set; }
        public virtual DbSet<SCCategory> SCCategory { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<UserRepCollection> UserRepCollection { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<VoucherDetail> VoucherDetail { get; set; }
        public virtual DbSet<StockCard> StockCard { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
