using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;


namespace login_3eroB
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_perfil();
            }
        }

        private void cargar_perfil()
        {
            CN_tbl_tipo_usuario objCNTU = new CN_tbl_tipo_usuario();

            ddl_perfil.DataSource = objCNTU.cn_mostrar_tu();
            ddl_perfil.DataTextField = "tusu_nombre";
            ddl_perfil.DataValueField = "tusu_id";
            ddl_perfil.DataBind();

            ddl_perfil.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CN_tbl_usuario objCNU = new CN_tbl_usuario();
                objCNU.cn_agregar_u(txt_nom.Text,txt_ced.Text,txt_clav.Text,txt_correo.Text,ddl_perfil.SelectedValue);
                limpiar();
                Timer1.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void limpiar()
        {
            txt_nom.Text = txt_ced.Text = txt_correo.Text = txt_clav.Text = "";
            ddl_perfil.SelectedValue = "0";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Timer1.Enabled = false;
            Response.Redirect("Login.aspx");
        }

        protected void lnk_regresa_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}