using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class Historial : System.Web.UI.Page {
        // TODO Comentar
        // TODO Hacer que le pasen en todos los redirect en nomUsu como variable
        protected void Page_Load(object sender, EventArgs e)
        {
            historial_out.Text = "";
            ENParejas pareja = new ENParejas();
            string usuario = Request.QueryString["nomUsu"];
            
            if(usuario != "")
            {
                if(usuario.Length > 12) {
                    pareja.nombre_usuario_1 = usuario;
                    List<ENParejas> parejas = pareja.BuscarParejas();

                    for(int i = 0; i < parejas.Count(); i++)
                    {
                        historial_out.Text += "Nombre usuario de la pareja: '" + parejas[i].nombre_usuario_2 + "' -- Plan: '" +
                            parejas[i].nombre_plan + "' -- Hora: '" + parejas[i].hora_inicio + "'-'" + parejas[i].hora_fin + "'<br />";
                    }
                } 
            }
        }
    }
}