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
            string listaPlanes;
            String message;
            if (nombre.Text.Length >= 0 && nombre.Text.Length < max )
            {
                ENPlan plan = new ENPlan();
                plan.nombre = nombre.Text;

                if(listaPlanes.size()=0)
                {
                    message = "Lo sentimos pero no existe el plan que estás buscando en nuestra base de datos";
                    Response.Write(message);
                }
                for(ENPlanes plan: planes)
                {
                    listaPlanes= "Nombre: '" + plan.nombre + "' -- Precio: '"+ plan.precio + "' -- Ciudad: '"+ plan.ciudad "' -- Categoría: '"+ plan.categoria;
                    BuscaPlanR.Text+=listaPlanes;
                }
                
            }
        }

    }
}