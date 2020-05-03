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

        //Page load, devuelve una lista de usuarios dentro de los favoritos del usuario
        protected void Page_Load(object sender, EventArgs e)
        {
            ENFavoritos favoritos = new ENFavoritos();
            listaFavoritos = favoritos.ListarFavoritos();
            favoritos.nombre_usuario_favorito = nombre_usuario.Text;
            string usuario = Request.QueryString["nomUsu"];

            if (usuario != "")
            {
                if (usuario.Length > 12)
                {
                    for (int i = 0; i < listaFavoritos.Count(); i++)
                    {
                        lista_favoritos.Text += "Nombre: '" + listaFavoritos[i].nombre_usuario_favorito + "'<br />";
                    }
                }
        }
    }
}