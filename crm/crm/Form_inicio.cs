﻿using System;
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
            tile.BackgroundImage = Image.FromFile("azulf.jpg");
            tile.BackgroundImageLayout = ImageLayout.Stretch;

            item_negocios.BackgroundImage = Image.FromFile("negocio.png");

        }
    }
}
