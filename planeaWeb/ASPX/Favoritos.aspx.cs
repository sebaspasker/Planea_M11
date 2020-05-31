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
using System.Web.UI.WebControls;
using library;
using System.Collections;

namespace planeaWeb {
    public partial class Favoritos : System.Web.UI.Page {
        /// <summary>
        /// Page load, devuelve una lista de usuarios dentro de los favoritos del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string nom_usuario = Session["nombre_usuario"].ToString();
                nombre_usuario.Text = nom_usuario;
                if(!String.IsNullOrEmpty(nom_usuario))
                {
                    ENFavoritos favoritos = new ENFavoritos();
                    favoritos.nombre_usuario = nom_usuario;
                    DataSet fav = favoritos.BuscarFavoritos();
                    GridView1.DataSource = fav.Tables[0];
                    GridView1.DataBind();

                    ENUsuario usuario = new ENUsuario();
                    usuario.nombre_usuario = nom_usuario;
                    if(usuario.SeleccionarUsuario())
                    {
                        List<ENUsuario> usuarioPreferencia = usuario.BuscarPreferencia();
                        ArrayList al = new ArrayList();
                        foreach(ENUsuario en in usuarioPreferencia)
                        {
                            if(en.nombre_usuario != nom_usuario)
                            {
                                al.Add(en.nombre_usuario);
                            }
                        }

                        DropDownList1.DataSource = al;
                        DropDownList1.DataBind();
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENFavoritos favorito = new ENFavoritos();
            favorito.nombre_usuario = Session["nombre_usuario"].ToString();
            favorito.nombre_usuario_favorito = DropDownList1.SelectedValue;
            if(!favorito.SeleccionarFavorito())
            {
                if(favorito.InsertarFavorito())
                {
                    Label1.Text = "Nuevo usuario favorito";
                }
                else
                {
                    Label1.Text = "No se ha podido insertar";
                }
            }
            else
            {
                Label1.Text = "Ya lo tienes en favoritos " + favorito.nombre_usuario_favorito;
            }
        }
    }
}