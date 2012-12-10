using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPStoreManager.Security;

namespace IPStoreManager.GUI.Forms.SalesManagement
{
    public partial class frmSalesTerminal : Form
    {

        #region Members

        private Sale sale;
        private BindingSource bsSaleItems;
        private List<SaleItem> saleItems;

        #endregion

        #region Constructor

        public frmSalesTerminal()
        {
            InitializeComponent();
            saleItems = new List<SaleItem>();
            bsSaleItems = new BindingSource();
            dgvSaleItems.AutoGenerateColumns = false;
        }

        #endregion

        #region Methods

        private void BindSaleItemsData()
        {
            bsSaleItems.DataSource = saleItems;
            dgvSaleItems.DataSource = bsSaleItems;
            dgvSaleItems.Invalidate();
        }

        private void NewSale()
        {
            sale = new Sale();
            sale.UserID = SecurityManager.CurrentUser.ID;
            BindSaleItemsData();
        }

        private void ClearSale()
        {
            bsSaleItems.Clear();
            dgvSaleItems.Invalidate();
        }

        private void AddSale()
        {
            sale.SaleItems = saleItems;
            sale.SaleTimeStamp = DateTime.Now;
            using (var db = new StoreManagerContext())
            {
                foreach (SaleItem saleItem in sale.SaleItems)
                {
                    Product product = (from p in db.Products
                                       where p.ProductID == saleItem.ProductID
                                       select p).Single();
                    product.Stock -= saleItem.Quantity;
                    saleItem.Product = null;
                }
                db.Sales.Add(sale);
                db.SaveChanges();
            }
        }

        private void NewSaleItem()
        {
            SaleItem item = new SaleItem();
            frmEditSalesItem frmEditSaleItem = new frmEditSalesItem(item);
            if (frmEditSaleItem.ShowDialog() == DialogResult.OK)
            {
                bsSaleItems.Add(item);
                bsSaleItems.MoveLast();
                dgvSaleItems.Invalidate();
            }
            else
            {
                bsSaleItems.Remove(item);
            }
        }

        private void EditSaleItem()
        {
            SaleItem item = GetSelectedItem();
            if (item == null)
            {
                return;
            }

            frmEditSalesItem frmEditSaleItem = new frmEditSalesItem(item);
            if (frmEditSaleItem.ShowDialog() == DialogResult.OK)
            {
                bsSaleItems.EndEdit();
                dgvSaleItems.Invalidate();
            }
            else
            {
                bsSaleItems.CancelEdit();
            }
        }

        private void RemoveSaleItem()
        {
            SaleItem item = GetSelectedItem();
            if (item != null)
            {
                bsSaleItems.Remove(item);
                dgvSaleItems.Invalidate();
            }
        }

        private SaleItem GetSelectedItem()
        {
            if (bsSaleItems.Current != null)
            {
                return (SaleItem)bsSaleItems.Current;
            }
            return null;
        }

        private void UpdateTotal()
        {
            decimal total = saleItems.Sum(si => si.Product.Price * si.Quantity);
            tbTotal.Text = total.ToString();
        }

        private void AdjustControlAvailability()
        {
            this.tsbtnRemoveFromCart.Enabled = this.bsSaleItems.Current != null;
            this.tsbtnEditCartItem.Enabled = this.bsSaleItems.Current != null;
            this.btnSale.Enabled = this.bsSaleItems.Current != null;
        }

        #endregion

        #region Event Handlers

        private void frmSalesTerminal_Load(object sender, EventArgs e)
        {
            NewSale();
            AdjustControlAvailability();
            bsSaleItems.CurrentChanged += new EventHandler(bsSaleItems_CurrentChanged);
        }

        private void bsSaleItems_CurrentChanged(object sender, EventArgs e)
        {
            UpdateTotal();
            AdjustControlAvailability();
        }

        private void tsbtnAddToCart_Click(object sender, EventArgs e)
        {
            NewSaleItem();
        }

        private void tsbtnEditCartItem_Click(object sender, EventArgs e)
        {
            EditSaleItem();
            UpdateTotal();
        }

        private void tsbtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            RemoveSaleItem();
        }
        
        private void btnSale_Click(object sender, EventArgs e)
        {
            AddSale();
            ClearSale();
        }

        private void dgvSaleItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var saleItem = (SaleItem)row.DataBoundItem;
                    var product = saleItem.Product;
                    row.Cells[ProductNameColumn.Index].Value = product.Name;
                    row.Cells[PriceColumn.Index].Value = product.Price;
                    row.Cells[SupplierNameColumn.Index].Value = product.Supplier.Name;
                }
            }
        }

        #endregion
    }
}
