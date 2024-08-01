using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InventoryData;

namespace InventoryGUI
{
    public partial class Default : System.Web.UI.Page
    {
        // retrieve products data and display in grid views
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = InventoryData.ProductDB.GetProducts();
            gvProducts.DataSource = products;
            gvProducts.DataBind();
        }
    }
}