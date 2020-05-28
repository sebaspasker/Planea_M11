using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class BuscarPlan : System.Web.UI.Page {
        /// <summary>
        /// Page load que llama a la función BuscarSolicitudes y crea una lista de planes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ENPlanes plan = new ENPlanes();
                DataSet data = plan.ListarPlanes();
                GridView1.DataSource = data.Tables[0];
                GridView1.DataBind();
            }
        }

        /// <summary>
        /// Busca planes según el texto introducido por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBuscar2(object sender, EventArgs e)
        {
            ENPlanes plan = new ENPlanes();
            plan.Nombre = Nombre.Text;
            if(Page.IsValid)
            {
                DataSet d = plan.BuscarPlanes();
                GridView1.DataSource = d;
                GridView1.DataBind();
            } 
        }
    }
}