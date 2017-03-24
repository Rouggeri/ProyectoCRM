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

        
        public static DataTable SeleccionarDatosRestantes(string id_negocio)
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select n.detalles, n.etapa_negocio, n.fecha_inicio, n.id_empleado, concat(e.nombres, ' ', e.apellidos) as nom_emp from tbl_negocio n left join tbl_empleado e on n.id_empleado = e.id_empleado where id_negocio = "+id_negocio+"", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarNegocios()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.estado = 'activo' ", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarCategorias()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select nombre_cat from categoria_neg", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }
        public static DataTable SeleccionarCategoriascbo()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from categoria_neg", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarClientes()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_cliente, concat(nombres,' ',apellidos) as nom from tbl_cliente where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarEmpleados()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_empleado, concat(id_empleado,' - ',nombres,' ',apellidos) as Empleado from tbl_empleado where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarMonedas()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_moneda, concat(simbolo,' - ',nombre) as Moneda from moneda where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }


        public static DataTable SeleccionarEmpresas()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select id_empresa, nombre from empresa where estado = 'activo'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public int InsertarNegocioClie(string titulo, int perem, string detalles, int moneda, decimal valor, int cat, int empleado, int etapa, string fecha)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_cliente, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_empresa, estado)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + ","+valor+",'"+fecha+"',curdate(),"+cat+",0,'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de negocio: " + titulo, "tbl_negocio");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int InsertarNegocioEmp(string titulo, int perem, string detalles, int moneda, decimal valor, int cat, int empleado, int etapa, string fecha)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_empresa, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_cliente ,estado)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + "," + valor + ",'" + fecha + "',curdate()," + cat + ",0,'activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de negocio: " + titulo, "tbl_negocio");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
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

        public  int InsertarCategoria(string nombre)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into categoria_neg(id_cat, nombre_cat, estado)" +
                   " values ( null ,'" + nombre + "','activo')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de categoria: " + nombre, "categoria_neg");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }




        public static string VerificarTipoUsuario()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ConexionPermisos();
                OdbcCommand comando = new OdbcCommand("select tipo from usuario where usuario = '"+seguridad.Conexion.User+"'", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);

                DataRow row = dt.Rows[0];
                string tipo = row[0].ToString();
                return tipo;
            }
            catch { return "error"; }
        }



    }
}
