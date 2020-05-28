using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    public class ENParejas {
        /// <summary>
        /// Primer nombre de usuario
        /// Rango 0 <= nombre <= 12
        /// </summary>
        private string _nombre_usuario_1;
        public string nombre_usuario_1
        {
            set
            {
                _nombre_usuario_1 = value;
            }

            get
            {
                return _nombre_usuario_1;
            }
        }
        
        /// <summary>
        /// Segundo nombre de usuario
        /// Rango 0 <= nombre <= 12
        /// </summary>
        private string _nombre_usuario_2;
        public string nombre_usuario_2
        {
            set
            {
                _nombre_usuario_2 = value;
            }
            
            get
            {
                return _nombre_usuario_2;
            }
        }

        /// <summary>
        /// Nombre del plan
        /// Rango 0 <= nombre <= 20
        /// </summary>
        private string _nombre_plan;
        public string nombre_plan
        {
            set
            {
                _nombre_plan = value;
            }

            get
            {
                return _nombre_plan;
            }
        }

        /// <summary>
        /// Hora de inicio del plan
        /// Rango 0 <= hora <= 23
        /// </summary>
        private int _hora_inicio;
        public int hora_inicio
        {
            set
            {
                _hora_inicio = value;
            }

            get
            {
                return _hora_inicio;
            }
        }

        /// <summary>
        /// Hora en la que se estima el final del plan
        /// Rango 0 <= hora <= 23
        /// </summary>
        private int _hora_fin;
        public int hora_fin
        {
            set
            {
                _hora_fin = value;
            }

            get
            {
                return _hora_fin;
            }
        }

        private string _plan_aceptado;
        public string plan_aceptado
        {
            get
            {
                return _plan_aceptado;
            }

            set
            {
                _plan_aceptado = value;
            }
        }

        private string _fecha;
        public string fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                fecha = value;
            }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENParejas()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre_usuario_1"></param>
        /// <param name="nombre_usuario_2"></param>
        /// <param name="nombre_plan"></param>
        /// <param name="inicio">hora_inicio</param>
        /// <param name="fin">hora_fin</param>
        public ENParejas(string nombre_usuario_1, string nombre_usuario_2, string nombre_plan, int inicio, int fin)
        {
            this.nombre_usuario_1 = nombre_usuario_1;
            this.nombre_usuario_2 = nombre_usuario_2;
            this.nombre_plan = nombre_plan;
            this.hora_inicio = inicio;
            this.hora_fin = fin;
        }

        /// <summary>
        /// Inserta parejas en la base de datos, tabla Parejas. Llama a CADParejas.
        /// </summary>
        /// <returns>true si se ha podido añadir, sino false</returns>
        public bool InsertarPareja()
        {
            CADParejas c = new CADParejas();
            return c.InsertarPareja(this);
        }

        /// <summary>
        /// Modifica parejas en la base de datos, tabla Parejas. Llama a CADParejas.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool ModificarPareja()
        {
            CADParejas c = new CADParejas();
            return c.ModificarPareja(this);
        }

        /// <summary>
        /// Busca parejas en la base de datos, tabla Parejas. Llama a CADParejas.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool SeleccionarPareja()
        {
            CADParejas c = new CADParejas();
            return c.SeleccionarPareja(this);
        }

        /// <summary>
        /// Elimina parejas en la base de datos, tabla Parejas. Llama a CADParejas.
        /// </summary>
        /// <returns>true si se ha podido eliminar, sino false</returns>
        public bool BorrarPareja()
        {
            CADParejas c = new CADParejas();
            return c.BorrarPareja(this);
        }

        /// <summary>
        /// Devuelve una lista con todas las parejas de la base de datos, tabla Parejas. Llama a CADParejas.
        /// </summary>
        /// <returns>Lista de parejas de ENParejas</returns>
        public List<ENParejas> ListarParejas()
        {
            CADParejas c = new CADParejas();
            return c.ListarParejas();
        }


        public List<ENParejas> BuscarParejas()
        {
            CADParejas c = new CADParejas();
            return c.BuscarParejas(this);
        }

        public List<ENParejas> BuscarSolicitudes()
        {
            CADParejas cad = new CADParejas();
            return cad.BuscarSolicitudes(this);
        }
    }
}
