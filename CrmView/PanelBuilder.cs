using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrmView
{
    public class PanelBuilder

    {

        public Panel GetPanel()
        {
            
            High();

            Panel panel = new Panel();

            Low();


            return panel;
        }
        private static Control SetButton(Control control, string text, string id, string cssClass)
        {
            control = new Button()
            {
                Text = text,
                ID = id,
                CssClass = cssClass
            };

            return control;
        }
        private static Control SetLabel(Control control, string text, string id, string cssClass)
        {
            control = new Label()
            {
                Text = text,
                ID = id,
                CssClass = cssClass
            };

            return control;
        }
        private static Control SetControl<T>(string id, string text, string cssClass)
            where T : Control
        {
            Control control = null;
            text = text.ToUpper();

            if (typeof(T) == typeof(Button))
            {
                control = SetButton(control, text, id, cssClass);
            }
            if (typeof(T) == typeof(Label))
            {
                control = SetLabel(control, text, id, cssClass);
            }
            return control;
        }
        private Page page { get; set; }
        public PanelBuilder(Page page)
        {
            if (page.Form != null)
            {
                this.page = page;
            }
            else
            {
                throw new Exception("На странице отсутствует форма");
            }
        }
        public  void High()
        {


            Panel panel = new Panel()
            {
                ID = "HighPanel",
                CssClass = "TopPanel"

            };

            
            
            var price = SetControl<Button>("Price", "Цена", "Menu Button");
            var portfolio = SetControl<Button>("Portfolio", "Портфолио", "Menu Button");
            var promo = SetControl<Button>("Promo", "Акции", "Menu Button");
            var studio = SetControl<Button>("Studio", "Студии", "Menu Button");
            var reviews = SetControl<Button>("Reviews", "Отзывы", "Menu Button");
            var order = SetControl<Button>("Order", "ЗАПИСАТЬСЯ / ОТМЕНИТЬ ЗАПИСЬ", "Order Button");


            List<Control> controls = new List<Control>()
            {

               order, 
                 price,portfolio,promo,studio,reviews
            };

            ((Button)price).Click += new EventHandler(Price_OnClick);
            ((Button)portfolio).Click += new EventHandler(Portfolio_OnClick);
            ((Button)promo).Click += new EventHandler(Promo_OnClick);
            ((Button)studio).Click += new EventHandler(Studio_OnClick);
            ((Button)reviews).Click += new EventHandler(Reviews_OnClick);
            ((Button)order).Click += new EventHandler(Order_OnClick);

            foreach (var control in controls)
            {
                panel.Controls.Add(control);
            }
            
            page.Form.Controls.Add(panel);



        }
        public void Low()
        {
            Panel panel = new Panel()
            {
                ID = "LowPanel",
                CssClass="LowPanel"

            };
            Control coorp = SetControl<Label>("Coorp", "(c)Лучший в мире салон.", "Coorp");

            List<Control> controls = new List<Control>()
            {
                coorp
            };

            foreach (var control in controls)
            {
                panel.Controls.Add(control);
            }

            page.Form.Controls.Add(panel);
            
        }
        private void Portfolio_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Portfolio.aspx");
        }
        private void Promo_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Promo.aspx");
        }
        private void Studio_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Studio.aspx");
        }
        private void Order_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Order.aspx");
        }
        public void Price_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Price.aspx");

        }
        private void Reviews_OnClick(object sender, EventArgs e)
        {
            page.Response.Redirect("Reviews.aspx");
        }
    }
}