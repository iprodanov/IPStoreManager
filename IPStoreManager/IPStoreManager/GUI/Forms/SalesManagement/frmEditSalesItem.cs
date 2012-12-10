using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using IPStoreManager.Validation;

namespace IPStoreManager.GUI.Forms.SalesManagement
{
    public partial class frmEditSalesItem : Form
    {
        #region Members

        private SaleItem item;
        private List<Supplier> allSuppliers;
        private List<Product> supplierProducts;
        private BindingSource bsSuppliers, bsProducts;
        
        #endregion

        #region Constructors

        public frmEditSalesItem(SaleItem saleItem)
        {
            InitializeComponent();
            bsSuppliers = new BindingSource();
            bsProducts = new BindingSource();
            dgvSuppliers.DataSource = bsSuppliers;
            dgvProducts.DataSource = bsProducts;
            dgvSuppliers.AutoGenerateColumns = false;
            dgvProducts.AutoGenerateColumns = false;
            this.item = saleItem;
        }

        #endregion

        #region Methods

        private void SetFormInfo()
        {
            if (!IsEditItem())
            {
                this.Text = String.Format(this.Text, "New");
            }
            else
            {
                this.Text = String.Format(this.Text, "Edit");
                this.tbQuantity.Text = item.Quantity.ToString();
            }
        }

        private bool IsEditItem()
        {
            if (item.ItemID != 0)
            {
                return true;
            }
            return false;
        }

        private void MoveToEditedItemPosition()
        {
            bsSuppliers.MoveFirst();
            foreach (Supplier supplier in bsSuppliers)
            {
                if (supplier.SupplierID == item.Product.SupplierID)
                {
                    break;
                }
                else
                {
                    bsSuppliers.MoveNext();
                }
            }
        }

        private void LoadSuppliersData()
        {
            using (var db = new StoreManagerContext())
            {
                allSuppliers = db.Suppliers.ToList();
            }
            bsSuppliers.DataSource = allSuppliers;
            if (IsEditItem())
            {
                MoveToEditedItemPosition();
            }
        }

        private void LoadProductsData()
        {
            Supplier supplier = GetSelectedSupplier();
            if (supplier == null)
            {
                dgvProducts.Enabled = false;
            }
            else
            {
                supplierProducts = supplier.Products.ToList();
                bsProducts.DataSource = supplierProducts;
            }
        }

        private void ApplySupplierFilter()
        {
            FilterSuppliersData();
            if (bsSuppliers.Current != null)
            {
                ApplyProductFilter();
            }
        }

        private void FilterSuppliersData()
        {
            var suppliers = from s in allSuppliers
                            where s.Name.Contains(tbSupplierName.Text)
                            select s;
            bsSuppliers.DataSource = suppliers.ToList();
        }

        private void ApplyProductFilter()
        {
            FilterProducts();
        }

        private void FilterProducts()
        {
            var products = from p in supplierProducts
                           where p.Name.Contains(tbProductName.Text)
                           select p;
            bsProducts.DataSource = products.ToList();
        }
         
        private Supplier GetSelectedSupplier()
        {
            if(bsSuppliers.Current != null)
            {
                using (var db = new StoreManagerContext())
                {
                    Supplier supplier = (from s in db.Suppliers.Include("Products")
                                         where s.SupplierID == ((Supplier)bsSuppliers.Current).SupplierID
                                         select s).Single();
                    return supplier;
                }
            }
            return null;
        }

        private Product GetSelectedProduct()
        {
            if (bsProducts.Current != null)
            {
                using (var db = new StoreManagerContext())
                {
                    Product product = (from p in db.Products.Include("Supplier")
                                       where p.ProductID == ((Product)bsProducts.Current).ProductID
                                       select p).Single();
                    return product;
                }
            }
            return null;
        }

        private bool GetSaleItemInfo()
        {
            Product product = GetSelectedProduct();
            if (IsQuantityOnStock(product.Stock))
            {
                item.ItemID = 1;
                item.ProductID = product.ProductID;
                item.Product = product;
                item.Quantity = int.Parse(tbQuantity.Text);
                return true;
            }
            else
            {
                ShowMsgInsufficientStock(product.Stock);
                tbQuantity.Text = product.Stock.ToString();
                GetFocus(tbQuantity);
                return false;
            }
        }

        private bool IsQuantityOnStock(int stock)
        {
            if (int.Parse(tbQuantity.Text) < stock)
            {
                return true;
            }
            return false;
        }

        private void ShowMsgInsufficientStock(int stock)
        {
            MessageBox.Show(String.Format("Inssufficient stock! Only {0} pieces of this product left.",
                     stock), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void GetFocus(TextBox tb)
        {
            tb.Focus();
            tb.SelectAll();
        }

        private void AdjustControlsAvailability()
        {
            bool productSelected = bsProducts.Current != null;
            bool quantityMissing = TextBoxInput.MissingText(tbQuantity);
            this.btnOK.Enabled = (productSelected && !quantityMissing);
         }

        #endregion

        #region Event Handlers

        private void frmEditSalesItem_Load(object sender, EventArgs e)
        {
            SetFormInfo();
            LoadSuppliersData();
            LoadProductsData();
            TextBoxInput.InitializeErrorProvider();
            AdjustControlsAvailability();
            this.bsSuppliers.CurrentChanged += new EventHandler(bsSuppliers_CurrentChanged);
            this.bsProducts.CurrentChanged += new EventHandler(bsProducts_CurrentChanged);
        }

        private void bsSuppliers_CurrentChanged(object sender, EventArgs e)
        {
            LoadProductsData();
            GetFocus(tbQuantity);
        }

        private void bsProducts_CurrentChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
            GetFocus(tbQuantity);
        }

        private void tbSupplierName_TextChanged(object sender, EventArgs e)
        {
            ApplySupplierFilter();
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            ApplyProductFilter();
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (InputKey.ValidNumberKey(e))
            {
                e.SuppressKeyPress = false;
            }
        }

        private void btnClearSupplierFilter_Click(object sender, EventArgs e)
        {
            tbSupplierName.Text = String.Empty;
        }

        private void btnClearProductFilter_Click(object sender, EventArgs e)
        {
            tbProductName.Text = String.Empty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (GetSaleItemInfo())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
