using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace library {
    private string constring;
    class CADUsuario {
        string constring;

        /// <summary>
        /// Constructor
        /// </summary>
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
        }

        /// <summary>
        /// Inserta el usuario en la BBDD tabla Usuarios.
        /// Comprueba que no haya ningún usuario con el mismo nombre_usuario y email
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool InsertarUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Modifica el usuario en la BBDD tabla Usuarios.
        /// Comprueba que no haya ningún usuario con el mismo nombre_usuario y email
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ModificarUsuario(ENUsuario usuario)
        {
            // TODO
            return false;
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
            // TODO 
            return false;
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
                DataAdapter.Fill(bdvirtual, "plan");
                DataTable t = bdvirtual.Tables["usuarios"];
                DataRow dr = t.Rows[0];
                if (dr["nombre_usuario"].ToString() != "") { 
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
            catch (Exception e)
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
