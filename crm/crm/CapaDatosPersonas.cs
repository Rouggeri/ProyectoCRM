﻿using System;
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
            contenedor.Rows.InsertAt(contenedor.NewRow(), 0);

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

        // ---------------------------------------------- frm_NuevoEmpleado

            // 1. Insertar nuevo empleado:
        public void InsertarEmpleado(string nombres,string apellidos,string puesto,string telefono1, string movil, string direccion, string correo, string foto)
        {
            String cadena = "insert into tbl_empleado (nombres,apellidos,puesto,telefono1,movil,direccion,correo,foto,estado) values ('"+nombres+"','"+apellidos+"','"+puesto+"','"+telefono1+"','"+movil+"','"+direccion+"','"+correo+"','"+foto+"','activo')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena,seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //2. Llenar gridchart empleados
        public DataTable ConsultarEmpleados()
        {
            DataTable almacen = new DataTable();
            String cadena = "select id_empleado,nombres,apellidos,puesto,telefono1,movil,direccion,correo,foto from tbl_empleado where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(almacen);
            return almacen;
            
        }

        //3. modificar registro de empleados
        public void ModificarEmpleado(string nombres, string apellidos, string puesto, string telefono1, string movil, string direccion, string correo, string foto,string codigo)
        {
            String cadena = "update tbl_empleado set nombres='"+nombres+"',apellidos='"+apellidos+"',puesto='"+puesto+"',telefono1='"+telefono1+"',movil='"+movil+"',direccion='"+direccion+"',correo='"+correo+"',foto='"+foto+"' where id_empleado='"+codigo+"'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //4. Eliminar Empleados (cambio de estado)
        public void EliminarEmpleado(string id_empleado)
        {
            String cadena = "update tbl_empleado set estado = 'inactivo' where id_empleado='" + id_empleado + "'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // ----------------------------------------------------- frm_nueva_moneda
        // 1. Insertar nueva moneda:
        public void Insertar_moneda(string nombre, string simbolo)
        {
            string cadena = "insert into moneda (nombre,simbolo,estado)values('"+nombre+"','"+simbolo+"','activo');";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

      


    // 2. LLenar gridchart
    public DataTable Consulta_moneda()
        {
            DataTable almacen = new DataTable();
            string cadena = "select id_moneda,nombre,simbolo from moneda where estado = 'activo';";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(almacen);
            return almacen;
        }

        // 3. Modificar un registro
        public void modificar_moneda(string nombre,string simbolo, string id)
        {
            string cadena = "update moneda set nombre='" + nombre + "',simbolo='"+simbolo+"' where id_moneda='"+id+"';";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //4. Eliminar moneda (cambio de estado a inactivo)
        public void Eliminar_Moneda(string id)
        {
            String cadena = "update moneda set estado = 'inactivo' where id_moneda='" + id + "'";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // ------------------------------------------------------ frm_moneda

        // 1. cargar combo box con monedas
        public DataTable carga_combox_monedas()
        {
            DataTable carga = new DataTable();
            string cadena = "select id_moneda,nombre,simbolo from moneda where estado = 'activo';";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            carga.Rows.InsertAt(carga.NewRow(), 0);
            return carga;

        }

        // 2. seleccionar simbolo segun opcion tomada del combobox
        public DataTable seleccion_moneda_simbolo(string simbolo)
        {
            DataTable carga = new DataTable();
            string cadena = "select simbolo from moneda where id_moneda='" + simbolo + "'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            return carga;

        }

        //3. Insertar en tabla valor_moneda
        public void Insertar_valor_moneda(string valor, string id_moneda)
        {
            string cadena = "insert into valor_moneda (valor,id_moneda)values('"+valor+"','"+id_moneda+"')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //------------------------------------ frm_NuevoCaso

        // 1. cargar combo box con  empresas

        public DataTable cargar_empresas()
        {
            DataTable carga = new DataTable();
            string cadena = "select id_empresa, nombre from empresa";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            carga.Rows.InsertAt(carga.NewRow(), 0);
            return carga;
        }

        // ---------------------------   2. cargar combo box de clientes segun empresa seleccionada
        public DataTable cargar_clientes( string id_empresa)
        {
            DataTable carga = new DataTable();
            string cadena = "select id_cliente, nombres from tbl_cliente where id_empresa='"+id_empresa+"' and estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            return carga;
        }

        //-------------------------------  3. cargar combobox de clientes que no tienen empresa (clientes individuales)
        public DataTable cargar_clientes_SinEmpresa()
        {
            DataTable carga = new DataTable();
            string cadena = "select id_cliente, nombres from tbl_cliente where estado = 'activo' and id_empresa = '4'; ";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            return carga;
        }

        //----------------------------------    4. Cargar combobox de Categoria

        public DataTable cargar_categoria_caso()
        {
            DataTable categoria = new DataTable();
            string cadena = "select id_cat_caso, nombre_caso, estado from categoria_caso where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(cadena,seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(categoria);
            categoria.Rows.InsertAt(categoria.NewRow(),0);
            return categoria;
        }


        //----------------------------------  5. Cargar combobox de Empleado responsable
        public DataTable cargar_empleados()
        {
            DataTable categoria = new DataTable();
            string cadena = "select id_empleado, nombres, apellidos from tbl_empleado where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(categoria);
            categoria.Rows.InsertAt(categoria.NewRow(),0);
            return categoria;
        }

        //----------------------------------- 6. Insertar en tabla de casos
        public void Insertar_NuevoCaso(string id_empleado,string id_cliente, string id_empresa, string titulo, string estado_caso, string fecha_limite, string
            descripcion, string id_cat_caso)
        {
            string cadena = "insert into caso (id_empleado,id_cliente,id_empresa,titulo,estado_caso,fecha_asignacion,fecha_limite,descripcion,id_cat_caso,estado)values('"+id_empleado+"','"+id_cliente+"','"+id_empresa+"','"+titulo+"','"+estado_caso+"',sysdate(),'"+fecha_limite+"','"+descripcion+"','"+id_cat_caso+"','activo')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //------------------------------------ 7. Seleccionar casos
        public DataTable cargar_casos()
        {
            DataTable categoria = new DataTable();
            //string cadena = " select id_empleado,id_cliente,id_empresa,titulo,estado_caso,fecha_asignacion,fecha_limite,fecha_finalizacion,descripcion,id_cat_caso from caso where estado = 'activo'";
            string cadena = "select e.nombre,cl.nombres,cl.apellidos,c.titulo,c.descripcion, emp.nombres,emp.apellidos, cat.nombre_caso,c.estado_caso,c.fecha_asignacion,c.fecha_limite , e.id_empresa,cl.id_cliente,emp.id_empleado,cat.id_cat_caso  from empresa e, caso c, tbl_cliente cl, tbl_empleado emp, categoria_caso cat where cl.id_cliente = c.id_cliente and e.id_empresa = c.id_empresa and emp.id_empleado = c.id_empleado and cat.id_cat_caso = c.id_cat_caso and c.estado_caso = 'Abierto'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(categoria);
            categoria.Rows.InsertAt(categoria.NewRow(), 0);
            return categoria;
        }


        // -------------------------------------- frm_categoria_caso

        // 1. insertar nueva categoria
        public void Insertar_NuevaCategoria_Caso(string categoria)
        {
            string cadena = "insert into categoria_caso (nombre_caso,estado) values ('"+categoria+"','activo')";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // 2. Seleccionar datos de la tabla categoria
        public DataTable cargar_categoria()
        {
            DataTable carga = new DataTable();
            string cadena = "select id_cat_caso,nombre_caso from categoria_caso where estado = 'activo'";
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            OdbcDataAdapter adap = new OdbcDataAdapter(cmd);
            adap.Fill(carga);
            return carga;
        }

        // 3. Modificar datos de la tabla categoria
        public void modificar_categoria(string nombre, string id)
        {
            string cadena = "update categoria_caso set nombre_caso='" + nombre + "' where id_cat_caso='" + id + "';";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // 4. Eliminar datos de la tabla categoria (cambio de estado a inactivo)
        public void eliminar_categoria(string id)
        {
            string cadena = "update categoria_caso set estado = 'inactivo' where id_cat_caso='" + id + "';";
            OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
            OdbcCommand cmd = new OdbcCommand(cadena, seguridad.Conexion.ObtenerConexionODBC());
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
