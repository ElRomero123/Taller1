using System;
using System.Windows.Forms;

namespace SimulateBank
{
    public partial class FormularioMenuCliente : Form
    {
        public FormularioMenuCliente()
        {
            InitializeComponent();
        }

        private void BotonTransaccion_Click(object sender, EventArgs e)
        {
            FormularioTransaccion Transaccion = new FormularioTransaccion();
            Transaccion.EtiquetaID.Text = EtiquetaID.Text;
            Transaccion.Show();  
        }

        private void BotonRetiro_Click(object sender, EventArgs e)
        {
            FormularioRetiro Retiro = new FormularioRetiro();
            Retiro.Show();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            FormularioConsulta Consulta = new FormularioConsulta();
            Consulta.EtiquetaID.Text = EtiquetaID.Text;
            Consulta.Show();
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
