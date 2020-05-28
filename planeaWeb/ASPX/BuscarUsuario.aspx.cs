using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using System.Data;

namespace planeaWeb {
    public partial class BuscarUsuario : System.Web.UI.Page {
        /// <summary>
        /// Llama a una función que devuelve todos los usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ENUsuario en = new ENUsuario();
                DataSet data = en.ListarUsuarios();
                GridViewBusca.DataSource = data.Tables[0];
                GridViewBusca.DataBind();
            }
        }

        /// <summary>
        /// Imprime todos los usuarios que contienen el texto introducido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBuscarUsuario(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre = nombre.Text;
            BuscaUsuarioR.Text = "";
            if(nombre.Text.Length < 0 || nombre.Text.Length > 10)
            {
                BuscaUsuarioR.Text = "El nombre tiene que tener entre 0 y 10 carácteres\n";
            } 
            else
            {
                DataSet d = usuario.BuscarNombre();
                GridViewBusca.DataSource = d.Tables[0];
                GridViewBusca.DataBind();
            }
        }
    }
}