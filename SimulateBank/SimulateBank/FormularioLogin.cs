using System;
using System.Windows.Forms;
using C = Controladora;
using E = Entidades;

namespace SimulateBank
{
    public partial class FormularioLogin : Form
    {
        public FormularioLogin()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            string id              = CampoID.Text;
            string passwordUsuario = CampoPassword.Text;

            E.Persona entidadPersona = ObtenerCliente(long.Parse(id));

            string nombre     = entidadPersona.Nombre + ' ' + entidadPersona.Apellido;
            string passwordBD = entidadPersona.Password;      
            string email      = entidadPersona.Email;
            bool   rol        = entidadPersona.Rol;

            if (passwordUsuario.GetHashCode() == passwordBD.GetHashCode())
            {
                if (rol)
                {
                    FormularioMenuAdministrador menuAdministrador = new FormularioMenuAdministrador();
                    menuAdministrador.Show();

                    menuAdministrador.EtiquetaNombre.Text = nombre;
                    menuAdministrador.EtiquetaID.Text = id;
                    menuAdministrador.EtiquetaEmail.Text = email;

                    SetVisibleCore(false);
                }

                else
                {
                    FormularioMenuCliente menuCliente = new FormularioMenuCliente();
                    menuCliente.Show();

                    menuCliente.EtiquetaNombre.Text = nombre;
                    menuCliente.EtiquetaID.Text     = id;          
                    menuCliente.EtiquetaEmail.Text  = email;

                    SetVisibleCore(false);
                }
            }

            else
            {
                EtiquetaEstado.Text = "Datos incorrectos. No se puede iniciar sesión. ";
            }
        }

        private E.Persona ObtenerCliente(long Id)
        {
            C.Persona controladoraPersona  = new C.Persona();
            E.Persona entidadPersona2      = controladoraPersona.ObtenerCliente(Id);

            return entidadPersona2;
        }
    }
}
