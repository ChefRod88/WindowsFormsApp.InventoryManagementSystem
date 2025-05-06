using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public partial class formMainScreen : Form
    {
        public formMainScreen()
        {
            InitializeComponent();
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Parts_Add_Click(object sender, EventArgs e)
        {
            var addPartForm = new formAddParts();
            addPartForm.ShowDialog();
            dgvParts.DataSource = null;
            dgvParts.DataSource = Inventory.AllParts;
        }

        private void btn_Parts_Modify_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var modifyPartForm = new formAddProducts(selectedPart);
                modifyPartForm.ShowDialog();
                dgvParts.DataSource = null;
                dgvParts.DataSource = Inventory.AllParts;
            }
        }

        private void btn_Parts_Delete_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    foreach (var product in Inventory.Products)
                    {
                        if (product.AssociatedParts.Contains(selectedPart))
                        {
                            MessageBox.Show("Cannot delete a part that is associated with a product.");
                            return;
                        }
                    }
                    Inventory.deletePart(selectedPart);
                }
            }
        }

        private void btn_Parts_Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchParts.Text, out int id))
            {
                var part = Inventory.lookupPart(id);
                if (part != null)
                {
                    foreach (DataGridViewRow row in dgvParts.Rows)
                    {
                        if (row.DataBoundItem == part)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Part not found.");
            }
        }

        private void btn_Products_Add_Click(object sender, EventArgs e)
        {
            var addProductForm = new formAddParts();
            addProductForm.ShowDialog();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = Inventory.Products;
        }

        private void btn_Products_Modify_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                var modifyProductForm = new formModifyProducts(selectedProduct);
                modifyProductForm.ShowDialog();
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = Inventory.Products;
            }
        }

        private void btn_Products_Delete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selectedProduct)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Inventory.removeProduct(selectedProduct.ProductID);
                }
            }
        }

        private void btn_Products_Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchProducts.Text, out int id))
            {
                var product = Inventory.lookupProduct(id);
                if (product != null)
                {
                    foreach (DataGridViewRow row in dgvProducts.Rows)
                    {
                        if (row.DataBoundItem == product)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Product not found.");
            }
        }
    }
}
