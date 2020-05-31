using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library.UTILS;

namespace planeaWeb.ASPX {
    public partial class Webscrap : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string ciudad = TextBox2.Text;
            if(Filter.filterNombre(nombre) && Filter.filterCiudad(ciudad))
            {

            }
            else
            {

            }
        }
    }
}