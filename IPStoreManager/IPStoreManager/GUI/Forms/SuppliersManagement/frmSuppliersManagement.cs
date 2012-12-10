using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.GUI.Forms.SuppliersManagement
{
    public partial class frmSuppliersManagement : Form
    {
        #region Members

        private BindingSource bsSuppliers, bsProducts;
        private List<Supplier> allSuppliers;
        private List<Product> supplierProducts;

        #endregion

        #region Constructors

        public frmSuppliersManagement()
        {
            InitializeComponent();
            bsSuppliers = new BindingSource();
            bsProducts = new BindingSource();
            BindSuppliersData();
            BindProductsData();
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
            }
            bsSuppliers.DataSource = allSuppliers;
        }

        private void BindSuppliersData()
        {   
            dgvSuppliers.DataSource = bsSuppliers;
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
                supplierProducts = (from p in db.Products
                                    where p.SupplierID == supplier.SupplierID
                                    select p).ToList();
            }
            bsProducts.DataSource = supplierProducts;
        }

        private void BindProductsData()
        {   
            dgvProducts.DataSource = bsProducts;
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

        private void NewSupplier()
        {
            Supplier supplier = new Supplier();
            frmEditSupplier frmEditSupplier = new frmEditSupplier(supplier);
            if (frmEditSupplier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var db = new StoreManagerContext())
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                }
            }
        }

        private void EditSupplier()
        {
            Supplier supplier = GetSelectedSupplier();
            frmEditSupplier frmEditSupplier = new frmEditSupplier(supplier);
            if (frmEditSupplier.ShowDialog() == DialogResult.OK)
            {
                using (var db = new StoreManagerContext())
                {
                    var originalSupplier = (from s in db.Suppliers
                                            where s.SupplierID == supplier.SupplierID
                                            select s).Single();

                    CloneSupplier(supplier, originalSupplier);
                    db.SaveChanges();
                }
            }
        }

        private void RemoveSupplier()
        {
            Supplier supplier = GetSelectedSupplier();
            using (var db = new StoreManagerContext())
            {
                Supplier supplierToRemove = (from s in db.Suppliers
                                             where s.SupplierID == supplier.SupplierID
                                             select s).Single();
                db.Suppliers.Remove(supplierToRemove);
                db.SaveChanges();
            }
        }

        private void NewProduct()
        {
            Product product = new Product();
            frmEditProduct frmEditProduct = new frmEditProduct(product);
            if (frmEditProduct.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Supplier supplier = GetSelectedSupplier();
                product.SupplierID = supplier.SupplierID;
                using (var db = new StoreManagerContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
            }
        }

        private void EditProduct()
        {
            Product product = GetSelectedProduct();
            frmEditProduct frmEditProduct = new frmEditProduct(product);
            if (frmEditProduct.ShowDialog() == DialogResult.OK)
            {
                using (var db = new StoreManagerContext())
                {
                    Product originalProduct = (from p in db.Products
                                               where p.ProductID == product.ProductID
                                               select p).Single();

                    CloneProduct(product, originalProduct);
                    db.SaveChanges();
                }
            }
        }

        private void RemoveProduct()
        {
            Product product = GetSelectedProduct();
            using (var db = new StoreManagerContext())
            {
                Product productToRemove = (from s in db.Products
                                           where s.ProductID == product.ProductID
                                           select s).Single();
                db.Products.Remove(productToRemove);
                db.SaveChanges();
            }
        }

        private void CloneSupplier(Supplier edited, Supplier original)
        {
            original.Name = edited.Name;
            original.Address = edited.Address;
        }

        private void CloneProduct(Product edited, Product original)
        {
            original.Name = edited.Name;
            original.Price = edited.Price;
            original.Description = edited.Description;
        }

        private void AdjustControlsAvailability()
        {
            bool supplierSelected = bsSuppliers.Current != null ? true : false;
            this.tsbtnEditSupplier.Enabled = supplierSelected;
            this.tsbtnRemoveSupplier.Enabled = supplierSelected;
            this.tsbtnNewProduct.Enabled = supplierSelected;

            bool productSelected = bsProducts.Current != null ? true : false;
            this.tsbtnEditProduct.Enabled = productSelected;
            this.tsbtnRemoveProduct.Enabled = productSelected;
        }

        #endregion

        #region Event Handlers

        private void frmSuppliersManagement_Load(object sender, EventArgs e)
        {
            LoadSuppliersData();
            LoadProductsData();
            AdjustControlsAvailability();
            bsSuppliers.CurrentChanged += new EventHandler(bsSuppliers_CurrentChanged);
            bsProducts.CurrentChanged += new EventHandler(bsProducts_CurrentChanged);
        }

        void bsSuppliers_CurrentChanged(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        void bsProducts_CurrentChanged(object sender, EventArgs e)
        {
            AdjustControlsAvailability();
        }

        private void tsbtnNewSupplier_Click(object sender, EventArgs e)
        {
            NewSupplier();
            LoadSuppliersData();
        }

        private void tsbtnEditSupplier_Click(object sender, EventArgs e)
        {
            EditSupplier();
            LoadSuppliersData();
        }

        private void tsbtnRemoveSupplier_Click(object sender, EventArgs e)
        {
            RemoveSupplier();
            LoadSuppliersData();
        }

        private void tsbtnNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct();
            LoadProductsData();
        }

        private void tsbtnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
            LoadProductsData();
        }

        private void tsbtnRemoveProduct_Click(object sender, EventArgs e)
        {
            RemoveProduct();
            LoadProductsData();
        }

        #endregion
    }
}
