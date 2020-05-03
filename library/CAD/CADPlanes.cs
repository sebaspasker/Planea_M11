using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
	class CADPlanes
	{
		private string constring;

		//<summary> 
		//Constructor
		public CADPlanes()
		{
			// constring =
			// TODO
			throw new Exception();
		}
		/// <summary>
		/// Inserta un plan dentro de la tabla de Planes.
		/// Comprueba que no haya repetición.
		/// </summary>
		/// <param name="plan"></param>
		/// <returns>true si ha podido añadir el plan, sino false</returns>
		public bool InsertarPlan(ENPlanes plan)
		{
			// TODO
			return false;
		}
		/// <summary>
		/// Elimina un plan dentro de la tabla de planes.
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
		/// Busca un plan dentro de la tabla de planes.
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
		/// Cambia un plan de la tabla de planes.
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
		/// Busca el primer plan de la tabla de planes.
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
		/// Busca el ultimo plan de la tabla de planes.
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
		/// Devuelve una lista de planes de la BBDD tabla Planes.
		/// </summary>
		/// <returns></returns>
		public List<ENPlanes> ListarPlanes()
		{
			// TODO
			return null;
		}

	}
}
