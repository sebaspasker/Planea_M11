using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library {
    class CADParejas {
        private string constring;
        
        public CADParejas()
        {
            constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }

        /// <summary>
        /// Inserta una pareja en la base de datos, comprueba que no haya ninguna repetición de la clave principal
        /// (nombre1, nombre2, plan).
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool InsertarPareja(ENParejas pareja)
        {
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Parejas", c);
                DataAdapter.Fill(bdvirtual, "parejas");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["parejas"];
                DataRow nuevafila = t.NewRow();
                nuevafila[0] = t.Rows.Count;
                nuevafila[1] = pareja.nombre_usuario_1;
                nuevafila[2] = pareja.nombre_usuario_2;
                nuevafila[3] = pareja.nombre_plan;
                nuevafila[4] = pareja.hora_inicio;
                nuevafila[5] = pareja.hora_fin;
                // TODO Comprobar formato fecha
                nuevafila[6] = pareja.fecha;
                nuevafila[7] = pareja.plan_aceptado;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "parejas");
                cambiado = true;
            }
            catch(Exception e) { // TODO 
                throw e;
                cambiado = false; }
            finally { c.Close();  }

            return cambiado;
        }

        /// <summary>
        /// Modifica una pareja en la base de datos, lo hace a partir del 
        /// nombre_pareja_1, nombre_usuario_2 y nombre_plan.
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
        /// nombre_pareja_1, nombre_usuario_2 y nombre_plan.
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
        /// nombre_pareja_1, nombre_usuario_2 y nombre_plan.
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
