using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using System.Data;

namespace login_3eroB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            CN_tbl_usuario objCNU = new CN_tbl_usuario();
            bool isValidUser = objCNU.buscarxced(TextBox1.Text);

            if (isValidUser)
            {
                // Redirigir a la página principal u otra página segura
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                // Mostrar mensaje de error
                Label1.Text = "Cédula o clave incorrecta.";
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Registrar.aspx");
        }
    }
}
