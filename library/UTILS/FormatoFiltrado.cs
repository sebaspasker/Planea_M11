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
            return Regex.IsMatch(apellidos, @"^[a-zA-Z\s]{3,20}$");
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
            } else if(!filterNombreUsuario(en.nombre_usuario))
            {
                return "El nombre de usuario tiene que tener entre 3 y 12";
            }
            else if(!filterNombre(en.nombre))
            {
                return "El nombre tiene que tener entre 3 y 10 carácteres sin espaciones";
            }
            else if(!filterApellidos(en.apellidos)) 
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

        public static bool filtrarHora(int hora)
        {
            return 0 <= hora && 23 >= hora;          
        }

        public static bool filtrarAceptado(string ac)
        {
            return Regex.IsMatch(ac, @"[a-z]{2,3}$");
        }

        public static bool filterNombrePlan(string nombre)
        {
            return Regex.IsMatch(nombre, @"^[a-zA-Z\s]{3,20}$");
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

        public static string filterFavorito(ENFavoritos favorito)
        {
            ENUsuario usuario1 = new ENUsuario();
            ENUsuario usuario2 = new ENUsuario();

            if(!filterNombreUsuario(favorito.nombre_usuario) ||!filterNombreUsuario(favorito.nombre_usuario_favorito))
            {
                return "El nombre de usuario tiene que tener entre 3 y 12 carácteres";
            }
            else if(!usuario1.SeleccionarUsuario() ||!usuario2.SeleccionarUsuario())
            {
                return "Uno de los nombre de usuario no existe";
            } 
            else
            {
                return "TODO_OK";
            }
        }

        public static string filterPareja(ENParejas pareja)
        {
            ENUsuario usuario1 = new ENUsuario();
            ENUsuario usuario2 = new ENUsuario();
            ENPlanes plan = new ENPlanes();
            usuario1.nombre_usuario = pareja.nombre_usuario_1;
            usuario2.nombre_usuario = pareja.nombre_usuario_2;
            plan.Nombre = pareja.nombre_plan; 
            if(!filterNombreUsuario(pareja.nombre_usuario_1) || !filterNombreUsuario(pareja.nombre_usuario_2))
            {
                return "El nombre de usuario tiene que tener entre 3 y 12 carácteres";
            } 
            else if(!filterNombrePlan(pareja.nombre_plan))
            {
                return "El nombre del plan tiene que tener entre 3 y 20 carácteres";
            }
            else if(!usuario1.SeleccionarUsuario() || !usuario2.SeleccionarUsuario())
            {
                return "Los dos usuarios tienen que existir";
            }
            else if(!plan.SeleccionarPlan())
            {
                return "El nombre del plan tiene que existir";
            }
            else if(!filtrarHora(pareja.hora_fin) ||!filtrarHora(pareja.hora_inicio))
            {
                return "La hora del plan tiene que ser entre las 0 y las 23";
            }
            else if(!filtrarAceptado(pareja.plan_aceptado))
            {
                return "El aceptado tiene que ser entre 2 y 3 carácteres";
            } 
            else
            {
                return "TODO_OK";
            }
        }
    }
}
