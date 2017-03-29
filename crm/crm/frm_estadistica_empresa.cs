using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;


namespace crm
{
    public partial class frm_estadistica_empresa : DevExpress.XtraEditors.XtraForm
    {
        public frm_estadistica_empresa()
        {
            InitializeComponent();
        }

        CapaDatosPersonas CapaDatos = new CapaDatosPersonas();
        string var_id_usuario = "";
        // variables para determinar fecha y dia
        DateTime fecha_hoy = DateTime.Today;
        Calendar calendario = CultureInfo.InvariantCulture.Calendar;
        string nombre = "";

        private void btn_semanal_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_estadistica_empresa_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btn_hoy_Click(object sender, EventArgs e)
        {
            nombre = calendario.GetDayOfWeek(fecha_hoy).ToString();

            MessageBox.Show("Hoy es: " + nombre + " con fecha: " + fecha_hoy.ToString("yyyy-MM-dd"));
        }
    }
}