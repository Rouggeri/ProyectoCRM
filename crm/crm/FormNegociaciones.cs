using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuncionesNavegador;

namespace crm
{
    public partial class FormNegociaciones : Form
    {
        public FormNegociaciones()
        {
            InitializeComponent();
        }
        string id_form = "104";
        private void FormNegociaciones_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            CapaNegocio fn = new CapaNegocio();
            DataTable seg = seguridad.ObtenerPermisos.Permisos(seguridad.Conexion.User, id_form);
            if (seg.Rows.Count > 0)
            {
                fn.desactivarPermiso(seg, btn_guardar, btn_eliminar, btn_editar, btn_nuevo, btn_cancelar, btn_actualizar, btn_buscar, btn_anterior, btn_siguiente, btn_primero, btn_ultimo);
            }
            else
            {
                btn_guardar.Enabled = false; btn_eliminar.Enabled = false; btn_editar.Enabled = false; btn_nuevo.Enabled = false; btn_actualizar.Enabled = false; btn_cancelar.Enabled = false; btn_buscar.Enabled = false;
            }




            dgv_negocios.DataSource = OpBD.SeleccionarNegocios();
            if (dgv_negocios.DataSource != null)
            {
                dgv_neg.Columns[0].Caption = "No.";
                dgv_neg.Columns[1].Caption = "Titulo";
                dgv_neg.Columns[2].Caption = "Persona";
                dgv_neg.Columns[3].Caption = "Organización";
                dgv_neg.Columns[4].Caption = "Moneda";
                dgv_neg.Columns[5].Caption = "Valor";
                dgv_neg.Columns[6].Caption = "Fecha de cierre estimada";
                dgv_neg.Columns[7].Caption = "Categoría";

                dgv_neg.Columns[0].Width = 28;
                dgv_neg.RowClick += Dgv_neg_RowClick;
            }
            dgv_neg.OptionsBehavior.ReadOnly = true;
            
        }

        private void Dgv_neg_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = dgv_neg.GetFocusedDataRow();
            string id_negocio = row[0].ToString();
            string titulo = row[1].ToString();
            string cliente = row[2].ToString();
            string empresa = row[3].ToString();
            string moneda = row[4].ToString();
            string valor = row[5].ToString();
            string fecha_cierre = row[6].ToString();
            string categoria = row[7].ToString();

            FormDetallesNegocio f = new FormDetallesNegocio();
            f.id_negocio = id_negocio;
            f.titulo = titulo;
            f.nombre_persona = cliente;
            f.nombre_empresa = empresa;
            f.moneda = moneda;
            f.valor= valor;
            f.fecha_cierre = fecha_cierre;
            f.categoria = categoria;

            f.MdiParent = this.MdiParent;
            f.Show();
    }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            FormNuevoNegocio f = new FormNuevoNegocio();
            f.MdiParent = this.MdiParent;
            f.Show();
            
        }

        private void dgv_negocios_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            FormNuevoNegocio f = new FormNuevoNegocio();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
