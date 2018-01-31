using System;
using System.Windows.Forms;
using C = Controladora;

namespace SimulateBank
{
    public partial class FormularioTransaccion : Form
    {
        public FormularioTransaccion()
        {
            InitializeComponent();
        }

        private void BotonTransferir_Click(object sender, EventArgs e)
        {
            bool result1, result2, result3;

            long cuentaOrigen  = long.Parse(ListaCuentaOrigen.Text);
            long cuentaDestino = long.Parse(CampoCuentaDestino.Text);
            long cantidad      = long.Parse(CampoCantidad.Text);
            
            result1 = Validar(cuentaOrigen, cantidad);
            result2 = ActualizarOrigen(cuentaOrigen, cantidad);
            result3 = ActualizarDestino(cuentaDestino, cantidad);

            if(result1)
            {
                if(result2 && result3)
                {
                    EtiquetaEstado.Text = "Transferencia exitosa. ";
                }

                else
                {
                    EtiquetaEstado.Text = "No se pudo hacer la transferencia. ";
                }
            }

            else
            {
                EtiquetaEstado.Text = "Saldo: " + cantidad + " insuficiente para la transferencia. ";
            }
        }

        private void CargarCuentas()
        {
            long idCliente = long.Parse(EtiquetaID.Text);

            C.Cuenta cCuenta = new C.Cuenta();
            long[] cuentas = cCuenta.ObtenerCuentas(idCliente);

            if(cuentas != null)
            {
                int size = cuentas.Length;

                for (int i = 0; i < size; i++)
                {
                    ListaCuentaOrigen.Items.Add(cuentas[i]);
                }
            }    
        }

        private bool Validar(long cuentaOrigen, long cantidad)
        {
            C.Cuenta cCuenta = new C.Cuenta();
            long saldo = cCuenta.ObtenerCuenta(cuentaOrigen).Saldo;

            return cantidad <= saldo;
        }

        private bool ActualizarOrigen(long cuentaOrigen, long cantidad)
        {
            bool result;
            long newSaldo; 
            C.Cuenta cCuenta = new C.Cuenta();

            long oldSaldo = cCuenta.ObtenerCuenta(cuentaOrigen).Saldo;
            newSaldo = oldSaldo - cantidad;

            result = cCuenta.ActualizarSaldo(cuentaOrigen, newSaldo);

            return result;
        }

        private bool ActualizarDestino(long cuentaDestino, long cantidad)
        {
            bool result;
            long newSaldo;
            C.Cuenta cCuenta = new C.Cuenta();
            long oldSaldo = cCuenta.ObtenerCuenta(cuentaDestino).Saldo;

            newSaldo = oldSaldo + cantidad;

            result = cCuenta.ActualizarSaldo(cuentaDestino, newSaldo);

            return result;
        }

        private void BotonCargar_Click(object sender, EventArgs e)
        {
            CargarCuentas();
        }
    }
}
