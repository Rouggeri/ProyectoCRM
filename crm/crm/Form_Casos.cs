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
    public partial class Form_Casos : Form
    {
        public Form_Casos()
        {
            InitializeComponent();
        }

        private void btn_nuevocaso_Click(object sender, EventArgs e)
        {
            frm_NuevoCaso f = new frm_NuevoCaso();
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
