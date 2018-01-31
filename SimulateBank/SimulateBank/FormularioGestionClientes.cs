/* 
Documentación código

eCliente (entidades): entidad persona simplificada instanciada para un cliente.
cCliente (broker):    controladora persona instanciada para un cliente.
*/

using System;
using System.Windows.Forms;
using C = Controladora;
using E = Entidades;

namespace SimulateBank
{
    public partial class FormularioGestionClientes : Form
    {
        public FormularioGestionClientes()
        {
            InitializeComponent();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            E.Persona eCliente = new E.Persona
            {
                ID         = long.Parse(CampoID.Text),
                Password   = CampoPassword.Text,
                Nombre     = CampoNombre.Text,
                Apellido   = CampoApellido.Text,
                NDocumento = long.Parse(CampoDocumento.Text),
                Direccion  = CampoDireccion.Text,
                Telefono   = CampoTelefono.Text,
                Email      = CampoEmail.Text
            };

            if(CampoPassword.Text.GetHashCode() == CampoPasswordAgain.Text.GetHashCode())
            {
                if (AgregarCliente(eCliente))
                {
                    EtiquetaEstado.Text = "El cliente ha sido agregado. ";
                }

                else
                {
                    EtiquetaEstado.Text = "No se pudo agregar el cliente. ";
                }
            }

            else
            {
                EtiquetaEstado.Text = "Las contraseñas no coinciden. ";
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            long id = long.Parse(CampoID.Text);

            E.Persona eCliente = BuscarCliente(id);

            CampoPassword.Text      = eCliente.Password;
            CampoPasswordAgain.Text = CampoPassword.Text;
            CampoNombre.Text        = eCliente.Nombre;
            CampoApellido.Text      = eCliente.Apellido;
            CampoDocumento.Text     = eCliente.NDocumento.ToString();
            CampoDireccion.Text     = eCliente.Direccion;
            CampoTelefono.Text      = eCliente.Telefono;
            CampoEmail.Text         = eCliente.Email;
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            bool result;
            long id     = long.Parse(CampoID.Text);

            E.Persona eCliente = new E.Persona
            {
                Nombre     = CampoNombre.Text,
                Apellido   = CampoApellido.Text,
                NDocumento = long.Parse(CampoDocumento.Text),
                Direccion  = CampoDireccion.Text,
                Telefono   = CampoTelefono.Text,
                Email      = CampoEmail.Text
            };

            C.Persona cCliente = new C.Persona();
            result = cCliente.ActualizarCliente(id, eCliente);

            if(result)
            {
                EtiquetaEstado.Text = "El cliente ha sido actualizado. ";
            }

            else
            {
                EtiquetaEstado.Text = "No se pudo actualizar el cliente. ";
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            bool result;
            long id = long.Parse(CampoID.Text);

            C.Persona cCliente = new C.Persona();
            result = cCliente.EliminarCliente(id);

            if(result)
            {
                EtiquetaEstado.Text = "El cliente ha sido eliminado.";
            }

            else
            {
                EtiquetaEstado.Text = "No se pudo eliminar el cliente.";
            }
        }

        private bool AgregarCliente(E.Persona cliente)
        {
            bool var = false;
            C.Persona controladoraPersona = new C.Persona();
            var = controladoraPersona.AgregarCliente(cliente);
            return var;
        }

        private E.Persona BuscarCliente(long id)
        {
            C.Persona controladoraPersona = new C.Persona();
            E.Persona cliente = controladoraPersona.ObtenerCliente(id);
            return cliente;
        }
    }
}
