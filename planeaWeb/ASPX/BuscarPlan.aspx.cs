using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class BuscarPlan : System.Web.UI.Page {
        /// <summary>
        /// Lista de planes
        /// </summary>
        private List<ENPlanes> listaPlanes;

        
        /// <summary>
        /// Page load que llama a la función BuscarSolicitudes y crea una lista de planes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ENPlanes planes = new ENPlanes();
            listaPlanes = planes.ListarPlanes();
        }

        /// <summary>
        /// Busca planes según el texto introducido por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBuscar2(object sender, EventArgs e)
        {
            BuscaPlanR.Text = "";
            ENPlanes plan = new ENPlanes();
            plan.Nombre = Nombre.Text;
            if (Nombre.Text.Length < 0 || Nombre.Text.Length > 20)
            {
                BuscaPlanR.Text = "El nombre tiene que tener entre 0 y 20 carácteres\n";
            }
            else {     
                for(int i = 0; i < listaPlanes.Count; i++)
                {
                    if (listaPlanes[i].Nombre.Contains(Nombre.Text)) {
                        BuscaPlanR.Text += "Nombre: " + listaPlanes[i].Nombre + " -- Precio: " + listaPlanes[i].Precio + " -- Ciudad: " + listaPlanes[i].Ciudad+ " -- Categoría: " + listaPlanes[i].Categoria + "<br />";
                    }
                }
                
            }
        }

    }
}