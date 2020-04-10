using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class CADFavoritos {
        private string constring;

        /// <summary>
        /// Constructor
        /// </summary>
        public CADFavoritos()
        {
            // constring =
            // TODO
            throw new Exception();
        }

        /// <summary>
        /// Inserta la relacion usuario-favorito dentro de la tabla de Favoritos.
        /// Comprueba que no haya repetición.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns>true si ha podido añadir al favorito, sino false</returns>
        public bool InsertarFavorito(ENFavoritos favorito)
        {
            // TODO
            return false;
        } 

        /// <summary>
        /// Elimina una relación usuario-favorito dentro de la tabla de Favoritos. 
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool EliminarFavorito(ENFavoritos favorito)
        {
            // TODO 
            return false;
        }

        /// <summary>
        /// Modifica una relación usuario-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool ModificarFavorito(ENFavoritos favorito)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Busca una relación usuario-favorito dentro de la tabla de Favoritos.
        /// </summary>
        /// <param name="favorito"></param>
        /// <returns></returns>
        public bool BuscarFavorito(ENFavoritos favorito)
        {
            // TODO 
            return false;
        }

        /// <summary>
        /// Lista todas las relaciones usuario-favorito de la tabla de Favoritos.
        /// </summary>
        /// <returns></returns>
        public List<ENFavoritos> ListarFavoritos()
        {
            // TODO
            return null;
        }
    }
}
