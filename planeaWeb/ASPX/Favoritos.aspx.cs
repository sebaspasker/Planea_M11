using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class Favoritos : System.Web.UI.Page {
        private List<ENFavoritos> listaFavoritos;

        /// <summary>
        /// Page load, devuelve una lista de usuarios dentro de los favoritos del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ENFavoritos favoritos = new ENFavoritos();
            favoritos.nombre_usuario = nombre_usuario.Text;
            listaFavoritos = favoritos.BuscarFavoritos();
            string usuario = Session["nombre_usuario"].ToString();
            nombre_usuario.Text = usuario;

            if(usuario != "" && usuario != null)
            {
                if(usuario.Length > 12)
                {
                    for(int i = 0; i < listaFavoritos.Count(); i++)
                    {
                        lista_favoritos.Text += "Nombre: '" + listaFavoritos[i].nombre_usuario_favorito + "'<br />";
                    }
                }
            }
        }
    }
}