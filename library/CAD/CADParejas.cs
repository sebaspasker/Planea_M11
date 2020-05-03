using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library {
    class CADParejas {
        private string constring;
        
        public CADParejas()
        {
               // TODO
        }

        /// <summary>
        /// Inserta una pareja en la base de datos, comprueba que no haya ninguna repetición de la clave principal
        /// (nombre1, nombre2, plan).
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool InsertarPareja(ENParejas pareja)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Modifica una pareja en la base de datos, lo hace a partir del 
        /// nombre_usuario_1, nombre_usuario_2 y nombre_plan.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool ModificarPareja(ENParejas pareja)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Busca una pareja dentro de la base de datos, lo hace a partir del
        /// nombre_usuario_1, nombre_usuario_2 y nombre_plan.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool SeleccionarPareja(ENParejas pareja)
        {
            // TODO
            return false;
        }

        /// <summary>
        /// Elimina una pareja dentro de la base de datos, lo hace a partir del
        /// nombre_usuario_1, nombre_usuario_2 y nombre_plan.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool BorrarPareja(ENParejas pareja)
        {
            // TODO 
            return false;
        }

        /// <summary>
        /// Lista todas las parejas dentro de la base de datos.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns>Lista de parejas ENParejas</returns>
        public List<ENParejas> ListarParejas()
        {
            // TODO
            return null;
        }


        public List<ENParejas> BuscarParejas(ENParejas en)
        {
            // TODO
            return null;
        }
      
        public List<ENParejas> BuscarSolicitudes(ENParejas en)
        {
            // TODO
            return null;
        }
    }
}
