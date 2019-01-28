﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SA47_Team12_StationeryStore.BizLogic;

namespace SA47_Team12_StationeryStore.Views
{
    public partial class ManageInventory : System.Web.UI.Page
    {
        private List<Control> searchControls;
        private List<Control> stockCardControls;

        private void BindGrid()
        {
            InventoryGridView.DataSource = InventoryBizLogic.ListInventoryItem();
            InventoryGridView.DataBind();
        }

        //populate control lists for different views on the same page
        private void PopulateControlLists()
        {
            searchControls = new List<Control>();
            searchControls.Add(InventoryGridView);
            searchControls.Add(SearchCatRadioButtonList);
            searchControls.Add(SearchButton);
            searchControls.Add(SearchTextBox);

            stockCardControls = new List<Control>();
            stockCardControls.Add(StockCardsGridView);
        }

        //set visibility of the above control lists depending on which view is needed
        private void SetVisibilityofControlLists(string view)
        {
            if (view == "Search")
            {
                foreach (Control c in searchControls)
                {
                    c.Visible = true;
                }
                foreach (Control c in stockCardControls)
                {
                    c.Visible = false;
                }
            }
            else if (view == "StockCards")
            {
                foreach (Control c in searchControls)
                {
                    c.Visible = false;
                }
                foreach (Control c in stockCardControls)
                {
                    c.Visible = true;
                }
            }
        }

        // enum to represent options for RadSearch
        enum Radiobuttonoptions
        {
            ItemCode = 0,
            ItemCategory = 1
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["EmpID"] == null)
                Response.Redirect("/Account/Login.aspx");
            else
            {
                PopulateControlLists();

                if (!IsPostBack)
                {
                    
                    SetVisibilityofControlLists("Search");
                }
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchCatRadioButtonList.SelectedIndex == (int)Radiobuttonoptions.ItemCode) // Search By Item Code
            {
                InventoryGridView.DataSource = InventoryBizLogic.ListInventoryByItemCode(SearchTextBox.Text);
                InventoryGridView.DataBind();
            }

            else if (SearchCatRadioButtonList.SelectedIndex == (int)Radiobuttonoptions.ItemCategory) // Search By Item Category
            {
                InventoryGridView.DataSource = InventoryBizLogic.ListInventoryByItemCategory(SearchTextBox.Text);
                InventoryGridView.DataBind();
            }
        }

        private void BindGrid1()
        {
            string itemCode = InventoryGridView.DataKeys[InventoryGridView.SelectedRow.RowIndex].Values[0].ToString();
            StockCardsGridView.DataSource = InventoryBizLogic.GetStockCardsForItem(itemCode);
            StockCardsGridView.DataBind();
        }

        protected void InventoryGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show stock cards for selected item
            BindGrid1();
        }

        protected void InventoryGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Redirect to AdjustVoucher Page after clicking adjustvoucher button for an item
            if (e.CommandName == "AdjustVoucher")
            {
                GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);
                string itemCode = (row.FindControl("labelItemId_TemplateField") as Label).Text;
                Response.Redirect(string.Format("~/Views/RequestVoucherDetails.aspx?Id={0}", itemCode));
            }
        }

        protected void InventoryGridView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //set search view visibility to false
            SetVisibilityofControlLists("StockCards");
        }

        protected void InventoryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            InventoryGridView.PageIndex = e.NewPageIndex;
            InventoryGridView.DataBind();
            //BindGrid();
        }

        protected void StockCardsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            StockCardsGridView.PageIndex = e.NewPageIndex;
            StockCardsGridView.DataBind();
            //BindGrid1();
        }
    }
}