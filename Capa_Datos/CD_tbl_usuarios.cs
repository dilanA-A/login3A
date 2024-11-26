using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_tbl_usuarios
    {
        //conexion
        private CD_Conexion con =  new CD_Conexion();
        //propiedades
        SqlDataReader leer;
        SqlCommand cmd = new SqlCommand();

        public void cd_agregar_u(string nom, string ced, string cla, string corr, int prf)
        {
            SqlCommand sqlcmd = new SqlCommand("Insert into tbl_usuario values(@nomb,@cedu,dbo.encripta_pass(@clav),@corre,'A',@perf)",con.abrir_conexion());
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Parameters.AddWithValue("@nomb", nom);
            sqlcmd.Parameters.AddWithValue("@cedu", ced);
            sqlcmd.Parameters.AddWithValue("@clav", cla);
            sqlcmd.Parameters.AddWithValue("@corre", corr);
            sqlcmd.Parameters.AddWithValue("@perf", Convert.ToInt32(prf));
            sqlcmd.ExecuteNonQuery();
            con.cerrar_conexion();
        }

        public DataTable buscarxced(string ced)
        {
            DataTable dt = new DataTable();
            cmd.Connection = con.abrir_conexion();
            cmd.CommandText = "select * from tbl_usuario where usu_cedula = '"+ced+"'";
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            con.cerrar_conexion();
            return dt;
        }

        public DataTable buscarxcc(string ced, string pwd)
        {
            DataTable dt = new DataTable();
            cmd.Connection = con.abrir_conexion();
            cmd.CommandText = "select * from tbl_usuario where usu_cedula = '" + ced + "' and dbo.desencripta_pass(usu_clave_encr) = '"+pwd+"'";
            leer = cmd.ExecuteReader();
            dt.Load(leer);
            con.cerrar_conexion();
            return dt;
        }

    }
}
