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
    public partial class FormTareasNegocio : Form
    {
        public FormTareasNegocio()
        {
            InitializeComponent();
        }
        public string titulo;
        private void FormTareasNegocio_Load(object sender, EventArgs e)
        {
            this.Text = "Tareas de "+titulo;
            //dateNavigator1.EditValue;
        }
    }
}
