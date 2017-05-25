using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crm
{
    public partial class frm_existencia : Form
    {
        string id_form = "119";
        public frm_existencia()
        {
            InitializeComponent();
            llenarprod();
            llenarbod();
        }

        public void llenar_encabezado()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Producto";
            c1.Width = 100;
            c1.ReadOnly = true;

            dgv_existencia.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Bodega";
            c2.Width = 50;
            c2.ReadOnly = true;

            dgv_existencia.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Fecha_Ingreso";
            c3.Width = 75;
            c3.ReadOnly = true;

            dgv_existencia.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "Cantidad";
            c4.Width = 50;
            c4.ReadOnly = true;

            dgv_existencia.Columns.Add(c4);
        }
        

        private void llenarprod()
        {
            negocio cnegocio = new negocio();
            cbo_producto.ValueMember = "id";
            cbo_producto.DisplayMember = "nombre";
            cbo_producto.DataSource = cnegocio.consultar();
        }

        private void llenarbod()
        {
            negocio cnegocio = new negocio();
            cbo_bodega.DataSource = cnegocio.consultarbod();
            cbo_bodega.ValueMember = "id_bodega";
            cbo_bodega.DisplayMember = "nombre_bodega";
        }

        private void frm_existencia_Load(object sender, EventArgs e)
        {
            txt_ingreso.Text = Convert.ToString(DateTime.Today);
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            entidades.Existencia existencia = new entidades.Existencia();  //Creamos un objeto de la capa de Entidades para poder acceder a sus objetos
            negocio cnegocio = new negocio();                       //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            existencia.cantidad = Convert.ToInt32(txt_cantidad.Text); //Llenamos el objeto persona con la informacion de los cuadros de texto/
            existencia.producto = Convert.ToInt32(cbo_producto.SelectedIndex + 1);
            existencia.bodega = Convert.ToInt32(cbo_bodega.SelectedIndex + 1);
            existencia.ingreso = Convert.ToString(DateTime.Today);
            cnegocio.InsertarExistencia(existencia);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            negocio cnegocio = new negocio();           //Creamos un objeto de la capa de negocio para poder acceder a sus funciones
            dgv_existencia.DataSource = cnegocio.consultaex();
        }
    }
}
