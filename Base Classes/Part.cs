using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.InventoryManagementSystem
{
    public abstract class Part //Base Class all properties that are shared
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

}
