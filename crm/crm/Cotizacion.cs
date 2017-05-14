using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace proyectoUOne
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            //llenarComboDescrpicion();
            llenarComboDescrpicion();
        }

        //llenar combobox descripcion de producto
        public void llenarComboDescrpicion()
        {
            try
            {
                OdbcConnection con = seguridad.Conexion.ObtenerConexionODBC();
                string query = "select descripcion from producto ORDER BY descripcion ASC;";
                OdbcCommand cmd = new OdbcCommand(query, con);
                OdbcDataAdapter da1 = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                cmb_descripcion.ValueMember = "descripcion";
                cmb_descripcion.DisplayMember = "descripcion";
                cmb_descripcion.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error al llenar combobox descripcion");
            }

        }
        
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                dtpFechaI.Format = DateTimePickerFormat.Custom;
                dtpFechaI.CustomFormat = "yyyy-MM-dd";

                dtpFechaT.Format = DateTimePickerFormat.Custom;
                dtpFechaT.CustomFormat = "yyyy-MM-dd";
                CapaDatos inserta = new CapaDatos();
                inserta.InsertarCotizacion(txtCliente.Text.Trim(), txtCorreo.Text.Trim(), dtpFechaI.Text.Trim(), dtpFechaT.Text.Trim());

                CapaDatos v = new CapaDatos();
                DataTable dt1 = CapaDatos.CargarGridAutoIncrement("select AUTO_INCREMENT from information_schema.TABLES where TABLE_SCHEMA='crmbd' and TABLE_NAME='cotizacion_encabezado';");
                DataRow rows = dt1.Rows[0];
                int id_req = Convert.ToInt32(rows[0]);

                foreach (DataGridViewRow row in dgvCotizacion.Rows)
                {
                    int codigo_cotizacionN = id_req - 1;
                    int codigo_productoN = Convert.ToInt32(row.Cells[0].Value);
                    int cantidadN = Convert.ToInt32(row.Cells[3].Value);
                    double subttotalN = Convert.ToDouble(row.Cells[4].Value);
                    v.insertar_detalle_cotizacion(codigo_cotizacionN, codigo_productoN, cantidadN, subttotalN);
                }

            }
            catch {
                MessageBox.Show("Error al guardar datos de insercion");
            }
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos nuev = new CapaDatos();
                int convertir = Convert.ToInt32(txt_codigoP.Text.Trim());
                DataTable dt;
                dt = nuev.query_precioUnidad(convertir);
                cmb_prueba.ValueMember = "precio_unidad";
                cmb_prueba.DisplayMember = "precio_unidad";
                cmb_prueba.DataSource = dt;
                double subtotall = Convert.ToInt32(cmb_prueba.SelectedValue.ToString()) * Convert.ToInt32(txt_cantidad.Text.Trim());
                dgvCotizacion.Rows.Insert(0, convertir, cmb_descripcion.SelectedValue.ToString(), cmb_prueba.SelectedValue.ToString(),txt_cantidad.Text, subtotall);

                int suma = 0;
                foreach (DataGridViewRow row in dgvCotizacion.Rows)
                {
                    suma += Convert.ToInt32(row.Cells["Subtotal"].Value);
                    //suma += (int)row.Cells["Subtotal"].Value;
                }
                txt_total.Text = Convert.ToString(suma);
                txt_cantidad.Text = "";
                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error al agregar a detalle");
            }            
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {

            CapaDatos cap = new CapaDatos();
            //cap.llenar_id_pro(cmbCodigo);
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            
        }

        //Eliminar fila de datagrid con opcion de cancelar
        private void dgvCotizacion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Desea Eliminar la Fila? ", " Message of Option Delete ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvCotizacion.Rows.RemoveAt(dgvCotizacion.CurrentRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fila Vacia U Otro Error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == null)
                {
                    llenarComboDescrpicion();
                    txt_codigoP.Text = "";
                }
                else {
                    descripcionNoestavacio();
                    CodigoProductoText();               
                }               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //si esta vacio
        public void descripcionNoestavacio()
        {
            try
            {
                    DataTable carga = CapaDatos.CargarGridAutoIncrement("select descripcion from producto WHERE id_producto like '%"+ textBox2.Text +"%' or descripcion like '%"+ textBox2.Text +"%'");
                    DataRow rows = carga.Rows[0];
                    string cod_prod = Convert.ToString(rows[0]);
                    cmb_descripcion.Text = cod_prod.ToString();
                    cmb_descripcion.DisplayMember = cod_prod.ToString();
                    //cmb_descripcion.ValueMember = cod_prod.ToString();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar datos a combo");
            }
        }
        //si no esta vacio
        public void CodigoProductoText()
        {
            try
            {
                DataTable carga = CapaDatos.CargarGridAutoIncrement("select id_producto from producto WHERE id_producto like '%"+ textBox2.Text +"%' or descripcion like '%"+ textBox2.Text +"%'");
                DataRow rows = carga.Rows[0];
                string cod_prod = Convert.ToString(rows[0]);
                txt_codigoP.Text = cod_prod;
            }
            catch
            {
                MessageBox.Show("No existe producto con esta descripcion");
            }
        }

        private void cmb_descripcion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable carga = CapaDatos.CargarGridAutoIncrement("select id_producto from producto WHERE descripcion like '%"+ cmb_descripcion.SelectedValue +"%'");
                DataRow rows = carga.Rows[0];
                string cod_prod = Convert.ToString(rows[0]);
                txt_codigoP.Text = cod_prod;
            }
            catch
            {
                MessageBox.Show("No existe producto con descripcion");
            }
        }

        private void cmb_descripcion_MouseCaptureChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
