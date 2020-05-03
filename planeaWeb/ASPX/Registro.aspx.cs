using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.OTHER;

namespace planeaWeb {
    public partial class Registro : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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
            FormatoFiltrado filtraUsuario = new FormatoFiltrado();
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
                }
            } 
            else
            {
                ErrorRegistro.Text = mensajeFiltrado + "\n";
            }
        }
    }
}