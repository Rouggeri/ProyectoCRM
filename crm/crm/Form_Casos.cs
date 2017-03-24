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
    public partial class Form_Casos : Form
    {
        public Form_Casos()
        {
            InitializeComponent();
        }
        CapaDatosPersonas peticionescapa = new CapaDatosPersonas();
        string id_form = "102";
        private void btn_nuevocaso_Click(object sender, EventArgs e)
        {
            frm_NuevoCaso f = new frm_NuevoCaso();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void Form_Casos_Load(object sender, EventArgs e)
        {

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

            // carga de datos en formulario
            // Cargar GridView de casos
            DataTable dt_casos = new DataTable();
            dt_casos = peticionescapa.cargar_casos();
            dgv_casos.DataSource = dt_casos;
            // columnas ocultas
            gridView1.Columns["id_empresa"].Visible = false;
            gridView1.Columns["id_empleado"].Visible = false;
            gridView1.Columns["id_cliente"].Visible = false;
            gridView1.Columns["id_cat_caso"].Visible = false;
            gridView1.Columns["id_caso"].Visible = false;

            // headers de las columnas
            gridView1.Columns["nombre"].Caption = "Empresa";
            gridView1.Columns["nombres"].Caption = "Nombre del cliente";
            gridView1.Columns["apellidos"].Caption = "Apellido del cliente";
            gridView1.Columns["nombres1"].Caption = "Nombre del encargado";
            gridView1.Columns["apellidos1"].Caption = "Apellido del encargado";
            gridView1.Columns["fecha_asignacion"].Caption = "Asignacion";
            gridView1.Columns["fecha_limite"].Caption = "Fecha limite";
            gridView1.Columns["nombre_caso"].Caption = "Categoria";
            gridView1.Columns["estado_caso"].Caption = "Estado";



        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_NuevoCaso f = new frm_NuevoCaso();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
