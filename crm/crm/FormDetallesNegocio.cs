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
    public partial class FormDetallesNegocio : Form
    {
        public FormDetallesNegocio()
        {
            InitializeComponent();
        }

        public string id_negocio;
        public string titulo;
        public string nombre_persona;
        public string nombre_empresa;
        public string moneda;
        public string valor;
        public string fecha_cierre;
        public string categoria;

        private void FormDetallesNegocio_Load(object sender, EventArgs e)
        {
            this.Text = titulo;

            DataTable dt = OpBD.SeleccionarDatosRestantes(id_negocio);
            DataRow row = dt.Rows[0];
            string detalles = row[0].ToString();
            string etapa = row[1].ToString();
            string fecha_inicio = row[2].ToString();
            string id_empleado = row[3].ToString();
            string nombre_empleado = row[4].ToString();

            groupControl1.Text = titulo;
            if(!String.IsNullOrEmpty(nombre_persona))
            {
                lbl_cliente.Text = nombre_persona;
            }
            else if (!String.IsNullOrEmpty(nombre_empresa))
                {
                lbl_cliente.Text = nombre_empresa;
                }
        }


    }
}
