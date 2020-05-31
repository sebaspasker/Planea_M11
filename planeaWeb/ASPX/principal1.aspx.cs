using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace planeaWeb.ASPX {
    public partial class principal1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie userCookie;
            userCookie = Request.Cookies["nombre_usuario"];
            if(userCookie != null)
            {
                Session["nombre_usuario"] = userCookie["nombre_usuario"];
                Response.Redirect("~/ASPX/principal2.aspx");
            }
        }
    }
}