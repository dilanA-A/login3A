using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_tbl_tipo_usuario
    {
        //instancio la conexion 
        private CD_Conexion cx = new CD_Conexion();
        //propiedades sql
        SqlDataReader leer;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
    
        public DataTable cd_mostrar_tu()
        {
            cmd.Connection = cx.abrir_conexion();
            cmd.CommandText = "Select * from tbl_tipo_usuario";
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            cx.cerrar_conexion();
            return dt;
        }
    }
}
