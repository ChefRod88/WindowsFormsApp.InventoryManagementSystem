using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public void addAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool removeAssociatedPart(int partID) => AssociatedParts.Remove(AssociatedParts.FirstOrDefault(p => p.PartID == partID));
        public Part lookupAssociatedPart(int partID) => AssociatedParts.FirstOrDefault(p => p.PartID == partID);
    }

}
