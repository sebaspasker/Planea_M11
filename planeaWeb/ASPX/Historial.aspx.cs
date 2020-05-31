using System;
using System.Collections.Generic;
using System.Data;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = Session["nombre_usuario"].ToString();
            if(!String.IsNullOrEmpty(usuario))
            {
                ENParejas pareja = new ENParejas();
                pareja.nombre_usuario_1 = usuario;
                DataSet data = pareja.BuscarParejas();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }
    }
}
