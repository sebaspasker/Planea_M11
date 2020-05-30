using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.UTILS;

namespace planeaWeb {
    public partial class Solicitudes : System.Web.UI.Page {
        /// <summary>
        /// Imprime las solicitudes (planes) pendiente de confirmación de parte del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ENParejas solicitud = new ENParejas();
                string nombre_usuario = Session["nombre_usuario"].ToString();
                if(!String.IsNullOrEmpty(nombre_usuario))
                {
                    if(library.UTILS.Filter.filterNombreUsuario(nombre_usuario))
                    solicitud.nombre_usuario_2 = nombre_usuario;
                    DataSet data = solicitud.BuscarSolicitudes();
                    GridView1.DataSource = data.Tables[0];
                    GridView1.DataBind();
                }
                else
                {
                    // TODO
                    //Response.Redirect() 
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            ENParejas pareja = new ENParejas();
            pareja.nombre_usuario_1 = row.Cells[0].Text;
            pareja.nombre_plan = row.Cells[1].Text;
            pareja.nombre_usuario_2 = Session["nombre_usuario"].ToString();
            if(Filter.filterNombreUsuario(pareja.nombre_usuario_1) &&
                Filter.filterNombreUsuario(pareja.nombre_usuario_2) &&
                Filter.filterNombrePlan(pareja.nombre_plan))
            {
                if(pareja.SeleccionarPareja())
                {
                    pareja.plan_aceptado = "yes";
                    if(pareja.ModificarPareja())
                    {
                        // TODO Imprimir correcto
                    } 
                    else
                    {
                        // TODO Imprimir error
                    }
                }
                else
                {
                    // TODO Imprimir error
                }
            }
        }
    }
}