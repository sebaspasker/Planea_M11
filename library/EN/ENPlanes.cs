using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENPlanes
    {

        // <summary>
        // Nombre del plan
        // rango 0<= Nombre <=20
        // <summary>
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }

        }
        // <summary>
        // Precio del plan
        // rango 0<=Precio
        //<summary>
        private int _precio;
        public int Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        // <summary>
        // Ciudad donde se realiza el plan
        // rango 0<=Ciudad<=10
        //<summary>
        private string _ciudad;
        public string Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                _ciudad = value;
            }
        }
        // <summary>
        // Tipo de plan
        // rango 0<=Plan<=12
        //<summary>
        private string _categoria;
        public string Categoria
        {
            get
            {
                return _categoria;
            }
            set
            {
                _categoria = value;
            }
        }


        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ENPlanes()
        {

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_nombre"></param>
        /// <param name="_precio"></param>
        /// <param name="_ciudad"></param>
        /// <param name="_categoria">hora_inicio</param>
        public ENPlanes(string _nombre, int _precio, string _ciudad, string _categoria)
        {
            this._nombre = _nombre;
            this._precio = _precio;
            this._ciudad = _ciudad;
            this._categoria = _categoria;
        }
        /// <summary>
        /// Inserta un Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido añadir, sino false</returns>
        public bool InsertarPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool insertado = false;
            if (cad.InsertarPlan(this))
            {
                insertado = true;
            }
            return insertado;
        }
        /// <summary>
        /// Elimina un Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido eliminar, sino false</returns>
        public bool BorrarPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool eliminado = false;
            if (cad.BorrarPlan(this))
            {
                eliminado = true;
            }
            return eliminado;
        }
        /// <summary>
        /// Busca un Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido encontrar, sino false</returns>
        public bool SeleccionarPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool buscado = false;
            if (cad.SeleccionarPlan(this))
            {
                buscado = true;
            }
            return buscado;
        }
        /// <summary>
        /// Modifica un Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool ModificarPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool modificado = false;
            if (cad.ModificarPlan(this))
            {
                modificado = true;
            }
            return modificado;
        }
        /// <summary>
        /// Coge el Plan posterior al indicado en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool SiguientePlan()
        {
            CADPlanes cad = new CADPlanes();
            bool leido = false;
            if (cad.SiguientePlan(this))
            {
                leido = true;
            }
            return leido;
        }
        /// <summary>
        /// Coge el primer Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool PrimerPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool leido = false;
            if (cad.PrimerPlan(this))
            {
                leido = true;
            }
            return leido;
        }
        /// <summary>
        /// Coge el último Plan en la tabla de planes de la base de datos. Llama a CADPlanes.
        /// </summary>
        /// <returns>true si se ha podido modificar, sino false</returns>
        public bool UltimoPlan()
        {
            CADPlanes cad = new CADPlanes();
            bool leido = false;
            if (cad.UltimoPlan(this))
            {
                leido = true;
            }
            return leido;
        }

        /// <summary>
        /// Busca en base al nombre del plan
        /// </summary>
        /// <returns></returns>
        public List<ENPlanes> BuscarPlanes()
        {
            CADPlanes c = new CADPlanes();
            return c.BuscarPlanes(this);
        }

        /// <summary>
        /// Busca en base a la categoria
        /// </summary>
        /// <returns></returns>
        public List<ENPlanes> BuscarPlanesPreferencia()
        {
            CADPlanes c = new CADPlanes();
            return c.BuscarPlanesPreferencia(this);
        }

        /// <summary>
        /// Devuelve una lista con todos los planes de la base de datos, tabla Parejas. Llama a CADPlanes.
        /// </summary>
        /// <returns>Lista de parejas de ENPlanes</returns>
        public List<ENPlanes> ListarPlanes()
        {
            CADPlanes c = new CADPlanes();
            return c.ListarPlanes();
        }
    }
}
