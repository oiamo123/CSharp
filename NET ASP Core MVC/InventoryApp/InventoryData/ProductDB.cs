using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryData
{
    public static class ProductDB
    {
        // get all products

        public static List<Product> GetProducts()
        {
            using (InventoryData.masterEntities db = new InventoryData.masterEntities())
            {
                List<Product> products = db.Products.OrderBy(p => p.Name).ToList();
                return products;
            }
        }
    }
}
