using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.UTILS;

namespace planeaWeb {
    public partial class Registro : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Comprueba el formato de todos los atributos y inserta el Usuario en caso de ser correcto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RegistrarseFunction(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nombre = TextNombre.Text;
            en.nombre_usuario = TextNombreUsuario.Text;
            en.apellidos = TextApellidos.Text;
            en.email = TextEmail.Text;
            en.edad = Int32.Parse(TextEdad.Text);
            en.ciudad = TextCiudad.Text;
            en.preferencia = TextPreferencia.Text;
            en.password = TextPasswd.Text;
            Filter filtraUsuario = new Filter();
            string mensajeFiltrado = filtraUsuario.FiltradoUsuario(en, false);

            if(mensajeFiltrado == "TODO_OK")
            {
               if(en.InsertarUsuario())
                {
                    Response.Redirect("~/ASPX/Login.aspx?agregado=" + Server.UrlEncode("True"));
                }
                else
                {
                    ErrorRegistro.Text = "Error, el usuario no ha podido ser agregado\n";
                    ErrorRegistro.Text = en.nombre + " " + en.apellidos + " " + en.nombre_usuario + " " + en.ciudad + " " + en.edad + " " + en.email + " " + en.password + " " + en.preferencia + "\n";
                }
            } 
            else
            {
                ErrorRegistro.Text = mensajeFiltrado + "\n";
            }
        }
    }
}