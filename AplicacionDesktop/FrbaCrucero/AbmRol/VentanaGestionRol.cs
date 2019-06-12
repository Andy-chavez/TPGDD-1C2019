﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class VentanaGestionRol : Form
    {
        public VentanaMenu ventanaMenu { get; set; }

        public VentanaGestionRol(VentanaMenu ventanaMenu)
        {
            InitializeComponent();
            this.ventanaMenu = ventanaMenu;
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            new VentanaDeAltaRol().Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            VentanaModificarRol ventanaDeBaja = new VentanaModificarRol();
            ventanaDeBaja.Show();
            ventanaDeBaja.esconderBotonEliminar();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            
        }

        private void VentanaGestionRol_Load(object sender, EventArgs e)
        {

        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            new VentanaModificarRol().Show();
        }
    }
}