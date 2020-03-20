using System;
using System.Web.UI.WebControls;
using CrmBl;

namespace CrmView
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
                PanelBuilder panelBuilder = new PanelBuilder(this);
            Button button = new Button();
                

            var panel = panelBuilder.GetPanel();

            panel.Controls.Add(button);
            
            
            
            //Form.Controls.AddAt(4,panel);
           
           
           // Response.Redirect("Price.aspx");
            
        }

        
    }
}