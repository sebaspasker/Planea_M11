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
                if (t.Rows.Count != 0)
                {
                    nuevafila[0] = Int32.Parse(t.Rows[t.Rows.Count - 1]["id"].ToString());
                }
                else
                {
                    nuevafila[0] = 0;
                }
                nuevafila[0] = t.Rows.Count;
                nuevafila[1] = pareja.nombre_usuario_1;
                nuevafila[2] = pareja.nombre_usuario_2;
                nuevafila[3] = pareja.nombre_plan;
                nuevafila[4] = pareja.hora_inicio;
                nuevafila[5] = pareja.hora_fin;
                nuevafila[6] = pareja.fecha.Date;
                nuevafila[7] = pareja.plan_aceptado;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "parejas");
                cambiado = true;
            }
            catch(Exception e) { // TODO 
                cambiado = false;
                throw e;
            }
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
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Hacer filtrado
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Parejas", c);
                DataAdapter.Fill(bdvirtual, "pareja");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["pareja"];
                string criteria = "nombre='" + pareja.nombre_usuario_1 + "'";
                DataRow[] rows = t.Select(criteria);
                if (rows.Length != 0 || rows != null)
                {
                    rows[0]["nombre_usuario_1"] = pareja.nombre_usuario_1;
                    rows[0]["nombre_usuario_2"] = pareja.nombre_usuario_2;
                    rows[0]["nombre_plan"] = pareja.nombre_plan;
                    rows[0]["hora_inicio"] = pareja.hora_inicio;
                    rows[0]["hora_fin"] = pareja.hora_fin;
                    rows[0]["fecha"] = pareja.fecha;
                    rows[0]["aceptado"] = pareja.plan_aceptado;
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "parejas");
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
        /// Busca una pareja dentro de la base de datos, lo hace a partir del
        /// nombre_pareja_1, nombre_usuario_2 y nombre_plan.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool SeleccionarPareja(ENParejas pareja)
        {
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Parejas", c);
                DataAdapter.Fill(bdvirtual, "parejas");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["parejas"];
                string criteria = "nombre_usuario_1='" + pareja.nombre_usuario_1 + "'";
                DataRow[] dataRows = t.Select(criteria);
                if (dataRows != null && dataRows.Length != 0)
                {
                    pareja.nombre_usuario_1 = dataRows[0]["nombre_usuario_1"].ToString();
                    pareja.nombre_usuario_2 = dataRows[0]["nombre_usuario_2"].ToString();
                    pareja.nombre_plan = dataRows[0]["nombre_plan"].ToString();
                    pareja.hora_inicio = Int32.Parse(dataRows[0]["hora_inicio"].ToString());
                    pareja.hora_fin = Int32.Parse(dataRows[0]["hora_fin"].ToString());
                    pareja.fecha = dataRows[0]["fecha"].ToString();
                    pareja.plan_aceptado = dataRows[0]["plan_aceptado"].ToString();
                    encontrado = true;
                }
            }
            catch (Exception e) { throw e; encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); }
            finally { c.Close(); }

            return encontrado;
        }

        /// <summary>
        /// Elimina una pareja dentro de la base de datos, lo hace a partir del
        /// nombre_pareja_1, nombre_usuario_2 y nombre_plan.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns></returns>
        public bool BorrarPareja(ENParejas pareja)
        {
            bool eliminado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Comprobar que existe el usuario primero y funcionamiento
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Parejas", c);
                dataAdapter.Fill(bdvirtual, "parejas");
                DataTable t = bdvirtual.Tables["parejas"];
                for (int i = t.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = t.Rows[i];
                    if (dr["nombre_usuario"].ToString() == pareja.nombre_usuario_1)
                    {
                        dr.Delete();
                        eliminado = true;
                        break;
                    }
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(bdvirtual, "parejas");
            }
            catch (Exception e)
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
        /// Lista todas las parejas dentro de la base de datos.
        /// </summary>
        /// <param name="pareja"></param>
        /// <returns>Lista de parejas ENParejas</returns>
        public DataSet ListarParejas()
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre_usuario_1, nombre_usuario_2, hora_inicio,hora_fin, fecha from Parejas where nombre_usuario_1 != 'admin';", c);
            da.Fill(bdvirtual, "parejas");
            return bdvirtual;
        }


        public DataSet BuscarParejas(ENParejas en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter da = new SqlDataAdapter("select nombre_usuario_1, nombre_usuario_2, hora_inicio,hora_fin, fecha from Parejas where nombre_usuario_1 like '" + en.nombre_usuario_1 + "';", c);
            da.Fill(bdvirtual, "parejas");
            return bdvirtual;
        }
      
        public DataSet BuscarSolicitudes(ENParejas en)
        {
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            SqlDataAdapter data = new SqlDataAdapter("Select nombre_usuario_1, nombre_plan, hora_inicio, hora_fin, dia where nombre_usuario_2='" + en.nombre_usuario_2 +
                "' and aceptado='no'", c);
            data.Fill(bdvirtual, "parejas");
            return bdvirtual;
        }
    }
}
