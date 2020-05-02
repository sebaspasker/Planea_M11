using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace planeaWeb {
    public partial class Favoritos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lista_favoritos(object sender, EventArgs e)
        {
            string listaFavoritos;
            String message;
            ENFavoritos favorito = new ENFavoritos();
            favorito.nombre_usuario_favorito = nombre_usuario_favorito.Text;

            if (lista_favoritos.size() < 0) 
            { 
                message = "Lo sentimos pero no tienes ningún usuario favorito";
                Response.Write(message);
            }
            for (ENFavoritos favorito: favoritos)
            {
                listaFavoritos = "Nombre: '" + favorito.nombre_usuario_favorito + "'";
                lista_favoritos.Text += listaFavoritos;
            }


        }
    }
}