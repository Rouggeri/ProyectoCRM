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
        // -------------------------------- FRM_CLIENTE: 

        //1.  insertción de nuevo cliente
        public void InsertarNuevoCliente(string nombres, string apellidos, string empresa, string puesto, string movil, string telefono, string correo)
        {
            String cadena = "insert into tbl_cliente(nombres,apellidos,id_empresa,puesto,movil,telefono,correo,estado)values('"+nombres+"','"+apellidos+"','"+empresa+"','"+puesto+"','"+movil+"','"+telefono+"','"+correo+"','activo')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        //2.  Consulta de los clientes ingresados
        public DataTable SeleccionarListaClientes()
        {            
            String cadena = "select id_cliente,nombres, apellidos,id_empresa,puesto,movil,telefono, correo,estado  from tbl_cliente where estado = 'activo' ";
            DataTable contenedor = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(contenedor);
            return contenedor;

        }
        // 3. Modificacion de clientes:
        public void ModificarCliente(string nombres, string apellidos, string empresa, string puesto, string movil, string telefono, string correo, string id_cliente)
        {
            String cadena = "update tbl_cliente set nombres = '"+nombres+"',apellidos='"+apellidos+"',id_empresa='"+empresa+"',puesto='"+puesto+"',movil='"+movil+"',telefono='"+telefono+"',correo='"+correo+"' where id_cliente='"+id_cliente+"'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //4. Carga de combobox con empresas
        public DataTable SeleccionarEmpresas()
        {
            String cadena = "select id_empresa,nombre from empresa";
            DataTable contenedor = new DataTable();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(contenedor);
            return contenedor;

        }

        //5. Eliminar Clientes (cambio de estado)
        public void EliminarCliente(string id_cliente)
        {
            String cadena = "update tbl_cliente set estado = 'inactivo' where id_cliente='" + id_cliente + "'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
