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
    public partial class frm_NuevoCaso : Form
    {
        public frm_NuevoCaso()
        {
            InitializeComponent();
        }

        CapaDatosPersonas peticionescapa = new CapaDatosPersonas();

        // formulario de Nuevo Caso
        private void frm_NuevoCaso_Load(object sender, EventArgs e)
        {
            //DataTable dt_empresas = new DataTable();
            //dt_empresas = peticionescapa.cargar_empresas();
            //cmb_empresa.DataSource = dt_empresas;
            //cmb_empresa.ValueMember = "id_empresa";
            //cmb_empresa.DisplayMember = "nombre";

        }

        

        private void cmb_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }


        // habiliar combo box de empresas y clientes segun opcion seleccionada
        private void cmb_ente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ente.SelectedItem == "Empresa")
            {
                DataTable dt_empresas = new DataTable();
                dt_empresas = peticionescapa.cargar_empresas();
                cmb_empresa.DataSource = dt_empresas;
                cmb_empresa.ValueMember = "id_empresa";
                cmb_empresa.DisplayMember = "nombre";
            }
                else if(cmb_ente.SelectedItem == "Persona")
                {

                // Limpiar combo box de empresa ya que no se va a usar
                cmb_cliente.DataSource = null;
                cmb_cliente.Items.Clear();

                cmb_empresa.DataSource = null;
                cmb_empresa.Items.Clear();


                // carga de clientes sin empresa:
                DataTable clientes = new DataTable();
                //peticionescapa.cargar_clientes(cmb_cliente.SelectedValue.ToString());
                clientes = peticionescapa.cargar_clientes_SinEmpresa();
                cmb_cliente.DataSource = clientes;
                cmb_cliente.ValueMember = "id_cliente";
                cmb_cliente.DisplayMember = "nombres";


            }
        }



        // habilita los usuarios pertenecientes a la empresa seleccionada
        private void cmb_empresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_empresa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                MessageBox.Show("error");
            }
            else if (cmb_empresa.SelectedValue.ToString() == "")
            {

                cmb_cliente.DataSource = null;
                cmb_cliente.Items.Clear();

            }
            else
            {

                DataTable clientes = new DataTable();
                //peticionescapa.cargar_clientes(cmb_cliente.SelectedValue.ToString());
                clientes = peticionescapa.cargar_clientes(cmb_empresa.SelectedValue.ToString());
                cmb_cliente.DataSource = clientes;
                cmb_cliente.ValueMember = "id_cliente";
                cmb_cliente.DisplayMember = "nombres";


            }
        }
    }
}
