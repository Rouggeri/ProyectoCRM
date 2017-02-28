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
    public class CapaDatosPersonas
    {

        // insertción de nuevo cliente
        public void InsertarNuevoCliente(string nombres, string apellidos, string empresa, string puesto, string movil, string telefono, string correo)
        {
            String cadena = "insert into tbl_cliente(nombres,apellidos,id_empresa,puesto,movil,telefono,correo)values('"+nombres+"','"+apellidos+"','"+empresa+"','"+puesto+"','"+movil+"','"+telefono+"','"+correo+"')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        // Consulta de los clientes ingresados
        public DataTable SeleccionarListaClientes()
        {            
            String cadena = "select nombres, apellidos,id_empresa,puesto,movil,telefono, correo from tbl_cliente";
            DataTable contenedor = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(contenedor);
            return contenedor;

        }
    }
}
