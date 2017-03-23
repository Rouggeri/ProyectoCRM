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
using FuncionesNavegador;


namespace crm
{
    public partial class FormContactos : Form
    {
        public FormContactos()
        {
            InitializeComponent();
        }
        string id_form = "103";
        private void FormContactos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //btn_opciones.Enabled = false;
            try
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


           
                DataTable dt = new DataTable();
                OdbcConnection con = seguridad.Conexion.ObtenerConexionM();
                OdbcCommand comando = new OdbcCommand("select * from contacto", con);
                OdbcDataAdapter ad = new OdbcDataAdapter(comando);
                ad.Fill(dt);
                gridControl1.DataSource = dt;

            }catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

      
    }
}
