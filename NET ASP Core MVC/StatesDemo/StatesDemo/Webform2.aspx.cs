using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatesDemo
{
    public partial class Webform2 : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["count"] != null) count = (int)Session["count"];
            lblCount.Text = count.ToString();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            count++;
            Session["count"] = count;
            lblCount.Text = count.ToString();
        }
    }
}