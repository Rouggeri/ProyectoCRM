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
    public partial class frm_empresa : Form
    {
        public frm_empresa()
        {
            InitializeComponent();
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            cbo_pais.Properties.DataSource = OpBD.SeleccionarPaises();
            cbo_pais.Properties.ValueMember = "id_pais";
            cbo_pais.Properties.DisplayMember = "nombre";
            cbo_pais.Properties.PopulateColumns();
            cbo_pais.Properties.Columns[0].Visible = false;
            

        }
    }
}
