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
    public partial class frm_pronostico_ventas_secundario : Form
    {
        public frm_pronostico_ventas_secundario()
        {
            InitializeComponent();
        }
        // Llamada a la capaDeDatos 
        CapaDatosPersonas capadatos = new CapaDatosPersonas();

        // Datatables:
        DataTable dt_cat_negos = new DataTable(); // dt que sirve para cargar las categorias de negocios



        // Clasificacion es para Negocios o Ventas de productos
        // Categoria es para subcategoria de negocios o subcategoria de productos


        // Radio button para seleccionar negocios O ventas en especifico
        private void rbt_seleccionar_clasificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_seleccionar_clasificacion.Checked)
            {
                cmb_clasificacion.Enabled = true;
                rbt_seleccionar_categoria.Enabled = true;
            }
            
        }

        // Radio button para seleccionar negocios Y ventas en especifico
        private void rbt_todos_clasificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_todos_clasificacion.Checked)
            {
                cmb_clasificacion.Enabled = false;
                cmb_categoria.Enabled = false;
                cmb_clasificacion.Text = "";

                rbt_todos_categoria.Checked = true;
                rbt_seleccionar_categoria.Enabled = false;

                dt_cat_negos.Clear();

            }
            
        }
        // Radio button para seleccionar un producto o servicio en especifico
        private void rbt_seleccionar_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_seleccionar_categoria.Enabled)
            {
                cmb_categoria.Enabled = true;
            }
        }

        // Radio button para seleccionar un producto Y servicios
        private void rbt_todos_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_todos_categoria.Enabled)
            {
                cmb_categoria.Enabled = false;
            }
        }



        // ComboBox, sirve para llamar a las categorias
        private void cmb_clasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_clasificacion.SelectedItem.ToString() == "Negocios")
            {
                dt_cat_negos =  capadatos.seleccionar_cat_negos();
                cmb_categoria.DataSource = dt_cat_negos;
                cmb_categoria.ValueMember = "id_cat";
                cmb_categoria.DisplayMember = "nombre_cat";
            }

        }

        // ComboBox, para subcategorias
        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
