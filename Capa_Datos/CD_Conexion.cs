using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DILAN;Initial Catalog=Crud_Web;Integrated Security=True;Encrypt=False");

        //metodo de abrir y cerrar

        public SqlConnection abrir_conexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }


        public SqlConnection cerrar_conexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
