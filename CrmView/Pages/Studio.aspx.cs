using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrmView.Pages
{
    public partial class Studio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelBuilder panelBuilder = new PanelBuilder(this);

            panelBuilder.High();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}