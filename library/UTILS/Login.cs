using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.UTILS {
    public class Login {
        /// <summary>
        /// Función de login en el backend para evitar filtrar la contraseña en el frontend
        /// </summary>
        /// <param name="nombre_usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool loginUsuario(string nombre_usuario, string password)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre_usuario = nombre_usuario;
            if(usuario.SeleccionarUsuario())
            {
                if(usuario.password == password)
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            } 
            else
            {
                return false;
            }
        }

        public static bool loginAdmin(string nombre_usuario, string password)
        {
            return nombre_usuario == "admin" && password == "admin";
        }
    }
}
