﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulateBank
{
    public partial class FormularioMenuAdministrador : Form
    {
        public FormularioMenuAdministrador()
        {
            InitializeComponent();
        }

        private void BotonGestionClientes_Click(object sender, EventArgs e)
        {
            FormularioGestionClientes GestionClientes = new FormularioGestionClientes();
            GestionClientes.Show();
        }

        private void BotonDatosPersonales_Click(object sender, EventArgs e)
        {
            FormularioDatosPersonales DatosPersonales = new FormularioDatosPersonales();
            DatosPersonales.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            FormularioLogin Login = new FormularioLogin();
            Login.Show();
            SetVisibleCore(false);
        }
    }
}
