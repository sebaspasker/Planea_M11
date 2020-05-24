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
            catch(Exception e) { cambiado = false; }
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
            // TODO 
            return false;
        }

        /// <summary>
        /// Modifica una relación favorito-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool ModificarFavorito(ENFavoritos favorito)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Busca una relación favorito-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool LeerFavorito(ENFavoritos favorito)
        {
            // TODO 
            return false;
        }

        /// <summary>
        /// Lista todas las relaciones favorito-favorito de la tabla de Favoritos.
        /// </summary>
        /// <returns></returns>
        public List<ENFavoritos> ListarFavoritos()
        {
            // TODO
            return null;
        }

        public List<ENFavoritos> BuscarFavoritos(ENFavoritos fav)
        {
            // TODO
            return null;
        }
    }
}
