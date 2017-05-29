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
    public partial class frm_compra : Form
    {
        int idprod;
        int idmarc;
        public frm_compra()
        {
            InitializeComponent();
        }

        private void llenarprov()
        {
            negocio cnegocio = new negocio();
            cbo_proveedor.ValueMember = "id_proveedor";
            cbo_proveedor.DisplayMember = "nombre_proveedor";
            cbo_proveedor.DataSource = cnegocio.consultacat();
        }

        public entidades.Producto clspro { get; set; }
        private void btn_bproducto_Click(object sender, EventArgs e)
        {
            try
            {


                frmbuscproducto buscl = new frmbuscproducto();
                buscl.ShowDialog();


                if (buscl.busq != null)
                {
                    clspro = buscl.busq;

                    txt_prod.Text = Convert.ToString(buscl.busq.nombre);
                    idprod = Convert.ToInt16(buscl.busq.codigo);
                    idmarc = Convert.ToInt16(buscl.busq.marca);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frm_compra_Load(object sender, EventArgs e)
        {

        }
    }
}
