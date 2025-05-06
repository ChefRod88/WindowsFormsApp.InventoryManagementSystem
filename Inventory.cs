using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static void addProduct(Product product) => Products.Add(product);
        public static void removeProduct(int productID) => Products.Remove(Products.FirstOrDefault(p => p.ProductID == productID));
        public static Product lookupProduct(int productID) => Products.FirstOrDefault(p => p.ProductID == productID);
        public static void updateProduct(int productID, Product updatedProduct)
        {
            var index = Products.ToList().FindIndex(p => p.ProductID == productID);
            if (index >= 0) Products[index] = updatedProduct;
        }

        public static void addPart(Part part) => AllParts.Add(part);
        public static bool deletePart(Part part) => AllParts.Remove(part);
        public static Part lookupPart(int partID) => AllParts.FirstOrDefault(p => p.PartID == partID);
        public static void updatePart(int partID, Part updatedPart)
        {
            var index = AllParts.ToList().FindIndex(p => p.PartID == partID);
            if (index >= 0) AllParts[index] = updatedPart;
        }
    }

}
