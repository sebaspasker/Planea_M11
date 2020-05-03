﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;
using library.OTHER;

namespace planeaWeb
{
    public partial class Modificar : System.Web.UI.Page
    {
        private string nombre_usuario;
        private void Guardar_Valores(ENUsuario en)
        {
            Label1.Text = en.nombre;
            Label2.Text = en.apellidos;
            Label3.Text = en.nombre_usuario;
            Label4.Text = Convert.ToString(en.edad, 10);
            Label5.Text = en.preferencia;
            Label6.Text = en.ciudad;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            nombre_usuario = Request.QueryString["nomUsu"];
            en.nombre_usuario = nombre_usuario;

            if(en.nombre_usuario != "")
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
            }
        }

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
                    else if(valor_modificar == "Apellido")
                    {
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

                    FormatoFiltrado filtrado = new FormatoFiltrado();
                    string mensaje_filtrado = filtrado.FiltradoUsuario(en, false);
                    if(mensaje_filtrado == "TODO_OK")
                    {
                        if(en.ModificarUsuario())
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
                        ErrorModificar.Text = mensaje_filtrado;
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
    }
}