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
				nuevafila[0] = t.Rows.Count;
                nuevafila[1] = plan.Nombre;
                nuevafila[2] = plan.Precio;
                nuevafila[3] = plan.Ciudad;
                nuevafila[4] = plan.Categoria;
                t.Rows.Add(nuevafila);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(DataAdapter);
                DataAdapter.Update(bdvirtual, "plans");
                cambiado = true;
            }
            catch(Exception e) { cambiado = false; }
            finally { c.Close();  }

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
			// TODO
			return false;
		}
		/// <summary>
		/// Busca un plan dentro de la tabla de plan.
		/// Comprueba si existe
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool SeleccionarPlan(ENPlanes plan)
		{
			// TODO
			return false;
		}
		/// <summary>
		/// Cambia un plan de la tabla de plan.
		/// Comprueba si existe
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool ModificarPlan(ENPlanes plan)
		{
			// TODO
			return false;
		}
		/// <summary>
		/// Busca el primer plan de la tabla de plan.
		/// Comprueba si existe el plan pedido.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool PrimerPlan(ENPlanes plan)
		{
			// TODO
			return false;
		}
		/// <summary>
		/// Busca el ultimo plan de la tabla de plan.
		/// Comprueba si existe el plan pedido
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido encontrar el plan, sino false</returns>
		public bool UltimoPlan(ENPlanes plan)
		{
			// TODO
			return false;
		}

		/// <summary>
		/// Busca el siguiente plan al mencionado.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns></returns>
		public bool SiguientePlan(ENPlanes plan)
		{
			// TODO 
			return false;
		}

		/// <summary>
		/// Busca los plan a partir al plan mencionado.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns></returns>
		public List<ENPlanes> BuscarPlanes(ENPlanes plan) {
			// TODO
			return null;
		}

		/// <summary>
		/// Devuelve una lista de plan de la BBDD tabla Planes.
		/// </summary>
		/// <returns></returns>
		public List<ENPlanes> ListarPlanes()
		{
			// TODO
			return null;
		}


		/// <summary>
		/// Busca en base a la categoria
		/// </summary>
		/// <returns></returns>
		public List<ENPlanes> BuscarPlanesPreferencia(ENPlanes plan)
		{
			// TODO
			return null;
		}
	}
}
