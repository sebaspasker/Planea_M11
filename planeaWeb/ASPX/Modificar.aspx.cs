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
    public partial class Modificar : System.Web.UI.Page
    {
        private string nombre_usuario;
        /// <summary>
        /// Imprime los valores del usuario
        /// </summary>
        /// <param name="en"></param>
        private void Guardar_Valores(ENUsuario en)
        {
            Label1.Text = en.nombre;
            Label2.Text = en.apellidos;
            Label3.Text = en.nombre_usuario;
            Label4.Text = Convert.ToString(en.edad, 10);
            Label5.Text = en.preferencia;
            Label6.Text = en.ciudad;
        }
        
        /// <summary>
        /// Guarda el nombre de usuario y llama a SeleccionUsuario
        /// para imprimirlo a posteriori
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            nombre_usuario = Request.QueryString["nomUsu"];
            en.nombre_usuario = nombre_usuario;
            ErrorModificar.Text = en.nombre_usuario;
            if(!string.IsNullOrEmpty(en.nombre_usuario))
            {
                if(en.SeleccionarUsuario())
                {
                    Guardar_Valores(en);
                }
                else
                {
                    ErrorModificar.Text = "No existe el usuario";
                }
            } 
            else
            {
                ErrorModificar.Text = "Usuario vacio";
                // TODO Quitar
                // Response.Redirect("~/ASPX/Login.aspx");
            }
        }

        /// <summary>
        /// Mira cual es el valor a modificar y lo cambia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void FunctionModificar(object sender, EventArgs e)
        {
            ErrorModificar.Text = "";
            string valor_modificar = DropDownListModificar.SelectedItem.Text;
            string nuevo_valor = NuevoValorModificar.Text;
            ENUsuario en = new ENUsuario();
            en.nombre_usuario = nombre_usuario;
            if(en.nombre_usuario != "")
            {
                if(en.SeleccionarUsuario()) {
                    if(valor_modificar == "Nombre")
                    {
                        en.nombre = nuevo_valor;
                    }
                    else if(valor_modificar == "Contraseña")
                    {
                        en.password = nuevo_valor;
                    }
                    else if(valor_modificar == "Apellidos")
                    {
                        // TODO no lo cambia
                        en.apellidos = nuevo_valor;
                    }
                    else if(valor_modificar == "Edad")
                    {
                        en.edad = Int32.Parse(nuevo_valor);
                    }
                    else if(valor_modificar == "Preferencia")
                    {
                        en.preferencia = nuevo_valor;
                    }
                    else if(valor_modificar == "Ciudad")
                    {
                        en.ciudad = nuevo_valor;
                    }
                    // TODO Comprobar formato 
                    if(en.ModificarUsuario(valor_modificar.ToLower()))
                    {
                        Guardar_Valores(en);
                    } 
                    else
                    {
                        ErrorModificar.Text = "No se ha podido modificar al usuario";
                    }
                } 
                else
                {
                    ErrorModificar.Text = "Usuario vacio";
                }
            } 
            else
            {
                ErrorModificar.Text = "Usuario vacio";
            }
        }

        protected void Eliminar(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nombre_usuario = nombre_usuario;
            if(!String.IsNullOrEmpty(en.nombre_usuario))
            {
                if(en.BorrarUsuario())
                {
                    Response.Redirect("~/ASPX/principal1.aspx");
                } 
                else
                {
                    ErrorModificar.Text = "No se ha podido eliminar al usuario";
                }
            } 
            else
            {
                ErrorModificar.Text = "Usuario Vacio";
            }
        }
    }
}