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
        string fecha = "";
        string open = "Abierto";
        string close = "Cerrado";
        string estado = "";

        // formulario de Nuevo Caso
        private void frm_NuevoCaso_Load(object sender, EventArgs e)
        {
            try
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

                // Cargar GridView de casos
                DataTable dt_casos = new DataTable();
                dt_casos = peticionescapa.cargar_casos();
                dgv_casos.DataSource = dt_casos;
                gridView1.Columns["id_empresa"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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

                DataTable dt_empresas = new DataTable();
                dt_empresas = peticionescapa.cargar_empresas();
                cmb_empresa.DataSource = dt_empresas;
                cmb_empresa.ValueMember = "id_empresa";
                cmb_empresa.DisplayMember = "nombre";
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
            fecha = dtp_fecha_cierre.DateTime.ToString("yyyy-MM-dd");
            //MessageBox.Show(fecha);
        }


        // boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
       


            MessageBox.Show("holii");
            
            


        }

        private void switch_caso_Toggled(object sender, EventArgs e)
        {
            //switch_caso toggle = (ToggleSwitch)sender;
            //toggle.Toggled += ToggleSwitch_Toggled;

            if (switch_caso.IsOn)
            {
                switch_caso.BackColor = Color.Red;
                estado = close;
            }
            else
            {
                switch_caso.BackColor = Color.MediumSeaGreen;
                estado = open;
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (switch_caso.IsOn)
            {
                estado = close;
            }
            else
            {
                estado = open;
            }


        }

       

        // boton para almacenar en la base de datos un nuevo caso
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string valor_empresa = cmb_empresa.SelectedValue.ToString();

                if (valor_empresa == "")
                {
                    valor_empresa = "4";
                }


                fecha = dtp_fecha_cierre.DateTime.ToString("yyyy-MM-dd");
                if (txt_titulo.Text.Trim() == "" || txt_descripcion.Text.Trim() == "" ||cmb_responsable.Text==""||cmb_categoria.Text==""||cmb_cliente.Text=="" )
                {
                    MessageBox.Show("Uno o más campos estan vacios","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    peticionescapa.Insertar_NuevoCaso(cmb_responsable.SelectedValue.ToString(), cmb_cliente.SelectedValue.ToString(), valor_empresa
                    , txt_titulo.Text.Trim(), estado, fecha, txt_descripcion.Text.Trim(), cmb_categoria.SelectedValue.ToString());
                    MessageBox.Show("Caso asignado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        // boton actualizar gridview casos
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Cargar GridView de casos
            DataTable dt_casos = new DataTable();
            dt_casos = peticionescapa.cargar_casos();
            dgv_casos.DataSource = dt_casos;

            
=======
        private void btn_guardar_Click(object sender, EventArgs e)
        {

>>>>>>> 4aa5b785a48dd1956c65091fcb19d240d0736deb
        }
    }
    
}
