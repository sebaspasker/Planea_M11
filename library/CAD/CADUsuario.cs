﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library {
    class CADUsuario {
        private string constring;

        /// <summary>
        /// Constructor
        /// </summary>
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        /// <summary>
        /// Inserta el usuario en la BBDD tabla Usuarios.
        /// Comprueba que no haya ningún usuario con el mismo nombre_usuario y email
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool InsertarUsuario(ENUsuario usuario)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                // TODO evitar repeticion email
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = t.Rows.Count;
                nuevafila[1] = usuario.nombre;
                nuevafila[2] = usuario.apellidos;
                nuevafila[3] = usuario.nombre_usuario;
                nuevafila[4] = usuario.ciudad;
                nuevafila[5] = usuario.preferencia;
                nuevafila[6] = usuario.email;
                nuevafila[7] = usuario.edad;
                nuevafila[8] = usuario.password;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "usuarios");
                cambiado = true;
            }
            catch(Exception e) { cambiado = false; Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close();  }

            return cambiado;
        }

        /// <summary>
        /// Modifica el usuario en la BBDD tabla Usuarios.
        /// Comprueba que no haya ningún usuario con el mismo nombre_usuario y email
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ModificarUsuario(ENUsuario usuario, string categoria, string changed_value)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Hacer filtrado
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                SqlCommand command = new SqlCommand("update Usuarios set @categoria = @cambio_categoria where nombre_usuario = @nombre_usuario");
                command.Parameters.Add("@categoria", SqlDbType.NVarChar, 10).Value = categoria;
                if(categoria == "edad")
                {
                    command.Parameters.Add("@cambio_categoria", SqlDbType.Int).Value = usuario.edad;
                }
                else
                {
                    command.Parameters.Add("@cambio_categoria", SqlDbType.NVarChar).Value = changed_value;
                }
                DataAdapter.UpdateCommand = command;
                cambiado = true;
            } 
            catch(Exception e)
            {
                cambiado = false;
                Console.WriteLine(e.Message);
            } 
            finally
            {
                c.Close();
            }

            return cambiado;
        }

        /// <summary>
        /// Elimina el usuario en la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool BorrarUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Busca el usuario en la BBDD tabla Usuarios. 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool SeleccionarUsuario(ENUsuario usuario)
        {
            /*
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                // TODO
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                //t.Rows.Add(nuevafila);
                cambiado = true;
            }
            catch(Exception e) { cambiado = false; Console.WriteLine(e.Message + " " + e.ToString()); }
            finally { c.Close();  }

            return cambiado;*/
            return false;

        }

        /// <summary>
        /// Devuelve el primer usuario en la BBDD tabla Usuarios. 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool PrimerUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Devuelve el siguiente usuario al usuario pasado como parámetro en la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool SiguienteUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Devuelve el ultimo usuario de la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool UltimoUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Devuelve el anterior usuario al usuario pasado como parámetro de la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool AnteriorUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Devuelve una lista de usuarios de la BBDD tabla Usuarios.
        /// </summary>
        /// <returns></returns>
        public List<ENUsuario> ListarUsuarios()
        {
            // TODO
            return null;
        }

        /// <summary>
        /// Busca usuarios con la misma preferencia
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public List<ENUsuario> BuscarPreferencia(ENUsuario en)
        {
            // TODO
            return null;
        }
    }
}
