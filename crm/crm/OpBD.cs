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
                OdbcCommand comando = new OdbcCommand("select n.detalles, n.etapa_negocio, n.fecha_inicio, n.id_empleado, concat(e.nombres, ' ', e.apellidos) as nom_emp, n.status from tbl_negocio n left join tbl_empleado e on n.id_empleado = e.id_empleado where id_negocio = "+id_negocio+"", con);
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


        public static DataTable SeleccionarNegocioEspecifico(string id_negocio)
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.id_negocio = "+id_negocio+" ", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }


        public static DataTable SeleccionarNegociosEtapa0()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.estado = 'activo' and etapa_negocio = 0 ", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarNegociosEtapa1()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.estado = 'activo' and etapa_negocio = 1 ", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarNegociosEtapa2()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.estado = 'activo' and etapa_negocio = 2 ", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                return dt;
            }
            catch { return null; }
        }

        public static DataTable SeleccionarNegociosEtapa3()
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select n.id_negocio, n.titulo, concat(c.nombres,' ',c.apellidos) as nombre_clie, e.nombre,concat(m.nombre,'(', m.simbolo,')') as mon, n.valor, n.fecha_est_cierre, ca.nombre_cat from tbl_negocio n left join tbl_cliente c on n.id_cliente = c.id_cliente left join empresa e on n.id_empresa = e.id_empresa inner join moneda m on n.id_moneda = m.id_moneda inner join categoria_neg ca on n.id_cat = ca.id_cat where n.estado = 'activo' and etapa_negocio = 3 ", con);
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

        public static DataTable SeleccionarNotas(string id_negocio)
        {
            try
            {
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                OdbcCommand comando = new OdbcCommand("select * from notas where id_negocio = '"+id_negocio+"'", con);
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
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_cliente, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_empresa, estado, status)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + ","+valor+",'"+fecha+"',curdate(),"+cat+",0,'activo', 'En Proceso')";
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
                string query = "insert into tbl_negocio(id_negocio, etapa_negocio, id_empresa, id_empleado, titulo, detalles, id_moneda, valor, fecha_est_cierre, fecha_inicio, id_cat, id_cliente ,estado, status)" +
                   " values ( null ," + etapa + ", " + perem + "," + empleado + ",'" + titulo + "','" + detalles + "'," + moneda + "," + valor + ",'" + fecha + "',curdate()," + cat + ",0,'activo', 'En Proceso')";
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

        public int InsertarNota(string nota, string id_negocio, string titulo)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "insert into notas(id_nota, id_negocio, nota)" +
                   " values ( null ," + id_negocio + ",'"+nota+"')";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Registro de una nota en el negocio: "+titulo, "notas");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int ActualizarNota(string nota, string id_nota, string titulo)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "update notas set nota = '"+nota+"' where id_nota = "+id_nota+" ";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Actualizacion de una nota en el negocio: " + titulo, "notas");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }

        public int EliminarNota(string id_nota, string titulo)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "delete from notas where id_nota = " + id_nota + "";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Eliminación de una nota en el negocio: " + titulo, "notas");
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




        //public static DataTable PermisosDeUsuario(string id_negocio)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        OdbcConnection con = seguridad.Conexion.ConexionPermisos();
        //        OdbcCommand comando = new OdbcCommand("select ins, from notas where id_negocio = '" + id_negocio + "'", con);
        //        OdbcDataAdapter ad = new OdbcDataAdapter(comando);
        //        ad.Fill(dt);
        //        return dt;
        //    }
        //    catch { return null; }
        //}

        public int ActualizarEstatus(string estatus, string id_negocio, string nombre)
        {
            try
            {

                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "update tbl_negocio set status = '" + estatus + "' where id_negocio = " +id_negocio + " ";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.ExecuteNonQuery();
                try
                {
                    bita.Insertar("Actualizacion del estado del negocio: " + nombre, "negocio");
                }
                catch { MessageBox.Show("Error en bitacora"); }

                con.Close();
                return 1;
            }
            catch { return 0; }
        }























        //public static void DesbloquearMDI(MenuStrip MenuMDI)
        //{

        //    DataTable dt_permisos = new DataTable();
        //    OdbcConnection con = seguridad.Conexion.ConexionPermisos();
        //    OdbcCommand comando = new OdbcCommand("select p.id_aplicacion, a.id_modulo from usuario_privilegios p inner join aplicacion a on p.id_aplicacion = a.id_aplicacion where p.usuario = '"+seguridad.Conexion.User+"' ", con);
        //    OdbcDataAdapter ad = new OdbcDataAdapter(comando);
        //    ad.Fill(dt_permisos);

        //    foreach (ToolStripMenuItem menu_principal in MenuMDI.Items)
        //    {
        //        string modulo_menu = "0";
        //        if (menu_principal.Tag != null)
        //        {
        //             modulo_menu = menu_principal.Tag.ToString();
        //        }
        //        foreach (DataRow row_aplicaciones in dt_permisos.Rows)
        //        {
        //            string modulo_aplicacion = row_aplicaciones[1].ToString();
        //            if (modulo_aplicacion == modulo_menu)
        //            {
        //                menu_principal.Enabled = true;
        //                break;
        //            }
        //        }
        //    }

        //    foreach (ToolStripMenuItem menu_principal in MenuMDI.Items)
        //    {

        //        foreach (ToolStripMenuItem sub_menu in menu_principal.DropDownItems)
        //        {
        //            string aplicacion_menu = "0";
        //            if (sub_menu.Tag != null)
        //            {
        //                aplicacion_menu = sub_menu.Tag.ToString();
        //            }
        //            foreach (DataRow row_aplicaciones in dt_permisos.Rows)
        //            {
        //                string aplicacion = row_aplicaciones[0].ToString();
        //                if (aplicacion == aplicacion_menu)
        //                {
        //                    sub_menu.Enabled = true;
        //                    break;
        //                }
        //            }


        //        }

        //    }





        //}












    }
}
