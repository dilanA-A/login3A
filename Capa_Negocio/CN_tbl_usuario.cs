using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;


namespace Capa_Negocio
{
    public class CN_tbl_usuario
    {
        private CD_tbl_usuarios objCDU = new CD_tbl_usuarios();

        public void cn_agregar_u(string nom, string ced, string cla, string corr, string prf)
        {
            objCDU.cd_agregar_u(nom, ced, cla, corr, Convert.ToInt32(prf));
        }

        public DataTable buscarxced(string ced)
        {
            DataTable dt1 = new DataTable();
            objCDU.buscarxced(ced);
            return dt1;
        }

        public DataTable buscarxcc(string ced, string cla)
        {
            DataTable dt2 = new DataTable();
            objCDU.buscarxcc(ced,cla);
            return dt2;
        }
    }

    
}
