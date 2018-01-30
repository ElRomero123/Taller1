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

            if (AgregarCliente(cliente))
            {
                EtiquetaEstado.Text = "El cliente ha sido agregado exitosamente. ";
            }

            else
            {
                EtiquetaEstado.Text = "El cliente NO se pudo agregar. ";
            }        
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {

        }

        private bool AgregarCliente(E.Persona cliente)
        {
            bool var = false;
            C.Persona controladoraPersona = new C.Persona();
            var = controladoraPersona.AgregarCliente(cliente);
            return var;
        }
    }
}
