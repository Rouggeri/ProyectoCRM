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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            // Iniciar grid (limpiarlo)
            dgv_clientes.DataSource = "";

            CapaDatosPersonas inserta = new CapaDatosPersonas();
            inserta.InsertarNuevoCliente(txt_nombres.Text.Trim(),txt_apellidos.Text.Trim(),
            cmb_empresa.Text,txt_puesto.Text,txt_movil.Text,txt_telefono.Text,txt_correo.Text);

            // carga de datagrid
            DataTable contenedor = inserta.SeleccionarListaClientes();
            dgv_clientes.DataSource = contenedor;

            // Cambio de nombre a los headers de las columnas
            
                
        }


        // load de formulario cliente
        private void frm_cliente_Load(object sender, EventArgs e)
        {
            CapaDatosPersonas inserta = new CapaDatosPersonas();
            DataTable contenedor = inserta.SeleccionarListaClientes();
            dgv_clientes.DataSource = contenedor;
        }
    }
}
