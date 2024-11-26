using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class CN_tbl_tipo_usuario
    {
        private CD_tbl_tipo_usuario objCDTU = new CD_tbl_tipo_usuario();

        public DataTable cn_mostrar_tu()
        {
            DataTable dt = new DataTable();
            dt = objCDTU.cd_mostrar_tu();
            return dt;
        }
    }
}
