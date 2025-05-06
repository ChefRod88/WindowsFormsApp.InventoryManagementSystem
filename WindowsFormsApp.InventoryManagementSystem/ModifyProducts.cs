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
    public partial class formModifyProducts : Form
    {
        private Product currentProduct;
        private BindingSource associatedParts;
        public formModifyProducts(Product product)
        {
            InitializeComponent();
            currentProduct = product;
            txtID.Text = product.ProductID.ToString();
            txtName.Text = product.Name;
            txtInventory.Text = product.InStock.ToString();
            txtPrice.Text = product.Price.ToString();
            txtMin.Text = product.Min.ToString();
            txtMax.Text = product.Max.ToString();
            txtID.ReadOnly = true;

            dgvAllCandidateParts.DataSource = Inventory.AllParts;
            associatedParts = new BindingSource { DataSource = new BindingList<Part>(product.AssociatedParts.ToList()) };
            dgvPartsAssociated.DataSource = associatedParts;

        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message);
                return;
            }

            Product updatedProduct = new Product
            {
                ProductID = currentProduct.ProductID,
                Name = txtName.Text,
                InStock = int.Parse(txtInventory.Text),
                Price = decimal.Parse(txtPrice.Text),
                Min = int.Parse(txtMin.Text),
                Max = int.Parse(txtMax.Text)
            };

            foreach (Part part in associatedParts.List)
            {
                updatedProduct.addAssociatedPart(part);
            }

            Inventory.updateProduct(currentProduct.ProductID, updatedProduct);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvAllCandidateParts.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                associatedParts.Add(selectedPart);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPartsAssociated.CurrentRow?.DataBoundItem is Part selectedPart)
            {
                var confirm = MessageBox.Show("Are you sure you want to disassociate this part?", "Confirm Remove", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchParts.Text, out int id))
            {
                var part = Inventory.lookupPart(id);
                if (part != null)
                {
                    foreach (DataGridViewRow row in dgvAllCandidateParts.Rows)
                    {
                        if (row.DataBoundItem == part)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                
            }
        }

        private bool ValidateInputs(out string message)
        {
            message = "";
            if (!int.TryParse(txtInventory.Text, out int inventory) ||
                !decimal.TryParse(txtPrice.Text, out _) ||
                !int.TryParse(txtMin.Text, out int min) ||
                !int.TryParse(txtMax.Text, out int max))
            {
                message = "Please enter valid numeric values.";
                return false;
            }

            if (min > max)
            {
                message = "Min must be less than Max.";
                return false;
            }

            if (inventory < min || inventory > max)
            {
                message = "Inventory must be between Min and Max.";
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
