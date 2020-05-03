using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.OTHER;

namespace planeaWeb {
    public partial class Planea : System.Web.UI.Page {
        private string nombre_usuario;
        
        /// <summary>
        /// Guarda las horas para posterior selección
        /// </summary>
        private void Add_Horas()
        {
            ArrayList horas = new ArrayList();
            
            for(int i=0; i<24; i++)
            {
                if(i < 10)
                {
                    horas.Add("0" + i + ":00");
                }
                else
                {
                    horas.Add(i + ":00");
                }
            }

            DropDownList3.DataSource = horas;
            DropDownList4.DataSource = horas;
            DropDownList3.DataBind();
            DropDownList4.DataBind();
        }

        /// <summary>
        /// Imprime los usuarios con las mismas preferencias y guarda las casillas de selección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            nombre_usuario = Request.QueryString["nomUsu"];
            Add_Horas();
            if(nombre_usuario != "" )
            {
                ENUsuario usuario = new ENUsuario();
                if(usuario.SeleccionarUsuario())
                {
                    List<ENUsuario> usuarioPreferencia = usuario.BuscarPreferencia();
                    lista_planea.Text = "";
                    ArrayList al = new ArrayList();
                    foreach(ENUsuario en in usuarioPreferencia)
                    { 
                       lista_planea.Text += "Nombre: '" + en.nombre + "' -- Nombre Usuario: '" +
                            en.nombre_usuario + "' -- Preferencia: '" + en.preferencia + "'<br />";
                        al.Add(en.nombre_usuario);
                    }
                    DropDownList1.DataSource = al;
                    DropDownList1.DataBind();

                    ENPlanes plan = new ENPlanes();
                    plan.Categoria = usuario.preferencia;
                    List<ENPlanes> planes = plan.BuscarPlanesPreferencia();
                    ArrayList al2 = new ArrayList();
                    foreach(ENPlanes planOut in planes)
                    {
                       al2.Add(planOut.Nombre); 
                    }

                    DropDownList2.DataSource = al2;
                    DropDownList2.DataBind();
                } 
                else
                {
                    errorPlanea.Text = "Nombre de usuario no existe";
                }
            } 
            else
            {
                errorPlanea.Text = "Nombre de usuario vacio";
            }
        }

        /// <summary>
        /// Comprueba los artibutos seleccionados, los guarda en un ENParejas y llama a InsertarPareja()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PlaneaFunction(object sender, EventArgs e)
        {
            string usuario = DropDownList1.SelectedItem.Text;
            string plan = DropDownList2.SelectedItem.Text;
            string hora_inicio = DropDownList3.SelectedItem.Text;
            string hora_fin = DropDownList4.SelectedItem.Text;
            DateTime dia = Calendar1.SelectedDate;
            if(DropDownList1.SelectedItem.Value != "0" && DropDownList2.SelectedItem.Value != "0" &&
                DropDownList3.SelectedItem.Value != "0" && DropDownList4.SelectedItem.Value != "0" &&
                !dia.ToString().Contains("01/01/0001"))
            {
                ENParejas pareja = new ENParejas();
                pareja.nombre_usuario_1 = nombre_usuario;
                pareja.nombre_usuario_2 = usuario;
                pareja.hora_inicio = Int32.Parse(hora_inicio[0 - 1].ToString());
                pareja.hora_fin = Int32.Parse(hora_fin[0 - 1].ToString());
                pareja.fecha = dia.ToString().Substring(0, 10);
                pareja.nombre_plan = plan;

                FormatoFiltrado filtrar = new FormatoFiltrado();
                string mensaje_filtro = filtrar.FiltradoPareja(pareja, false);
                if(mensaje_filtro == "TODO_OK")
                {
                   if(pareja.InsertarPareja())
                   {
                        errorPlanea.Text = "El plan se ha creado!";
                   } 
                   else
                   {
                        errorPlanea.Text = "El plan no se ha podido crear";
                   }
                } 
                else
                {
                    errorPlanea.Text = mensaje_filtro;
                }
            } 
            else
            {
                errorPlanea.Text = "No puedes dejar ningún atributo sin seleccionar";
            }
        }
    }
}