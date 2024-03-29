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
using System.Web.UI.WebControls;

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
                if(t.Rows.Count != 0)
                {
                    nuevafila[0] = Int32.Parse(t.Rows[t.Rows.Count - 1]["id"].ToString()) + 1;
                } else
                {
                    nuevafila[0] = 0;
                }
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
        public bool ModificarUsuario(ENUsuario usuario)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Hacer filtrado
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                string criteria = "nombre_usuario='" + usuario.nombre_usuario + "'";
                DataRow[] rows = t.Select(criteria);
                if(rows.Length != 0 || rows != null)
                {
                    rows[0]["nombre"] = usuario.nombre;
                    rows[0]["apellidos"] = usuario.apellidos;
                    rows[0]["ciudad"] = usuario.ciudad;
                    rows[0]["preferencia"] = usuario.preferencia;
                    rows[0]["edad"] = usuario.edad;
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "usuarios");
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
            bool eliminado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            ENParejas pareja = new ENParejas();
            pareja.nombre_usuario_1 = usuario.nombre_usuario;
            pareja.BorrarPareja();
            ENFavoritos fav = new ENFavoritos();
            fav.nombre_usuario = usuario.nombre_usuario;
            fav.BorrarFavorito();
            ENFavoritos favorito = new ENFavoritos();
            try
            {
                // TODO Comprobar que existe el usuario primero y funcionamiento
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                dataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = bdvirtual.Tables["usuarios"];
                for(int i=t.Rows.Count-1; i>=0; i--)
                {
                    DataRow dr = t.Rows[i];
                    if(dr["nombre_usuario"].ToString() == usuario.nombre_usuario)
                    {
                        dr.Delete();
                        eliminado = true;
                        break;
                    }
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(bdvirtual, "usuarios");
            } 
            catch(Exception e)
            {
                eliminado = false;
                throw e;
            }
            finally
            {
                c.Close();
            }

            return eliminado;
        }

        /// <summary>
        /// Busca el usuario en la BBDD tabla Usuarios. 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool SeleccionarUsuario(ENUsuario usuario)
        {
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                string criteria = "nombre_usuario='" + usuario.nombre_usuario + "'";
                DataRow[] dataRows = t.Select(criteria);
                if(dataRows != null && dataRows.Length != 0)
                {
                    usuario.nombre = dataRows[0]["nombre"].ToString();
                    usuario.apellidos = dataRows[0]["apellidos"].ToString();
                    usuario.ciudad = dataRows[0]["ciudad"].ToString();
                    usuario.preferencia = dataRows[0]["preferencia"].ToString();
                    usuario.edad = Int32.Parse(dataRows[0]["edad"].ToString());
                    usuario.email = dataRows[0]["email"].ToString();
                    usuario.password = dataRows[0]["password"].ToString();
                    encontrado = true;
                }
            }
            catch(Exception e) { encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close();  }

            return encontrado;
        }

        /// <summary>
        /// Devuelve el primer usuario en la BBDD tabla Usuarios. 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool PrimerUsuario(ENUsuario usuario)
        {
            bool leido = false;
            SqlConnection conectar = new SqlConnection(constring);
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", conectar);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = bdvirtual.Tables["usuarios"];
                DataRow dr = t.Rows[0];
                if(dr != null)
                {
                    leido = true;
                    usuario.nombre = dr["nombre"].ToString();
                    usuario.apellidos = dr["apellidos"].ToString();
                    usuario.ciudad = dr["ciudad"].ToString();
                    usuario.preferencia = dr["preferencia"].ToString();
                    usuario.edad = Int32.Parse(dr["edad"].ToString());
                    usuario.email = dr["email"].ToString();
                    usuario.password = dr["password"].ToString();

                }
                else
                {
                    Console.WriteLine("No se pudo realizar el procedimiento");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No se pudo realizar el procedimiento", e.Message);
                throw e;
            }
            finally
            {
                conectar.Close();
            }
            return leido;
        }


        /// <summary>
        /// Devuelve el siguiente usuario al usuario pasado como parámetro en la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool SiguienteUsuario(ENUsuario usuario)
        {
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                string criteria = "nombre_usuario='" + usuario.nombre_usuario + "'";
                DataRow[] dataRows = t.Select(criteria);
                int posSiguiente=0;
                if(dataRows != null && dataRows.Length != 0)
                {
                    for(int i=0; i < t.Rows.Count - 1; i++)
                    {
                        DataRow db = t.Rows[i];
                        if (db["nombre_usuario"].ToString() == usuario.nombre_usuario)
                        {
                            posSiguiente = i+1;
                        }
                    }
                    if (posSiguiente != 0)
                    {
                        DataRow dr = t.Rows[posSiguiente];
                        if (dr != null)
                        {
                            encontrado = true;
                            usuario.nombre = dr["nombre"].ToString();
                            usuario.apellidos = dr["apellidos"].ToString();
                            usuario.ciudad = dr["ciudad"].ToString();
                            usuario.preferencia = dr["preferencia"].ToString();
                            usuario.edad = Int32.Parse(dr["edad"].ToString());
                            usuario.email = dr["email"].ToString();
                            usuario.password = dr["password"].ToString();

                        }
                    }
                }
            }
            catch(Exception e) { encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); 
                throw e; 
            }
            finally { c.Close(); }

            return encontrado;
        }

        /// <summary>
        /// Devuelve el ultimo usuario de la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool UltimoUsuario(ENUsuario usuario)
        {
            bool leido = false;
            SqlConnection conectar = new SqlConnection(constring);
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", conectar);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = bdvirtual.Tables["usuarios"];
                DataRow dr = t.Rows[t.Rows.Count - 1];
                if(dr != null)
                {
                    usuario.nombre = dr["nombre"].ToString();
                    usuario.apellidos = dr["apellidos"].ToString();
                    usuario.ciudad = dr["ciudad"].ToString();
                    usuario.preferencia = dr["preferencia"].ToString();
                    usuario.edad = Int32.Parse(dr["edad"].ToString());
                    usuario.email = dr["email"].ToString();
                    usuario.password = dr["password"].ToString();
                    leido = true;
                }
                else
                {
                    Console.WriteLine("No se pudo realizar el procedimiento");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No se pudo realizar el procedimiento", e.Message);
                throw e;
            }
            finally
            {
                conectar.Close();
            }
            return leido;
        }

        /// <summary>
        /// Devuelve el anterior usuario al usuario pasado como parámetro de la BBDD tabla Usuarios.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool AnteriorUsuario(ENUsuario usuario)
        {
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                string criteria = "nombre_usuario='" + usuario.nombre_usuario + "'";
                DataRow[] dataRows = t.Select(criteria);
                if(dataRows != null && dataRows.Length != 0)
                {
                    int posSiguiente = t.Rows.Count - 1;
                    for (int i = 0; i < t.Rows.Count - 1; i++)
                    {
                        DataRow db = t.Rows[i];
                        if (db["nombre_usuario"].ToString() == usuario.nombre_usuario)
                        {
                            posSiguiente = i - 1;
                        }
                    }
                    if (posSiguiente != t.Rows.Count - 1)
                    {
                        DataRow dr = t.Rows[posSiguiente];
                        if (dr["nombre_usuario"].ToString() != "")
                        {
                            encontrado = true;
                            usuario.nombre = dr["nombre"].ToString();
                            usuario.apellidos = dr["apellidos"].ToString();
                            usuario.ciudad = dr["ciudad"].ToString();
                            usuario.preferencia = dr["preferencia"].ToString();
                            usuario.edad = Int32.Parse(dr["edad"].ToString());
                            usuario.email = dr["email"].ToString();
                            usuario.password = dr["password"].ToString();

                        }
                    }
                }
            }
            catch(Exception e) { encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); 
            throw e;
            }
            finally { c.Close(); }

            return encontrado;
        }


        /// <summary>
        /// Devuelve una lista de usuarios de la BBDD tabla Usuarios.
        /// </summary>
        /// <returns></returns>
        public DataSet ListarUsuarios()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre, nombre_usuario, ciudad, preferencia from Usuarios where nombre_usuario != 'admin';", c);
            da.Fill(bdvirtual, "usuarios");
            return bdvirtual;
        }

        /// <summary>
        /// Busca usuarios con la misma preferencia
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public List<ENUsuario> BuscarPreferencia(ENUsuario en)
        {
            List<ENUsuario> usuarios = new List<ENUsuario>();
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Usuarios", c);
                DataAdapter.Fill(bdvirtual, "usuarios");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["usuarios"];
                string criteria = "preferencia like '" + en.preferencia + "'";
                DataRow[] dataRows = t.Select(criteria);
                if(dataRows != null && dataRows.Length != 0)
                {
                    foreach(DataRow row in dataRows) {
                        ENUsuario usuario = new ENUsuario();
                        usuario.nombre = row["nombre"].ToString();
                        usuario.nombre_usuario = row["nombre_usuario"].ToString();
                        usuario.apellidos = row["apellidos"].ToString();
                        usuario.ciudad = row["ciudad"].ToString();
                        usuario.preferencia = row["preferencia"].ToString();
                        usuario.edad = Int32.Parse(row["edad"].ToString());
                        usuario.email = row["email"].ToString();
                        usuarios.Add(usuario);
                    }
                }
            }
            catch(Exception e) { Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close(); }

            return usuarios;
        }

        public DataSet BuscarNombre(ENUsuario en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre, nombre_usuario, ciudad, preferencia from Usuarios where nombre like '%" + en.nombre + "%';", c);
            da.Fill(bdvirtual, "usuarios");
            return bdvirtual;
        }
    }
}
