using System;

namespace Entidades
{
    [Serializable]
    public class Cuenta
    {
        public long Numero { get; set; }
        public long Saldo { get; set; }
        public long IDCliente { get; set; }
    }
}
