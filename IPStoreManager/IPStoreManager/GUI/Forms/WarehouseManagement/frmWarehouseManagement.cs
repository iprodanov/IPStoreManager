using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.GUI.Forms.WarehouseManagement
{
    public partial class frmWarehouseManagement : Form
    {
        #region Members

        private BindingSource bsSuppliers, bsProducts;
        private List<Supplier> allSuppliers;
        private List<Product> supplierProducts;

        #endregion

        #region Constructors

        public frmWarehouseManagement()
        {
            InitializeComponent();
            bsSuppliers = new BindingSource();
            bsProducts = new BindingSource();
            dgvSuppliers.DataSource = bsSuppliers;
            dgvProducts.DataSource = bsProducts;
            dgvSuppliers.AutoGenerateColumns = false;
            dgvProducts.AutoGenerateColumns = false;
        }

        #endregion

        #region Methods

        private void LoadSuppliersData()
        {
            GetSuppliersData();
        }

        private void GetSuppliersData()
        {
            using (var db = new StoreManagerContext())
            {
                allSuppliers = db.Suppliers.ToList();
                bsSuppliers.DataSource = allSuppliers;
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
                GetProductsData(supplier);
            }
        }

        private void GetProductsData(Supplier supplier)
        {
            using (var db = new StoreManagerContext())
            {   
                var products = from p in db.Products
                               where p.SupplierID == supplier.SupplierID
                               select p;
                supplierProducts = products.ToList();
            }
            bsProducts.DataSource = supplierProducts;
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
            if (bsSuppliers.Current != null)
            {
                return (Supplier)bsSuppliers.Current;
            }
            return null;
        }

        private Product GetSelectedProduct()
        {
            if (bsProducts.Current != null)
            {   
                return (Product)bsProducts.Current;
            }
            return null;
        }

        private void RegisterShipment()
        {
            Product product = GetSelectedProduct();
            frmEditShippment frmEditShippment = new frmEditShippment(product);
            if (frmEditShippment.ShowDialog() == DialogResult.OK)
            {
                using (var db = new StoreManagerContext())
                {
                    Product originalProduct = (from p in db.Products
                                               where p.ProductID == product.ProductID
                                               select p).Single();

                    originalProduct.Stock = product.Stock;
                    db.SaveChanges();
                }
            }
        }

        private void AdjustControlsAvailability()
        {
            bool productSelected = bsProducts.Current != null;
            this.btnRegisterShippment.Enabled = productSelected;
        }

        #endregion

        #region Event Handlers

        private void frmWarehouseManagement_Load(object sender, EventArgs e)
        {   
            LoadSuppliersData();
            LoadProductsData();
            AdjustControlsAvailability();
            bsSuppliers.CurrentChanged += new EventHandler(bsSuppliers_CurrentChanged);
            bsProducts.CurrentChanged += new EventHandler(bsProducts_CurrentChanged);
        }

        private void bsSuppliers_CurrentChanged(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        private void bsProducts_CurrentChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tbSupplierName_TextChanged(object sender, EventArgs e)
        {
            ApplySupplierFilter();
        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            ApplyProductFilter();
        }

        private void btnClearSupplierName_Click(object sender, EventArgs e)
        {
            tbSupplierName.Text = String.Empty;
        }

        private void btnClearProductName_Click(object sender, EventArgs e)
        {
            tbProductName.Text = String.Empty;
        }

        private void btnRegisterShippment_Click(object sender, EventArgs e)
        {
            RegisterShipment();
            LoadProductsData();
        }

        #endregion
    }
}
