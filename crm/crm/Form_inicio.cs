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
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            //FONDO
            tile.BackgroundImage = Image.FromFile("azulf.jpg");
            tile.BackgroundImageLayout = ImageLayout.Stretch;

            //ITEM NEGOCIOS
            
            item_negocios.BackgroundImage = Image.FromFile("negocios2.png");
            
            //item_negocios.AppearanceItem.Hovered.BackColor = ColorTranslator.FromHtml("#EA2E49");
            //item_negocios.AppearanceItem.Hovered.BackColor2 = ColorTranslator.FromHtml("#EA2E49");
            //item_negocios.AppearanceItem.Hovered.BorderColor = ColorTranslator.FromHtml("#EA2E49");
            //ITEM CONTACTOS
            item_contactos.BackgroundImage = Image.FromFile("contactos2.png");
            //ITEM CALENDARIO
            item_calendario.BackgroundImage = Image.FromFile("calendario2.png");
        }


    }
}
