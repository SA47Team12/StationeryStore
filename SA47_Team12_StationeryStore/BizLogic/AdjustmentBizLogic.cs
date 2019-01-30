using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SA47_Team12_StationeryStore.BizLogic
{
    public class AdjustmentBizLogic
    {
        public static List<VoucherListView> ListVouchers(string status)
        {
            using (StationeryStoreEntities context = new StationeryStoreEntities())
            {
                var voucherlist = context.Voucher.Where(vc => vc.Status.Contains(status)).AsEnumerable()
                .Select(vc => new VoucherListView //.Include(vc => vc.Employee)
                {
                    VoucherID = vc.VoucherID,
                    EmployeeName = vc.Employee.Name,
                    SubmissionDate = String.Format("{0:ddd, MMM d, yyyy}", vc.SubmissionDate),
                    Status = vc.Status,

                }).ToList();

                return voucherlist;
            }
        }

        public static List<VoucherDetailsView> ListVoucherDetails(int id)
        {
            decimal totalamt = 0;

            using (StationeryStoreEntities context = new StationeryStoreEntities())
            {
                var voucherdetail = context.VoucherDetail.Where(vd => vd.VoucherID == id)
                    .Select(vd => new VoucherDetailsView //Include(vd => vd.CatalogueInventory).
                    {
                    VoucherID = vd.VoucherID,
                    ItemName = vd.CatalogueInventory.Item_Description,
                    AdjQty = vd.AdjustedQty,
                    AdjAmt = vd.AdjustedAmt,
                    ItemID = vd.ItemID,
                    ActualQty = vd.CatalogueInventory.ActualQty,
                    Status = vd.Voucher.Status,
                    Reasons = vd.Remarks,
                    Remarks = vd.Voucher.Remarks
                }).ToList();

                return voucherdetail;
            }
        }

        public static void ApproveVoucher(string itemId, int actualqty, int voucherId, DateTime datetime, string remarks)
        {
            using (StationeryStoreEntities context = new StationeryStoreEntities())
            {
                var item = context.CatalogueInventory.Where(c => c.ItemID == itemId).Single();

                item.ActualQty = actualqty;

                var item2 = context.Voucher.Where(c => c.VoucherID == voucherId).Single();
                item2.Status = "Approved";
                item2.ApprovalDate = datetime;
                item2.Remarks = remarks;
                context.SaveChanges();
            }
        }
        public static void RejectVoucher(int voucherId, DateTime datetime, string remarks)
        {
            using (StationeryStoreEntities context = new StationeryStoreEntities())
            {
                var item = context.Voucher.Where(c => c.VoucherID == voucherId).Single();
                item.Status = "Rejected";
                item.ApprovalDate = datetime;
                item.Remarks = remarks;
                context.SaveChanges();
            }
        }
        public static void UpdateStatus(int voucherId)
        {
            using (StationeryStoreEntities context = new StationeryStoreEntities())
            {
                var item = context.Voucher.Where(c => c.VoucherID == voucherId).Single();

                item.Status = "Pending Manager Approval";

                context.SaveChanges();
            }
        }
    }
}