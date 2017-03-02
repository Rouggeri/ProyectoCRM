using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace crm
{
    class OpBD
    {
        seguridad.bitacora bita = new seguridad.bitacora();
        

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


        public int InsertarEmpresa(string nombre, string direccion, string correo, string tel1, string tel2, int pais)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                string query = "insert into empresa(id_empresa, nombre, direccion, correo, telefono1, telefono2, id_pais,estado)"+
                   " values ( null ,'" + nombre + "', '" + direccion + "','"+correo+"','"+tel1+"','"+tel2+"',"+pais+",'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de empresa: " + nombre, "empresa");
                }
                catch { MessageBox.Show("Error en bitacora"); }
                
                con.Close();
                return 1;
            }
            catch { return 0; }
        }



    }
}
