using System;
using System.Windows.Forms;
using C = Controladora;

namespace SimulateBank
{
    public partial class FormularioConsulta : Form
    {
        public FormularioConsulta()
        {
            InitializeComponent();
        }

        private void BotonCosultar_Click(object sender, EventArgs e)
        {
            long cuenta = long.Parse(ListaCuentas.Text);
            C.Cuenta cCuenta = new C.Cuenta();
            long saldo = cCuenta.ObtenerCuenta(cuenta).Saldo;

            EtiquetaSaldo.Text = saldo.ToString();
        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void CargarCuentas()
        {
            long idCliente = long.Parse(EtiquetaID.Text);

            C.Cuenta cCuenta = new C.Cuenta();
            long[] cuentas = cCuenta.ObtenerCuentas(idCliente);

            if (cuentas != null)
            {
                int size = cuentas.Length;

                for (int i = 0; i < size; i++)
                {
                    ListaCuentas.Items.Add(cuentas[i]);
                }
            }
        }
    }
}
