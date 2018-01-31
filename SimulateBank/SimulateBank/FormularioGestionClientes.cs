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
            E.Persona cliente = new E.Persona
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
                if (AgregarCliente(cliente))
                {
                    EtiquetaEstado.Text = "El cliente ha sido agregado exitosamente. ";
                }

                else
                {
                    EtiquetaEstado.Text = "El cliente NO se pudo agregar. ";
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

            E.Persona cliente       = BuscarCliente(id);

            CampoPassword.Text = cliente.Password;
            CampoPasswordAgain.Text = CampoPassword.Text;
            CampoNombre.Text = cliente.Nombre;
            CampoApellido.Text = cliente.Apellido;
            CampoDocumento.Text = cliente.NDocumento.ToString();
            CampoDireccion.Text = cliente.Direccion;
            CampoTelefono.Text = cliente.Telefono;
            CampoEmail.Text = cliente.Email;
       
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            bool resultado;
            long id = long.Parse(CampoID.Text);

            C.Persona controladoraPersona = new C.Persona();
            resultado = controladoraPersona.EliminarCliente(id);

            if(resultado)
            {
                EtiquetaEstado.Text = "Cliente eliminado con éxito.";
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
