using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StatesDemo
{
    public partial class Webform1 : System.Web.UI.Page
    {
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["count"] != null) count = (int)ViewState["count"];
            lblCount.Text = count.ToString();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            count++;
            ViewState["count"] = count;
            lblCount.Text = count.ToString();
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {

        }
    }
}