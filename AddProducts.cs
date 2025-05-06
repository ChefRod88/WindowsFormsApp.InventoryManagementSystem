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
    public partial class formAddProducts : Form
    {
        private BindingSource associatedParts = new BindingSource();

        public formAddProducts(Part selectedPart)
        {
            InitializeComponent();
            txtID.Text = GenerateID().ToString();
            txtID.ReadOnly = true;

            dgvAllCandidateParts.DataSource = Inventory.AllParts;
            associatedParts.DataSource = new BindingList<Part>();
            dgvPartsAssociated.DataSource = associatedParts;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message);
                return;
            }

            Product newProduct = new Product
            {
                ProductID = int.Parse(txtID.Text),
                Name = txtName.Text,
                InStock = int.Parse(txtInventory.Text),
                Price = decimal.Parse(txtPrice.Text),
                Min = int.Parse(txtMin.Text),
                Max = int.Parse(txtMax.Text)
            };

            foreach (Part part in associatedParts.List)
            {
                newProduct.addAssociatedPart(part);
            }

            Inventory.addProduct(newProduct);
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
                MessageBox.Show("Part not found.");
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

        private static int GenerateID()
        {
            return Inventory.Products.Count > 0 ? Inventory.Products.Max(p => p.ProductID) + 1 : 1;
        }

    }
}
