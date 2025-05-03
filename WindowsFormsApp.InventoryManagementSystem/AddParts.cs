using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public partial class formAddParts : Form
    {
        public formAddParts()
        {
            InitializeComponent();
            rdoInHouse.Checked = true;
            lblMachineOrCompany.Text = "Machine ID";
            txtID.Text = GenerateID().ToString();
            txtID.ReadOnly = true;
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
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string message))
            {
                MessageBox.Show(message);
                return;
            }

            Part newPart;
            if (rdoInHouse.Checked)
            {
                newPart = new Inhouse
                {
                    MachineID = int.Parse(txtMachineOrCompany.Text)
                };
            }
            else
            {
                newPart = new Outsourced
                {
                    CompanyName = txtMachineOrCompany.Text
                };
            }

            newPart.PartID = int.Parse(txtID.Text);
            newPart.Name = txtName.Text;
            newPart.InStock = int.Parse(txtInventory.Text);
            newPart.Price = decimal.Parse(txtPrice.Text);
            newPart.Min = int.Parse(txtMin.Text);
            newPart.Max = int.Parse(txtMax.Text);

            Inventory.addPart(newPart);
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

        private static int GenerateID()
        {
            return Inventory.AllParts.Count > 0 ? Inventory.AllParts.Max(p => p.PartID) + 1 : 1;
        }
    }
}
