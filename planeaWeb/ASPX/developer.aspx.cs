﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.UTILS;

namespace planeaWeb.ASPX {
    public partial class developer : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonInsertar_Click(object sender, EventArgs e)
        {
            // TODO meter campos manualmente
            ENUsuario usuario = new ENUsuario(TextBox2.Text, TextBox3.Text, TextBox1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, Int32.Parse(TextBox7.Text));
            usuario.password = TextBox8.Text;
            string mensaje = library.UTILS.Filter.filterRegistro(usuario);
            // TODO Comprobar repetición del email
            if(mensaje == "TODO_OK")
            {
                if(usuario.InsertarUsuario())
                {
                    Label1.Text = "Se ha insertado correctamente\n";
                } 
                else
                {
                    Label1.Text = "No se ha podido insertar el usuario\n";
                }
            } 
            else
            {
                Label1.Text = mensaje;
            }
        }

        protected void ButtonBorrar_Click(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre_usuario = TextBox1.Text;
            if(Filter.filterNombreUsuario(usuario.nombre_usuario)) {
                if(usuario.BorrarUsuario())
                {
                    Label1.Text = "Se ha borrado correctamente el usuario";
                } else
                {
                    Label1.Text = "No se ha podido eliminar el usuario";
                }
            }
            else
            {
                Label1.Text = "Formato nombre_usuario incorrecto";
            }
        }

        protected void ButtonInsertarPlan_Click(object sender, EventArgs e)
        {
            ENPlanes plan = new ENPlanes();
            plan.Nombre = TextBox9.Text;
            plan.Precio = Int32.Parse(TextBox10.Text);
            plan.Ciudad = TextBox11.Text;
            plan.Categoria = TextBox12.Text;
            string mensaje = Filter.FiltrarInsertarPlan(plan);
            if(mensaje == "TODO_OK")
            {
                if(plan.InsertarPlan())
                {
                    Label2.Text = "Se ha insertado correctamente";
                } 
                else
                {
                    Label2.Text = "No se ha podido insertar";
                }
            } 
            else
            {
                Label2.Text = mensaje;
            }
        }

        protected void ButtonEliminarPlan_Click(object sender, EventArgs e)
        {
            ENPlanes plan = new ENPlanes();
            plan.Nombre = TextBox9.Text;
            if(Filter.filterNombrePlan(plan.Nombre))
            {
                if(plan.BorrarPlan())
                {
                    Label2.Text = "El plan se ha borrado correctamente";
                } 
                else
                {
                    Label2.Text = "El plan no se ha podido borrar";
                }
            } 
            else
            {
                Label2.Text = "Formato incorrecto nombre plan";
            }
        }

        protected void ButtonInsertarPareja(object sender, EventArgs e)
        {
            ENParejas pareja = new ENParejas();
            pareja.nombre_usuario_1 = TextBox13.Text;
            pareja.nombre_usuario_2 = TextBox14.Text;
            pareja.nombre_plan = TextBox15.Text;
            pareja.hora_inicio = Int32.Parse(TextBox16.Text);
            pareja.hora_fin = Int32.Parse(TextBox17.Text);
            pareja.fecha = Calendar1.SelectedDate;
            pareja.plan_aceptado = TextBox18.Text;
            string mensaje = Filter.filterPareja(pareja);
            if(mensaje == "TODO_OK")
            {
                if(!pareja.SeleccionarPareja())
                {
                    if(pareja.InsertarPareja())
                    {
                        Error_Pareja.Text = "Se ha podido insertar correctamente la pareja";
                    }
                    else
                    {

                        Error_Pareja.Text = "No se ha podido insertar la pareja";
                    }
                }
                else
                {
                    Error_Pareja.Text = "La pareja ya existe";
                }
            } else
            {
                Error_Pareja.Text = mensaje;
            }
        }

        protected void ButtonBorrarPareja(object sender, EventArgs e)
        {

        }

        protected void ButtonBorrarFav(object sender, EventArgs e)
        {

        }

        protected void ButtonInsertarFav(object sender, EventArgs e)
        {
            ENFavoritos favorito = new ENFavoritos();
            favorito.nombre_usuario = TextBox19.Text;
            favorito.nombre_usuario_favorito = TextBox20.Text;
            string mensaje = Filter.filterFavorito(favorito);
            if(mensaje == "TODO_OK")
            {
                if(!favorito.SeleccionarFavorito())
                {
                    if(favorito.InsertarFavorito())
                    {
                        LabelErrorFav.Text = "El favorito se ha insertado correctamente";
                    }
                    else
                    {
                        LabelErrorFav.Text = "El favorito no se ha podido insertar";
                    }
                }
                else
                {
                    LabelErrorFav.Text = "El favorito ya existe";
                }
            }
            else
            {
                LabelErrorFav.Text = mensaje;
            }
        }
    }
}