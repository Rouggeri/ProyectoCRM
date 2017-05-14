﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoUOne
{
    public partial class InsertarProducto : Form
    {
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos nuevo = new CapaDatos();
                nuevo.InsertarProducto(txt_descripcion.Text, Convert.ToDouble(txt_precioUnidad.Text));
                MessageBox.Show("Se Inserto Correctamente");
                txt_descripcion.Text = "";
                txt_precioUnidad.Text = "";
            }
            catch {
                MessageBox.Show("Error de insercion");
            }
            
        }
    }
}
