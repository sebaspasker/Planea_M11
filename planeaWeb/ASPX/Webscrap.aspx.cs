using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.UTILS;
using OpenQA.Selenium;

namespace planeaWeb.ASPX {
    public partial class Webscrap : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            string nombre = TextBox1.Text;
            string ciudad = TextBox2.Text;
            if(Filter.filterNombrePlan(nombre) && Filter.filterCiudad(ciudad))
            {
                IWebDriver driver = WebScraping.GetDriver();
                List<ENPlanes> planes = WebScraping.scrap(driver, nombre, ciudad);
                Label1.Text = "Has añadido: \n";
                foreach(ENPlanes plan in planes)
                {
                    if(Filter.filterNombre(plan.Nombre))
                    {
                        if(!plan.SeleccionarPlan())
                        {
                            if(plan.InsertarPlan())
                            {
                                Label1.Text += plan.Nombre + "\n";
                            }
                        } 
                    }
                }
            }
            else
            {
                Label1.Text = "Formato incorrecto";
            }
        }
    }
}