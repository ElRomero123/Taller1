/* 

Documentación código

*/
using System;
using System.Windows.Forms;
using E = Entidades;
using C = Controladora;

namespace SimulateBank
{
    public partial class FormularioGestionFinanciera : Form
    {
        public FormularioGestionFinanciera()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            E.Cuenta eCuenta = new E.Cuenta
            {
                Numero    = long.Parse(CampoNumero.Text),
                Saldo     = long.Parse(CampoSaldo.Text),
                IDCliente = long.Parse(EtiquetaID.Text),
            };


            if (AgregarCuenta(eCuenta))
            {
                EtiquetaEstado.Text = "La cuenta ha sido agregada. ";
            }

            else
            {
                EtiquetaEstado.Text = "No se pudo agregar la cuenta. ";
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            long numero = long.Parse(CampoNumero.Text);
            E.Cuenta eCuenta = BuscarCuenta(numero);
            CampoSaldo.Text = eCuenta.Saldo.ToString();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            bool result;
            long numero = long.Parse(CampoNumero.Text);

            E.Cuenta eCuenta = new E.Cuenta
            {
                Saldo = long.Parse(CampoSaldo.Text)
            };

            C.Cuenta cCuenta = new C.Cuenta();
            result = cCuenta.ActualizarCuenta(numero, eCuenta);

            if (result)
            {
                EtiquetaEstado.Text = "La cuenta ha sido actualizada. ";
            }

            else
            {
                EtiquetaEstado.Text = "No se pudo actualizar la cuenta. ";
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            bool result;
            long numero = long.Parse(CampoNumero.Text);

            C.Cuenta cCuenta = new C.Cuenta();
            result = cCuenta.EliminarCuenta(numero);

            if (result)
            {
                EtiquetaEstado.Text = "La cuenta ha sido eliminada.";
            }

            else
            {
                EtiquetaEstado.Text = "No se pudo eliminar la cuenta.";
            }
        }

        private bool AgregarCuenta(E.Cuenta eCuenta)
        {
            bool result = false;
            C.Cuenta cCuenta = new C.Cuenta();
            result = cCuenta.AgregarCuenta(eCuenta);
            return result;
        }

        private E.Cuenta BuscarCuenta(long numero)
        {
            C.Cuenta cCuenta = new C.Cuenta();
            E.Cuenta eCuenta = cCuenta.ObtenerCuenta(numero);
            return eCuenta;
        }
    }
}
