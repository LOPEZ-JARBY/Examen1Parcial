﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1Parcial
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formulario1button_Click(object sender, EventArgs e)
        {
            Form formulario = new Formulario1();
            formulario.Show();
        }

        private void Formulario2button_Click(object sender, EventArgs e)
        {
            Form formulario = new Formulario2();
            formulario.Show();
        }

        private void Formulario3button_Click(object sender, EventArgs e)
        {
            Form formulario = new Formulario3();
            formulario.Show();
        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
