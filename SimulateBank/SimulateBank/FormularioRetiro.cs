using System;
using System.Windows.Forms;
using C = Controladora;

namespace SimulateBank
{
    public partial class FormularioRetiro : Form
    {
        public FormularioRetiro()
        {
            InitializeComponent();
        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void BotonRetirar_Click(object sender, EventArgs e)
        {
            bool result1, result2;

            long cuenta = long.Parse(ListaCuentas.Text);
            long cantidad = long.Parse(CampoCantidad.Text);

            result1 = Validar(cuenta, cantidad);
            result2 = Actualizar(cuenta, cantidad);

            if (result1)
            {
                if (result2)
                {
                    EtiquetaEstado.Text = "Retiro exitoso. ";
                }

                else
                {
                    EtiquetaEstado.Text = "No se pudo hacer el retiro. ";
                }
            }

            else
            {
                EtiquetaEstado.Text = "Saldo: " + cantidad + " insuficiente para el retiro. ";
            }
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

        private bool Validar(long cuenta, long cantidad)
        {
            C.Cuenta cCuenta = new C.Cuenta();
            long saldo = cCuenta.ObtenerCuenta(cuenta).Saldo;

            return cantidad <= saldo;
        }

        private bool Actualizar(long cuenta, long cantidad)
        {
            bool result;
            long newSaldo;
            C.Cuenta cCuenta = new C.Cuenta();

            long oldSaldo = cCuenta.ObtenerCuenta(cuenta).Saldo;
            newSaldo = oldSaldo - cantidad;

            result = cCuenta.ActualizarSaldo(cuenta, newSaldo);

            return result;
        }
    }
}
