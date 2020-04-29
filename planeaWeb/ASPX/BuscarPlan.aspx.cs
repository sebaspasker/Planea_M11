using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace planeaWeb {
    public partial class BuscarPlan : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonBuscar(object sender, EventArgs e)
        {
            String message;
            if (nombre.Text.Length >= 0)
            {
                ENPlan plan = new ENPlan();
                plan.nombre = nombre.Text;

                if (plan.SeleccionarPlan())
                {
                    message = "Lo sentimos pero no existe el plan que estás buscando en nuestra base de datos";
                    Response.Write(message);
                }
                
            }
        }

    }
}