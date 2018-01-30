using System;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        public long ID { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long NDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Rol { get; set; }
    }
}
