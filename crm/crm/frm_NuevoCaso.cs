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
            // Cargar combo box de categoria de casos
            DataTable dt_categoria_casos = new DataTable();
            dt_categoria_casos = peticionescapa.cargar_categoria_caso();
            cmb_categoria.DataSource = dt_categoria_casos;
            cmb_categoria.ValueMember = "id_cat_caso";
            cmb_categoria.DisplayMember = "nombre_caso";

            // Cargar combo box de empleados
            DataTable dt_empleados = new DataTable();
            dt_empleados = peticionescapa.cargar_empleados();
            cmb_responsable.DataSource = dt_empleados;
            cmb_responsable.ValueMember = "id_empleado";
            cmb_responsable.DisplayMember = "nombres";

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
                cmb_empresa.Enabled = true;

            }
            else if(cmb_ente.SelectedItem == "Persona")
                {

                // Limpiar combo box de empresa ya que no se va a usar
                
                //cmb_cliente.DataSource = null;
                //cmb_cliente.Items.Clear();

                //cmb_empresa.DataSource = null;
                //cmb_empresa.Items.Clear();


                // carga de clientes sin empresa:
                DataTable clientes = new DataTable();
                //peticionescapa.cargar_clientes(cmb_cliente.SelectedValue.ToString());
                clientes = peticionescapa.cargar_clientes_SinEmpresa();
                cmb_cliente.DataSource = clientes;
                cmb_cliente.ValueMember = "id_cliente";
                cmb_cliente.DisplayMember = "nombres";
                cmb_empresa.Enabled = false;


            }
        }



        // habilita los usuarios pertenecientes a la empresa seleccionada
        private void cmb_empresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_empresa.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                //MessageBox.Show("error");
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


        // BOTON PARA INGRESAR NUEVO ENTE SEGUN OPCION SELECCIONADA
        private void btn_nuevo_ente_Click(object sender, EventArgs e)
        {
            string opcion = cmb_ente.Text;

            MessageBox.Show(opcion);

            if (cmb_ente.Text == "")
            {
                MessageBox.Show("No se ha seleccionado ninguna opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cmb_ente.Text == "Empresa")
            {
                frm_empresa empresa = new frm_empresa();
                empresa.Show();
            }
            else if (cmb_ente.Text == "Persona")
            {
                frm_cliente cliente = new frm_cliente();
                cliente.Show();
            }
        }

        // boton para crear una nueva categoria
        private void btn_nueva_categoria_Click(object sender, EventArgs e)
        {
            frm_categoria_caso caso = new frm_categoria_caso();
            caso.Show();
        }

        // boton para crear un nuevo empleado
        private void btn_nuevo_emp_Click(object sender, EventArgs e)
        {
            frm_NuevoEmpleado empleado = new frm_NuevoEmpleado();
            empleado.Show();
        }

        // boton actualizar ente (empresa o empleado)
        private void btn_actualizar_ente_Click(object sender, EventArgs e)
        {
            if (cmb_ente.SelectedItem == "Empresa")
            {
                DataTable dt_empresas = new DataTable();
                dt_empresas = peticionescapa.cargar_empresas();
                cmb_empresa.DataSource = dt_empresas;
                cmb_empresa.ValueMember = "id_empresa";
                cmb_empresa.DisplayMember = "nombre";
                cmb_empresa.Enabled = true;

            }
            else if (cmb_ente.SelectedItem == "Persona")
            {

                // Limpiar combo box de empresa ya que no se va a usar

                            // carga de clientes sin empresa:
                DataTable clientes = new DataTable();
                //peticionescapa.cargar_clientes(cmb_cliente.SelectedValue.ToString());
                clientes = peticionescapa.cargar_clientes_SinEmpresa();
                cmb_cliente.DataSource = clientes;
                cmb_cliente.ValueMember = "id_cliente";
                cmb_cliente.DisplayMember = "nombres";
                cmb_empresa.Enabled = false;


            }
        }

        // boton para actualizar empleados
        private void btn_actualizar_emp_Click(object sender, EventArgs e)
        {
          

            // Cargar combo box de empleados
            DataTable dt_empleados = new DataTable();
            dt_empleados = peticionescapa.cargar_empleados();
            cmb_responsable.DataSource = dt_empleados;
            cmb_responsable.ValueMember = "id_empleado";
            cmb_responsable.DisplayMember = "nombres";
        }

        // boton para actualizar categoria de casos
        private void btn_actualizar_cat_Click(object sender, EventArgs e)
        {
            // Cargar combo box de categoria de casos
            DataTable dt_categoria_casos = new DataTable();
            dt_categoria_casos = peticionescapa.cargar_categoria_caso();
            cmb_categoria.DataSource = dt_categoria_casos;
            cmb_categoria.ValueMember = "id_cat_caso";
            cmb_categoria.DisplayMember = "nombre_caso";

          
        }

        // boton de prueba
        private void btn_ultimo_Click(object sender, EventArgs e)
        {
            string fecha = dtp_fecha_cierre.DateTime.ToString("yyyy-MM-dd");
            MessageBox.Show(fecha);
        }


        // boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
