using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.OTHER;

namespace planeaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// En caso que se registre el usuario devuelve un mensaje positivo tras 
        /// el redireccionamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string registrado = Request.QueryString["agregado"];
            if(registrado == "True")
            {
                OutputAgregado.Text = "El usuario ha sido agregado correctamente";
            } 
            else
            {
                OutputAgregado.Text = "";
            }
        }

        /// <summary>
        /// Si el usuario y la contraseña es correcta redirecciona a principal2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LoginFunction(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nombre_usuario = NombreUsuario.Text;
            
            FormatoFiltrado filtrado = new FormatoFiltrado();
            string mensaje_filtrado = filtrado.FiltradoUsuario(en, true);
            if(mensaje_filtrado == "TODO_OK")
            {
                if(en.SeleccionarUsuario())
                {
                    if(en.password == Password.Text)
                    {
                        Response.Redirect("~/ASPX/principal2.aspx?nomUsu=" + Server.UrlEncode(en.nombre_usuario) + "&login_bool=" + Server.UrlEncode("True"));
                    }
                    else
                    {
                        ErrorLogin.Text = "El usuario o contraseña es incorrecto1";
                    }
                }
                else
                {
                    ErrorLogin.Text = "El usuario u contraseña es incorrecto2";
                }
            } 
            else
            {
                ErrorLogin.Text = mensaje_filtrado;
            }
        }
    }
}