using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace planeaWeb 
{
    public partial class Default1 : System.Web.UI.MasterPage {
        protected bool formato1(string path)
        {
            return path == "/ASPX/principal1.aspx"
                || path == "/ASPX/Login.aspx"
                || path == "/ASPX/Registro.aspx"
                || path == "/ASPX/BuscarPlan.aspx"
                || path == "/ASPX/BuscarUsuario.aspx"
                || path == "/ASPX/Webscrap.aspx"
                || path == "/ASPX/developer.aspx";
        } 
        protected void Page_Load(object sender, EventArgs e)
        {
            string absolutePath = HttpContext.Current.Request.Url.AbsolutePath;
            
            if(formato1(absolutePath))
            {
                Menu1.Items[0].Text = "Página principal";
                Menu1.Items[0].NavigateUrl= "~/ASPX/principal1.aspx";

                Menu1.Items[1].Text = "Login";
                Menu1.Items[1].NavigateUrl = "~/ASPX/Login.aspx";

                Menu1.Items[2].Text = "Registrarse";
                Menu1.Items[2].NavigateUrl = "~/ASPX/Registro.aspx";

                Menu1.Items[3].Text = "Buscar Plan";
                Menu1.Items[3].NavigateUrl = "~/ASPX/BuscarPlan.aspx";

                Menu1.Items[4].Text = "Buscar Usuario";
                Menu1.Items[4].NavigateUrl = "~/ASPX/BuscarUsuario.aspx";
            } 
            else 
            {
                Menu1.Items[0].Text = "Favoritos";
                Menu1.Items[0].NavigateUrl = "~/ASPX/Favoritos.aspx";

                Menu1.Items[1].Text = "Planea";
                Menu1.Items[1].NavigateUrl = "~/ASPX/Planea.aspx";

                Menu1.Items[2].Text = "Modificar perfil";
                Menu1.Items[2].NavigateUrl = "~/ASPX/Modificar.aspx";

                Menu1.Items[3].Text = "Historial";
                Menu1.Items[3].NavigateUrl = "~/ASPX/Historial.aspx";

                Menu1.Items[4].Text = "Solicitudes";
                Menu1.Items[4].NavigateUrl = "~/ASPX/Solicitudes.aspx";
            }
        }
    }
}