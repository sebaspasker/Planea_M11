using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    public class ENUsuario {
        /// <summary>
        /// Nombre del usuario
        /// Rango 0 <= nombre <= 10
        /// </summary>
        private string _nombre;
        public string nombre
        {
            set
            {
                _nombre = value;
            }

            get
            {
                return _nombre;
            }
        }

        /// <summary>
        /// Apellidos del usuario
        /// Rango 0 <= nombre <= 20
        /// </summary>
        private string _apellidos;
        public string apellidos
        {
            set
            {
                _apellidos = value; 
            }

            get
            {
                return _apellidos;
            }
        }

        /// <summary>
        /// Nombre de usuario
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
        /// Ciudad a la que pertenece el usuario
        /// </summary>
        private string _ciudad;
        public string ciudad
        {
            set
            {
                _ciudad = value;
            }

            get
            {
                return _ciudad; 
            }
        }

        /// <summary>
        /// Categoria de preferencia del usuario (predeterminado)
        /// Rango 0 <= x <= 12
        /// </summary>
        private string _preferencia;
        public string preferencia
        {
            set
            {
                _preferencia = value;
            }

            get
            {
                return _preferencia;
            }
        }

        /// <summary>
        /// Email del usuario
        /// Rango 0 <= x <= 12
        /// </summary>
        private string _email;
        public string email
        {
            set
            {
                _email = value;
            }

            get
            {
                return _email; 
            }
        }

        /// <summary>
        /// Edad del usuario
        /// Rango 0 <= x 
        /// </summary>
        private int _edad;
        public int edad
        {
            set
            {
                _edad = value;
            }

            get
            {
                return _edad;
            }
        }

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        private string _password;
        public string password
        {
            get 
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }


        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENUsuario()
        {
            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="ap"></param>
        /// <param name="nom_usu"></param>
        /// <param name="ciu"></param>
        /// <param name="pre"></param>
        /// <param name="em"></param>
        /// <param name="ed"></param>
        public ENUsuario(string nom, string ap, string nom_usu, string ciu, string pre, string em, int ed)
        {
            this.nombre = nom;
            this.apellidos = ap;
            this.nombre_usuario = nom_usu;
            this.ciudad = ciu;
            this.preferencia = pre;
            this.email = em;
            this.edad = ed;
        }

        /// <summary>
        /// Inserta el usuario en la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// Requiere de todos los atributos.
        /// </summary>
        /// <returns>true si consigue insertar el usuario, sino false</returns>
        public bool InsertarUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.InsertarUsuario(this);
        }

        /// <summary>
        /// Modifica el usuario en la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// Requiere de todos los atributos.
        /// </summary>
        /// <returns>true si consigue modificar el usuario, sino false</returns>
        public bool ModificarUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.ModificarUsuario(this);
        }

        /// <summary>
        /// Elimina el usuario en la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// Requiere del nombre_usuario
        /// </summary>
        /// <returns>true si consigue eliminar al usuario, sino false</returns>
        public bool BorrarUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.BorrarUsuario(this);
        }

        /// <summary>
        /// Busca el usuario en la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// Requiere del nombre_usuario
        /// </summary>
        /// <returns>true si consigue encontrar al usuario, sino false</returns>
        public bool SeleccionarUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.SeleccionarUsuario(this);
        }

        /// <summary>
        /// Devuelve el primer usuario de la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// No requiere de atributos
        /// </summary>
        /// <returns>true si consigue encontrar el primer usuario, sino false</returns>
        public bool PrimerUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.PrimerUsuario(this);
        }

        /// <summary>
        /// Devuelve el siguiente usuario del usuario pasado en la BBDD en la tabla Usuarios. Llama a CADUsuario.
        /// Requiere de nombre_usuario
        /// </summary>
        /// <returns>true si consigue encontrar el siguiente usuario, sino false</returns>
        public bool SiguienteUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.SiguienteUsuario(this);
        }

        public bool AnteriorUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.AnteriorUsuario(this);
        }

        /// <summary>
        /// Devuelve el último usuario de la BBDD de la tabla Usuarios. Llama a CADUsuarios.
        /// Require del nombre_usuario
        /// </summary>
        /// <returns>true si consigue encontrar el último usuario, sino false</returns>
        public bool UltimoUsuario()
        {
            CADUsuario c = new CADUsuario();
            return c.UltimoUsuario(this);
        }

        /// <summary>
        /// Devuelve una lista de los usuarios de la BBDD de la tabla Usuarios. Llama a CADUsuarios.
        /// No requiere de atributos.
        /// </summary>
        /// <returns>true si consigue listar a todos los usuarios, sino false (si está vacio) (si está vacio)</returns>
        public List<ENUsuario> ListarUsuarios()
        {
            CADUsuario c = new CADUsuario();
            return c.ListarUsuarios();
        }

        public List<ENUsuario> BuscarPreferencia()
        {
            CADUsuario c = new CADUsuario();
            return c.BuscarPreferencia(this); 
        }

    }
}
