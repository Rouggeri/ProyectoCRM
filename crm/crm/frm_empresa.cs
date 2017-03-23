﻿using System;
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
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
        }
        string id_form = "108";
        private void frm_empresa_Load(object sender, EventArgs e)
        {

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

                cbo_pais.Properties.DataSource = OpBD.SeleccionarPaises();
                cbo_pais.Properties.ValueMember = "id_pais";
                cbo_pais.Properties.DisplayMember = "nombre";
                cbo_pais.Properties.PopulateColumns();
                cbo_pais.Properties.Columns[0].Visible = false;
            }
            catch(Exception exep) { MessageBox.Show(exep.Message); }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           // string nombre = txt_nombre.Text.Trim();
           // string telefono1 = txt_telefono1.Text.Trim();
           // string telefono2 = txt_telefono2.Text.Trim();
           // string email = txt_email.Text.Trim();
           // string direccion = txt_direccion.Text.Trim();
           // int pais = Convert.ToInt32(cbo_pais.EditValue);

           // OpBD o = new OpBD();
           //int res = o.InsertarEmpresa(nombre,direccion,email,telefono1,telefono2,pais);
           // if (res == 1)
           // {
           //     MessageBox.Show("Empresa registrada");
           // }
           // else { MessageBox.Show("No se registro la empresa"); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text.Trim();
            string telefono1 = txt_telefono1.Text.Trim();
            string telefono2 = txt_telefono2.Text.Trim();
            string email = txt_email.Text.Trim();
            string direccion = txt_direccion.Text.Trim();
            int pais = Convert.ToInt32(cbo_pais.EditValue);

            OpBD o = new OpBD();
            int res = o.InsertarEmpresa(nombre, direccion, email, telefono1, telefono2, pais);
            if (res == 1)
            {
                MessageBox.Show("Empresa registrada");
            }
            else { MessageBox.Show("No se registro la empresa"); }
        }
    }
}
