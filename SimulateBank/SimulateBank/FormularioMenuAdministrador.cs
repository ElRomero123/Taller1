using System;
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
            
            /* Referencia a Datos Personales destruida.
            FormularioDatosPersonales DatosPersonales = new FormularioDatosPersonales();
            DatosPersonales.Show();
            */
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            FormularioLogin Login = new FormularioLogin();
            Login.Show();
            SetVisibleCore(false);
        }
    }
}
