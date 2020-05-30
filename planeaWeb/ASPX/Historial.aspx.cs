using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class Historial : System.Web.UI.Page {
        /// <summary>
        /// Devuelve los planes en el cual el usuario ha participado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*protected void Page_Load(object sender, EventArgs e)
        {
            historial_out.Text = "";
            ENParejas pareja = new ENParejas();
            string usuario = Request.QueryString["nomUsu"];
            
            if(usuario != "" && usuario != null)
            {
                if(usuario.Length < 13) {
                    pareja.nombre_usuario_1 = usuario;
                    List<ENParejas> parejas = pareja.BuscarParejas();

                    for(int i = 0; i < parejas.Count(); i++)
                    {
                        historial_out.Text += "Nombre usuario de la pareja: " + parejas[i].nombre_usuario_2 + " -- Plan: " +
                            parejas[i].nombre_plan + " -- Hora: " + parejas[i].hora_inicio + "-" + parejas[i].hora_fin + " -- fecha:" + 
                            parejas[i].fecha + "<br />";
                    }
                } 
            }*/
        }
   }
