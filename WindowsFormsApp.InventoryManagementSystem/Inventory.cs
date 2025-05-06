using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        // Added a product to the list
        public static void addProduct(Product product) => Products.Add(product);

        // Removed a product by its ID
        public static void removeProduct(int productID)
        {
            var product = Products.FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                Products.Remove(product);
            }
        }

        // Lookup a product by its ID
        public static Product lookupProduct(int productID) => Products.FirstOrDefault(p => p.ProductID == productID);

        // Update a product in-place to trigger DataGridView binding
        public static void updateProduct(int productID, Product updatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updatedProduct;
                    break;
                }
            }
        }

        // Added a part to the list
        public static void addPart(Part part) => AllParts.Add(part);

        // Deleted a part from the list
        public static bool deletePart(Part part) => AllParts.Remove(part);

        // Lookup a part by its ID
        public static Part lookupPart(int partID) => AllParts.FirstOrDefault(p => p.PartID == partID);

        // Update a part in-place to trigger DataGridView binding
        public static void updatePart(int partID, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = updatedPart;
                    break;
                }
            }
        }
    }
}

