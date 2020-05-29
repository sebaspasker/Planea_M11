using System;
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
    class CADFavoritos {
        private string constring;

        /// <summary>
        /// Constructor
        /// </summary>
        public CADFavoritos()
        {
            constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString(); 
        }

        /// <summary>
        /// Inserta la relacion favorito-favorito dentro de la tabla de Favoritos.
        /// Comprueba que no haya repetición.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns>true si ha podido añadir al favorito, sino false</returns>
        public bool InsertarFavorito(ENFavoritos favorito)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Favoritos", c);
                DataAdapter.Fill(bdvirtual, "favoritos");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["favoritos"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = t.Rows.Count;
                nuevafila[1] = favorito.nombre_usuario;
                nuevafila[2] = favorito.nombre_usuario_favorito;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "favoritos");
                cambiado = true;
            }
            catch(Exception e) { // TODO Temporal
                throw e; cambiado = false; }
            finally { c.Close();  }

            return cambiado;
        } 

        /// <summary>
        /// Elimina una relación favorito-favorito dentro de la tabla de Favoritos. 
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool BorrarFavorito(ENFavoritos favorito)
        {
            bool eliminado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Comprobar que existe el usuario primero y funcionamiento
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Favoritos", c);
                dataAdapter.Fill(bdvirtual, "favoritos");
                DataTable t = bdvirtual.Tables["favoritos"];
                for(int i=t.Rows.Count-1; i>=0; i--)
                {
                    DataRow dr = t.Rows[i];
                    if(dr["nombre_usuario"].ToString() == favorito.nombre_usuario)
                    {
                        dr.Delete();
                        eliminado = true;
                        break;
                    }
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(bdvirtual, "favoritos");
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
        /// Modifica una relación favorito-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool ModificarFavorito(ENFavoritos favorito)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Hacer filtrado
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Favoritos", c);
                DataAdapter.Fill(bdvirtual, "favorito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["favorito"];
                string criteria = "nombre='" + favorito.nombre_usuario + "'";
                DataRow[] rows = t.Select(criteria);
                if (rows.Length != 0 || rows != null)
                {
                    rows[0]["nombre_usuario"] = favorito.nombre_usuario;
                    rows[0]["nombre_usuario_favorito"] = favorito.nombre_usuario_favorito;
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "favoritos");
                cambiado = true;
            }
            catch (Exception e)
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
        /// Busca una relación favorito-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool LeerFavorito(ENFavoritos favorito)
        {
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Favoritos", c);
                DataAdapter.Fill(bdvirtual, "favorito");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["favorito"];
                string criteria = "nombre='" + favorito.nombre_usuario + "'";
                DataRow[] dataRows = t.Select(criteria);
                if (dataRows != null && dataRows.Length != 0)
                {
                    favorito.nombre_usuario = dataRows[0]["nombre_usuario"].ToString();
                    favorito.nombre_usuario_favorito = dataRows[0]["nombre_usuario_favorito "].ToString();
                    encontrado = true;
                }
            }
            catch (Exception e) { encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close(); }

            return encontrado;
        }

        /// <summary>
        /// Lista todas las relaciones favorito-favorito de la tabla de Favoritos.
        /// </summary>
        /// <returns></returns>
        public DataSet ListarFavoritos()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre_usuario, nombre_usuario_favorito from Favoritos", c);
            da.Fill(bdvirtual, "favoritos");
            return bdvirtual;
        }

        public DataSet BuscarFavoritos(ENFavoritos fav)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre_usuario_favorito from Favoritoss where nombre_usuario_favorito like '%" + fav.nombre_usuario_favorito + "%';", c);
            da.Fill(bdvirtual, "favoritos");
            return bdvirtual;
        }
    }
}
