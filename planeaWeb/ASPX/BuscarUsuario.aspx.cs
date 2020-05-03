using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace planeaWeb {
    public partial class BuscarUsuario : System.Web.UI.Page {
        /// <summary>
        /// Lista de Usuarios
        /// </summary>
        private List<ENUsuario> listaUsuarios;

        /// <summary>
        /// Llama a una función que devuelve todos los usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            listaUsuarios = en.ListarUsuarios();
        }

        /// <summary>
        /// Imprime todos los usuarios que contienen el texto introducido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonBuscarUsuario(object sender, EventArgs e)
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre = nombre.Text;
            BuscaUsuarioR.Text = "";
            if(nombre.Text.Length < 0 || nombre.Text.Length > 10)
            {
                BuscaUsuarioR.Text = "El nombre tiene que tener entre 0 y 10 carácteres\n";
            } 
            else
            {
                for(int i=0; i<listaUsuarios.Count; i++)  
                {
                    if(listaUsuarios[i].nombre.Contains(nombre.Text))
                    {
                        BuscaUsuarioR.Text += "Nombre de usuario: " + listaUsuarios[i].nombre_usuario + " -- Nombre: " + listaUsuarios[i].nombre +
                           " -- Ciudad: " + listaUsuarios[i].ciudad + " --  Preferencia: " + listaUsuarios[i].preferencia + "<br />";
                    }
                }
            }
        }
    }
}