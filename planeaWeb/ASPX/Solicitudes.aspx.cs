using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class Solicitudes : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            ENParejas pareja = new ENParejas();
            pareja.BuscarSolicitudes();
            array.Add("Nombre de usuario: '" + pareja.nombre_usuario_1 + "' Plan: '" + pareja.nombre_plan + "' Hora inicio: '" + pareja.hora_inicio + "' Hora fin: '" + pareja.hora_fin + "'<br />");
            string usuario = Request.QueryString["nomUsu"];
            pareja.nombre_usuario_2 = usuario;
            pareja.BuscarSolicitudes(usuario);
            CheckBoxListSolicitudes.DataSource = array;
        }
    }
}