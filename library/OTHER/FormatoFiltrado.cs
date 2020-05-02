using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.OTHER {
    public class FormatoFiltrado {
        public string FiltradoUsuario(ENUsuario enu, bool formatoCorto)
        {
            string mensaje = "TODO_OK";
            if(enu.nombre_usuario.Length < 5 || enu.nombre_usuario.Length > 12)
            {
                mensaje = "El nombre de usuario tiene que tener entre 0 y 12 carácteres";
            }
            else if(enu.SeleccionarUsuario())
            {
                mensaje = "El nombre de usuario ya existe";
            }

            if(!formatoCorto && mensaje == "TODO_OK")
            {
                if(enu.password.Length < 5 || enu.password.Length > 20)
                {
                    mensaje = "La contraseña tiene que tener entre 5 y 20 carácteres";
                }
                else if(enu.nombre.Length < 3 || enu.nombre.Length > 10)
                {
                    mensaje = "El nombre tiene que tener entre 3 y 10 carácteres";
                }
                else if(enu.apellidos.Length < 5 || enu.apellidos.Length > 20)
                {
                    mensaje = "El/Los apellido/s tiene/n que tener entre 5 y 20 carácteres";
                }
                else if(enu.ciudad.Length < 3 || enu.ciudad.Length > 10)
                {
                    mensaje = "La ciudad tiene que tener entre 3 y 20 carácteres";
                }
                else if(enu.preferencia.Length < 3 || enu.preferencia.Length > 12)
                {
                    mensaje = "Preferencia incorrecta";
                }
                else if(enu.edad < 5 || enu.edad > 110)
                {
                    mensaje = "La edad tiene que tener entre 5 y 110 años";
                }

                if(enu.email.Length < 5 || enu.email.Length > 14)
                {
                    mensaje = "El email tiene que tener entre 5 y 14 carácteres";
                }
                // TODO Comprobar repeticion email
            }

            return mensaje;
        }
    }
}
