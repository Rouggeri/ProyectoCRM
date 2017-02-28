using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace crm
{
    class OpBD
    {

        public static DataTable SeleccionarPaises()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from pais", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

    }
}
