using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace login_3eroB
{
    public partial class Loginaspx : Page
    {
        private static int intentos = 0;
        private const int maxIntentos = 3;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "Intentos restantes: " + (maxIntentos - intentos);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string correo = TextBox1.Text;
            string clave = TextBox2.Text;

            if (intentos >= maxIntentos)
            {
                Label1.Text = "Usuario bloqueado. Demasiados intentos fallidos.";
                return;
            }

            if (ValidarUsuario(correo, clave))
            {
                // Redirigir a la página principal o dashboard
                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                intentos++;
                Label1.Text = "Intentos restantes: " + (maxIntentos - intentos);
                if (intentos >= maxIntentos)
                {
                    Label1.Text = "Usuario bloqueado. Demasiados intentos fallidos.";
                }
            }
        }

        private bool ValidarUsuario(string correo, string clave)
        {
            bool esValido = false;
            string connectionString = "tu_cadena_de_conexion_aqui";
            string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Clave = @Clave";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Clave", clave);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    esValido = (count > 0);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción
                    Label1.Text = "Error al conectar con la base de datos.";
                }
            }

            return esValido;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // Redirigir a la página de registro
            Response.Redirect("Registrar.aspx");
        }
    }
}
