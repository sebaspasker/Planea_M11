﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
	class CADPlanes
	{
		private string constring;

		//<summary> 
		//Constructor
		public CADPlanes()
		{
			constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
		}
    
		/// <summary>
		/// Inserta un plan dentro de la tabla de Planes.
		/// Comprueba que no haya repetición.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido añadir el plan, sino false</returns>
		public bool InsertarPlan(ENPlanes plan)
		{
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);

			try
			{
				SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", c);
				DataAdapter.Fill(bdvirtual, "plan");
				DataTable t = new DataTable();
				t = bdvirtual.Tables["plan"];
				DataRow nuevafila = t.NewRow();
				if(t.Rows.Count != 0)
				{
					nuevafila[0] = Int32.Parse(t.Rows[t.Rows.Count - 1]["id"].ToString()) +1 ;
				} else
				{
					nuevafila[0] = 1;
				}
				nuevafila[1] = plan.Nombre;
				nuevafila[2] = plan.Precio;
				nuevafila[3] = plan.Ciudad;
				nuevafila[4] = plan.Categoria;
				t.Rows.Add(nuevafila);
				SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
				DataAdapter.Update(bdvirtual, "plan");
				cambiado = true;
			}
			catch(Exception e)
			{
				cambiado = false;
				throw e;
			}
			finally { c.Close(); }

            return cambiado;
		}
    
		/// <summary>
		/// Elimina un plan dentro de la tabla de plan.
		/// Comprueba que exista.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido borrar el plan, sino false</returns>
		public bool BorrarPlan(ENPlanes plan)
		{
            bool eliminado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Planes", c);
                dataAdapter.Fill(bdvirtual, "plan");
                DataTable t = bdvirtual.Tables["plan"];
                for(int i=t.Rows.Count-1; i>=0; i--)
                {
                    DataRow dr = t.Rows[i];
                    if(dr["Nombre"].ToString() == plan.Nombre)
                    {
                        dr.Delete();
                        eliminado = true;
                        break;
                    }
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(bdvirtual, "planes");
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
		/// Busca un plan dentro de la tabla de plan.
		/// Comprueba si existe
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool SeleccionarPlan(ENPlanes plan)
		{
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", c);
                DataAdapter.Fill(bdvirtual, "plan");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["plan"];
                string criteria = "nombre='" + plan.Nombre + "'";
                DataRow[] dataRows = t.Select(criteria);
                if(dataRows != null && dataRows.Length != 0)
                {
                    plan.Nombre = dataRows[0]["nombre"].ToString();
					plan.Precio = Int32.Parse(dataRows[0]["precio"].ToString());
                    plan.Categoria = dataRows[0]["categoria"].ToString();
                    plan.Ciudad = dataRows[0]["ciudad"].ToString();
                    encontrado = true;
                }
            }
            catch(Exception e) {encontrado = false; Console.WriteLine(e.Message + " " + e.ToString());  throw e; }
            finally { c.Close();  }

            return encontrado;
		}
    
		/// <summary>
		/// Cambia un plan de la tabla de plan.
		/// Comprueba si existe
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool ModificarPlan(ENPlanes plan)
		{
            bool cambiado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO Hacer filtrado
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", c);
                DataAdapter.Fill(bdvirtual, "plan");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["plan"];
                string criteria = "Nombre='" + plan.Nombre + "'";
                DataRow[] rows = t.Select(criteria);
                if(rows.Length != 0 || rows != null)
                {
					          rows[0]["precio"] = plan.Precio;
                    rows[0]["ciudad"] = plan.Ciudad;
					          rows[0]["categoria"] = plan.Categoria;
                }
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "plan");
                cambiado = true;
            } 
            catch(Exception e)
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
		/// Busca el primer plan de la tabla de plan.
		/// Comprueba si existe el plan pedido.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool PrimerPlan(ENPlanes plan)
		{
            bool leido = false;
            SqlConnection conectar = new SqlConnection(constring);
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", conectar);
                DataAdapter.Fill(bdvirtual, "planes");
                DataTable t = bdvirtual.Tables["planes"];
                DataRow dr = t.Rows[0];
                if(dr["Nombre"].ToString() != "")
                {
                    leido = true;
                    plan.Nombre = dr["Nombre"].ToString();
                    plan.Precio = Int32.Parse(dr["Precio"].ToString());
                    plan.Ciudad = dr["Ciudad"].ToString();
                    plan.Categoria = dr["Categoria"].ToString();

                }
                else
                {
                    Console.WriteLine("No se pudo realizar el procedimiento");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No se pudo realizar el procedimiento", e.Message);
                throw e;
            }
            finally
            {
                conectar.Close();
            }
            return leido;
		}
    
		/// <summary>
		/// Busca el ultimo plan de la tabla de plan.
		/// Comprueba si existe el plan pedido
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool UltimoPlan(ENPlanes plan)
		{
            bool leido = false;
            SqlConnection conectar = new SqlConnection(constring);
            DataSet bdvirtual = new DataSet();
            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", conectar);
                DataAdapter.Fill(bdvirtual, "planes");
                DataTable t = bdvirtual.Tables["planes"];
                DataRow dr = t.Rows[t.Rows.Count - 1];
                if(dr["Nombre"].ToString() != "")
                {
                    leido = true;
                    plan.Nombre = dr["Nombre"].ToString();
                    plan.Precio = Int32.Parse(dr["Precio"].ToString());
                    plan.Ciudad = dr["Ciudad"].ToString();
                    plan.Categoria = dr["Categoria"].ToString();

                }
                else
                {
                    Console.WriteLine("No se pudo realizar el procedimiento");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No se pudo realizar el procedimiento", e.Message);
                throw e;
            }
            finally
            {
                conectar.Close();
            }
            return leido;
		}

		/// <summary>
		/// Busca el siguiente plan al mencionado.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns></returns>
		public bool SiguientePlan(ENPlanes plan)
		{
            bool encontrado = false;
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", c);
                DataAdapter.Fill(bdvirtual, "plan");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["plan"];
                string criteria = "nombre='" + plan.Nombre + "'";
                DataRow[] dataRows = t.Select(criteria);
                int posSiguiente=0;
                if (dataRows != null && dataRows.Length != 0)
                {
                    for (int i = 0; i < t.Rows.Count - 1; i++)
                    {
                        DataRow db = t.Rows[i];
                        if (db["Nombre"].ToString() == plan.Nombre)
                        {
                            posSiguiente = i + 1;
                        }
                    }
                    if (posSiguiente != 0)
                    {
                        DataRow dr = t.Rows[posSiguiente];
                        if (dr["Nombre"].ToString() != "")
                        {
                            plan.Nombre = dr["nombre"].ToString();
                            plan.Precio = Int32.Parse(dr["precio"].ToString());
                            plan.Categoria = dr["categoria"].ToString();
                            plan.Ciudad = dr["ciudad"].ToString();
                            encontrado = true;
                        }
                    }
                }
            }
            catch (Exception e) { encontrado = false; Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close(); }

            return encontrado;
        }

		/// <summary>
		/// Busca los plan a partir al plan mencionado.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns></returns>
		public DataSet BuscarPlanes(ENPlanes plan) {
			DataSet bdvirtual = new DataSet();
			SqlConnection c = new SqlConnection(constring);
			SqlDataAdapter da = new SqlDataAdapter("select nombre, precio, ciudad, categoria from Planes where nombre like'%" + plan.Nombre + "%';", c);
			da.Fill(bdvirtual, "plan");
			return bdvirtual;
		}

		/// <summary>
		/// Devuelve una lista de plan de la BBDD tabla Planes.
		/// </summary>
		/// <returns></returns>
		public DataSet ListarPlanes()
		{
			DataSet bdvirtual = new DataSet();
			SqlConnection c = new SqlConnection(constring);
			SqlDataAdapter da = new SqlDataAdapter("select nombre, precio, ciudad, categoria from Planes;", c);
			da.Fill(bdvirtual, "plan");
			return bdvirtual;
		}

		/// <summary>
		/// Busca en base a la categoria
		/// </summary>
		/// <returns></returns>
		public List<ENPlanes> BuscarPlanesPreferencia(ENPlanes plan)
		{
			List<ENPlanes> planes = new List<ENPlanes>();
            DataSet bdvirtual = new DataSet();
            SqlConnection c = new SqlConnection(constring);
            try
            {
                // TODO falla a la hora de excederse del formato
                SqlDataAdapter DataAdapter = new SqlDataAdapter("select * from Planes", c);
                DataAdapter.Fill(bdvirtual, "planes");
                DataTable t = new DataTable();
                t = bdvirtual.Tables["planes"];
                string criteria = "categoria='" + plan.Categoria + "'";
                DataRow[] dataRows = t.Select(criteria);
                if(dataRows != null && dataRows.Length != 0)
                {
                    foreach(DataRow row in dataRows) {
                        ENPlanes planlis = new ENPlanes();
                        planlis.Nombre = row["nombre"].ToString();
						            planlis.Precio = Int32.Parse(row["precio"].ToString());
                        planlis.Ciudad = row["ciudad"].ToString();
                        planlis.Categoria = row["categoria"].ToString();
                        planes.Add(planlis);
                    }
                }
            }
            catch(Exception e) {Console.WriteLine(e.Message + " " + e.ToString()); throw e; }
            finally { c.Close(); }

            return planes;

		}
	}
}
