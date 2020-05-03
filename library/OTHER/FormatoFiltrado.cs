using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.OTHER {
    public class FormatoFiltrado {
        public FormatoFiltrado()
        {
        }

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

        public string FiltradoPareja(ENParejas pareja, bool formatoCorto)
        {
            string mensaje = "TODO_OK";
            int tamanyoUsu1 = pareja.nombre_usuario_1.Length;            
            int tamanyoUsu2 = pareja.nombre_usuario_2.Length;            

            if(tamanyoUsu1 < 0 || tamanyoUsu1 > 12)
            {
                mensaje = "El nombre de usuario tiene que tener entre 0 y 12 carácteres";
            } 
            else if(tamanyoUsu2 < 0 || tamanyoUsu2 > 12)
            {
                mensaje = "El nombre de usuario tiene que tener entre 0 y 12 carácteres";
            }

            if(pareja.nombre_plan.Length < 0 || pareja.nombre_plan.Length > 20)
            {
                mensaje = "El nombre del plan tiene que tener entre 0 y 20 carácteres";
            }

            if(!formatoCorto && mensaje == "TODO_OK")
            {
                if(pareja.hora_inicio < 0 || pareja.hora_fin > 23)
                {
                    mensaje = "La hora de inicio tiene que estar entre las 0 y las 23";
                }
                else if(pareja.hora_fin < 0 || pareja.hora_fin > 23)
                {
                    mensaje = "La hora de inicio tiene que estar entre las 0 y las 23";
                }
                else if(pareja.fecha.Length != 10)
                {
                    mensaje = "La fecha tiene que tener 10 carácteres";
                }
            }

            return mensaje;
        }
    }
}
