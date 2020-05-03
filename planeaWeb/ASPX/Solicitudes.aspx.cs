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
        List<ENParejas> parejasSolicitud;
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckBoxListSolicitudes.Items.Clear();
            ArrayList array = new ArrayList();
            ENParejas pareja = new ENParejas();
            pareja.nombre_usuario_1 = Request.QueryString["nomUsu"];
            parejasSolicitud = pareja.BuscarSolicitudes();
            foreach(ENParejas en in parejasSolicitud)
            {
                array.Add(" Nombre de usuario: " + en.nombre_usuario_1 + " Plan: " + en.nombre_plan + " Hora inicio: " + en.hora_inicio + " Hora fin: " + en.hora_fin);
            }
            foreach(String arr in array) { 
                CheckBoxListSolicitudes.Items.Add(arr);
            }
        }

        protected void FunctionAgregarSolicitud(object sender, EventArgs e)
        {

            List<ENParejas> parejasAceptadas = new List<ENParejas>();
            for(int i=0; i<CheckBoxListSolicitudes.Items.Count; i++)
            {
                if(CheckBoxListSolicitudes.Items[i].Selected)
                {
                    parejasAceptadas.Add(parejasSolicitud[i]);
                }     
            }
            foreach(ENParejas pareja in parejasAceptadas)
            {
                pareja.plan_aceptado = true;
                pareja.ModificarPareja();
            }
        }
    }
}