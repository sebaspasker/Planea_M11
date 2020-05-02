using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace planeaWeb
{
    public partial class Default2: System.Web.UI.MasterPage
    {
        string nombreUsuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            nombreUsuario = Request.QueryString["nomUsu"];
            FavoritosID.NavigateUrl += Server.UrlEncode(nombreUsuario);
            HistorialID.NavigateUrl += Server.UrlEncode(nombreUsuario);
            PlaneaID.NavigateUrl += Server.UrlEncode(nombreUsuario);
            Modificar_Perfil.NavigateUrl += Server.UrlEncode(nombreUsuario);
            Solicitudes.NavigateUrl += Server.UrlEncode(nombreUsuario);
        }
    }
}