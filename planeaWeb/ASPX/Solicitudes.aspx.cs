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
                if(!String.IsNullOrEmpty(nombre_usuario)) {
                    if(library.UTILS.Filter.filterNombreUsuario(nombre_usuario))
                    {
                        solicitud.nombre_usuario_2 = nombre_usuario;
                        DataSet data = solicitud.BuscarSolicitudes();
                        GridView1.DataSource = data.Tables[0];
                        GridView1.DataBind();
                    }
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            ENParejas pareja = new ENParejas();
            pareja.nombre_usuario_1 = row.Cells[1].Text;
            pareja.nombre_plan = row.Cells[2].Text; 
            pareja.nombre_usuario_2 = Session["nombre_usuario"].ToString();
            if(pareja.SeleccionarPareja())
            {
                pareja.plan_aceptado = "yes";
                if(pareja.ModificarPareja())
                {
                    ErrorSolicitud.Text = "Plan aceptado!";
                } 
                else
                {
                    ErrorSolicitud.Text = "La pareja no se ha podido modificar";
                }
            }
            else
            {
                ErrorSolicitud.Text = "No existe la pareja" + pareja.nombre_usuario_1 + " " + pareja.nombre_usuario_2 + " " + pareja.nombre_plan;
            }
        }
    }
}