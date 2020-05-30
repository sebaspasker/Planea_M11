using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace library.UTILS{
    public class Filter {

        public Filter()
        {
        }

        public static bool filterNombre(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z]{3,10}$");
        }

        public static bool filterNombreUsuario(string nombre_usuario)
        {
            return Regex.IsMatch(nombre_usuario, @"^[a-zA-Z0-9_-]{3,12}$");
        } 

        public static bool filterPassword(string password)
        {
            return Regex.IsMatch(password, @"^[a-zA-Z0-9]{3,20}$");
        }

        public static bool filterApellidos(string apellidos)
        {
            return Regex.IsMatch(apellidos, @"^[a-zA-Z]\s{3,20}$");
        }

        public static bool filterCiudad(string ciudad)
        {
            return Regex.IsMatch(ciudad, @"^[a-zA-Z]{3,20}$");
        }

        public static bool filterPreferencia(string preferencia)
        {
            return Regex.IsMatch(preferencia, @"^[a-zA-Z]{3,12}$");
        }

        public static bool filterEdad(int edad)
        {
            return (6 < edad && edad < 110);
        }

        public static bool filterEmail(string email)
        {
            return Regex.IsMatch(email, @"^\S{1,7}@\S{1,8}\.\S{1,3}$");
        }

        public static string filterRegistro(ENUsuario en)
        {
            if(en.SeleccionarUsuario())
            {
                return "El usuario ya existe";
            } 
            else if(!filterNombre(en.nombre))
            {
                return "El nombre tiene que tener entre 3 y 12 carácteres sin espaciones";
            }
            else if(!filterApellidos(en.nombre_usuario)) 
            {
                return "Los apellidos tienen que tener entre 3 y 20 carácteres y sin símbolos";
            }
            else if(!filterPassword(en.password))
            {
                return "La contraseña tiene que tener entre 3 y 20 carácteres y solo puede contener alfanuméricos y simbólos como '_' o '-'";
            }
            else if(!filterPreferencia(en.preferencia))
            {
                return "Formato preferencia incorrecto";
            } 
            else if(!filterCiudad(en.ciudad)) {
                return "Formato ciudad incorrecto";
            }
            else if(!filterEdad(en.edad)) {
                return "La edad tiene que estar entre los 6 y 110 años";
            } 
            else
            {
                return "TODO_OK";
            }
        }

        public string FiltradoUsuario(ENUsuario enu, bool formatoCorto)
        {
            string mensaje = "TODO_OK";
            if(enu.nombre_usuario.Length < 5 || enu.nombre_usuario.Length > 12)
            {
                mensaje = "El nombre de usuario tiene que tener entre 0 y 12 carácteres";
            }

            if(!formatoCorto && mensaje == "TODO_OK")
            {
                if(enu.SeleccionarUsuario())
                {
                    mensaje = "El nombre de usuario ya existe";
                }
                else if(enu.password.Length < 5 || enu.password.Length > 20)
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

        public static bool filtrarHora(int hora)
        {
            return 0 <= hora && 23 >= hora;          
        }

        public static bool filtrarAceptado(string ac)
        {
            return Regex.IsMatch(ac, @"[a-z]{2,3}$");
        }

        public static string FiltradoPareja(ENParejas pareja, bool formatoCorto)
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
            }

            return mensaje;
        }
            
        public static bool filterNombrePlan(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[A-Za-z]\s{3-20}");
        }

        public static bool filterPrecio(int precio)
        {
            return precio > 0;
        }

        public static string FiltrarInsertarPlan(ENPlanes plan)
        {
            if(plan.SeleccionarPlan())
            {
                return "Este plan ya existe";
            } 
            else if(!filterNombrePlan(plan.Nombre))
            {
                return "Formato nombre plan incorrecto, tienen que ser entre 3 y 20 carácteres alfabéticos";
            }
            else if(!filterCiudad(plan.Ciudad))
            {
                return "Formato ciudad incorrecto";
            }
            else if(!filterPreferencia(plan.Categoria))
            {
                return "Formato preferencia incorrecto";
            } 
            else
            {
                return "TODO_OK";
            }
        }
    }
}
