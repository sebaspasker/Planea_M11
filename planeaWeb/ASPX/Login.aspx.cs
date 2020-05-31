using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.UTILS;

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

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if(Filter.filterNombreUsuario(Login1.UserName) && Filter.filterPassword(Login1.Password))
            {
                bool login = library.UTILS.Login.loginUsuario(Login1.UserName, Login1.Password);
                bool admin = library.UTILS.Login.loginAdmin(Login1.UserName, Login1.Password);
                e.Authenticated = login;
                if(login)
                {
                    Session["nombre_usuario"] = Login1.UserName;
                    Response.Redirect("~/ASPX/principal2.aspx");
                } 
                else if(admin)
                {
                    Response.Redirect("~/ASPX/developer.aspx");
                }
            } 
            else
            {
                e.Authenticated = false;
                ErrorLogin.Text = "Formato incorrecto: el usuario (max tamaño 12) y la contraseña (max tamaño 20) pueden\n" +
                    "contener letras, '_', '-' y números\n";
            }
        }
    }
}