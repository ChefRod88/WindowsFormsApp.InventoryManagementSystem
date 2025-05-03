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
    public partial class formModifyParts : Form
    {
        private Part currentPart;
        public formModifyParts(Part part)
        {
            InitializeComponent();
            currentPart = part;
            txtID.Text = part.PartID.ToString();
            txtName.Text = part.Name;
            txtInventory.Text = part.InStock.ToString();
            txtPrice.Text = part.Price.ToString();
            txtMin.Text = part.Min.ToString();
            txtMax.Text = part.Max.ToString();
            txtID.ReadOnly = true;

            if(part is Inhouse inhouse)
            {
                rdoInHouse.Checked = true;
                txtMachineOrCompany.Text = inhouse.MachineID.ToString();
                lblMachineOrCompany.Text = "Machine ID";
            }
            else if (part is Outsourced outsourced)
            {
                rdoOutsourced.Checked = true;
                txtMachineOrCompany.Text = outsourced.CompanyName;
                lblMachineOrCompany.Text = "Company Name";
            }


        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineOrCompany.Text = "Machine ID";
        }

        private void rdoOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineOrCompany.Text = "Company Name";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message);
                return;
            }

            Part updatedPart;
            if (rdoInHouse.Checked)
            {
                updatedPart = new Inhouse
                {
                    MachineID = int.Parse(txtMachineOrCompany.Text)
                };
            }
            else
            {
                updatedPart = new Outsourced
                {
                    CompanyName = txtMachineOrCompany.Text
                };
            }

            updatedPart.PartID = currentPart.PartID;
            updatedPart.Name = txtName.Text;
            updatedPart.InStock = int.Parse(txtInventory.Text);
            updatedPart.Price = decimal.Parse(txtPrice.Text);
            updatedPart.Min = int.Parse(txtMin.Text);
            updatedPart.Max = int.Parse(txtMax.Text);

            Inventory.updatePart(currentPart.PartID, updatedPart);
            this.Close();
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

            if (rdoInHouse.Checked && !int.TryParse(txtMachineOrCompany.Text, out _))
            {
                message = "Machine ID must be numeric.";
                return false;
            }

            if (rdoOutsourced.Checked && string.IsNullOrWhiteSpace(txtMachineOrCompany.Text))
            {
                message = "Company Name is required.";
                return false;
            }

            return true;
        }
    }
}
