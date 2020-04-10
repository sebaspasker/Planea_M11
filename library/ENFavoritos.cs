using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    public class ENFavoritos {

        /// <summary>
        /// Nombre del usuario identidad
        /// Rango 0 <= x <= 12
        /// </summary>
        private string _nombre_usuario;
        public string nombre_usuario
        {
            set
            {
                _nombre_usuario = value;
            }

            get
            {
                return _nombre_usuario;
            }
        }

        /// <summary>
        /// Nombre del usuario el cual está dentro de los favoritos del usuario identidad.
        /// Rango 0 <= x <= 12
        /// </summary>
        private string _nombre_usuario_favorito;
        public string nombre_usuario_favorito
        {
            set
            {
                _nombre_usuario_favorito = value;
            }

            get
            {
                return _nombre_usuario_favorito;
            }
        }

        /// <summary>
        /// Constructor por defecto 
        /// </summary>
        public ENFavoritos() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre_usuario"></param>
        /// <param name="nombre_usuario_favorito"></param>
        public ENFavoritos(string nombre_usuario, string nombre_usuario_favorito)
        {
            this.nombre_usuario = nombre_usuario;
            this.nombre_usuario_favorito = nombre_usuario_favorito;
        }

        /// <summary>
        /// Inserta la relación de usuario-favorito en la tabla Favoritos. Llama a CADFavorito.
        /// Precisa de todos los atributos.
        /// </summary>
        /// <returns>true si ha podido insertar al favorito, si no false</returns>
        public bool InsertarFavorito()
        {
            CADFavoritos c = new CADFavoritos();
            return c.InsertarFavorito(this);
        }

        /// <summary>
        /// Elimina la relación de usuario-favorito en la tabla Favoritos. Llama a CADFavorito.
        /// Precisa de todos los atributos.
        /// </summary>
        /// <returns>true si ha podido eliminar al favorito, si no false</returns>
        public bool EliminarFavorito()
        {
            CADFavoritos c = new CADFavoritos();
            return c.EliminarFavorito(this);
        }

        /// <summary>
        /// Modifica la relación de usuario-favorito en la tabla Favoritos. Llama a CADFavorito.
        /// Precisa de todos los atributos.
        /// </summary>
        /// <returns>true si ha podido modificar al favorito, si no false</returns>
        public bool ModificarFavorito()
        {
            CADFavoritos c = new CADFavoritos();
            return c.ModificarFavorito(this);
        }

        /// <summary>
        /// Busca la relación de usuario-favorito en la tabla Favoritos. Llama a CADFavorito.
        /// Precisa de todos los atributos.
        /// </summary>
        /// <returns>true si ha podido encontrar al favorito, si no false</returns>
        public bool BuscarFavorito()
        {
            CADFavoritos c = new CADFavoritos();
            return c.BuscarFavorito(this);
        }

        /// <summary>
        /// Lista todas las relaciones usuario-favorito en la tabla de Favoritos. Llama a CADFavorito.
        /// No precisa de atributos
        /// </summary>
        /// <returns></returns>
        public List<ENFavoritos> ListarFavoritos()
        {
            CADFavoritos c = new CADFavoritos();
            return c.ListarFavoritos();
        }
    }
}
