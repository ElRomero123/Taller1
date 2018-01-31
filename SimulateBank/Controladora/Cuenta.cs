/* 

Documentación código

*/
using System.Linq;
using E = Entidades;
using B = Broker;

namespace Controladora
{
    public class Cuenta
    {
        private B.DBSimulateBankEntities modelo = new B.DBSimulateBankEntities();
        public bool AgregarCuenta(E.Cuenta eCuenta)
        {
            bool result = true;

            try
            {
                #pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                AutoMapper.Mapper.CreateMap<E.Cuenta, B.Cuenta>();
                #pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                B.Cuenta bCuenta = AutoMapper.Mapper.Map<B.Cuenta>(eCuenta);

                modelo.Cuentas.Add(bCuenta);
                modelo.SaveChanges();

                result = true;
            }

            catch
            {
  
            }

            return result;
        }

        public E.Cuenta ObtenerCuenta(long numero)
        {
            E.Cuenta eCuenta = new E.Cuenta();

            var listaRegistros = from P in modelo.Cuentas
                                 where (P.Numero == numero)
                                 select new { P.Saldo };

            try
            {
                var registro = listaRegistros.ToArray()[0];

                if (registro != null)
                {
                    eCuenta.Saldo  = registro.Saldo;
     
                }
            }

            catch
            {
                
            }
            
            return eCuenta;
        }

        public bool ActualizarCuenta(long numero, E.Cuenta eCuenta)
        {
            bool result = false;
            try
            {
                B.Cuenta bCuenta = modelo.Cuentas.FirstOrDefault(x => x.Numero == numero);

                bCuenta.Saldo = eCuenta.Saldo;

                modelo.SaveChanges();
                result = true;
            }

            catch
            {

            }
            
            return result;
        }

        public bool EliminarCuenta(long numero)
        {
            bool result = false;
            try
            {
                B.Cuenta bCuenta = modelo.Cuentas.FirstOrDefault(x => x.Numero == numero);
                modelo.Cuentas.Remove(bCuenta);
                modelo.SaveChanges();

                result = true;
            }

            catch
            {

            }
            
            return result;
        }

        public long[] ObtenerCuentas(long idCliente)
        {
            int size = 0;
            long[] numeroCuentas = null;

            var listaRegistros = from P in modelo.Cuentas
                                 where (P.IDCliente == idCliente)
                                 select new { P.Numero };

            try
            {
                var arrayRegistros = listaRegistros.ToArray();
                size = arrayRegistros.Length;

                if (size > 0)
                {
                    numeroCuentas = new long[size];
                    for (int i = 0; i < size; i++)
                    {
                        numeroCuentas[i] = arrayRegistros[i].Numero;
                    }
                }
            }

            catch
            {

            }

            return numeroCuentas;
        }

        public bool ActualizarSaldo(long numero, long nuevoSaldo)
        {
            bool result = false;
            try
            {
                B.Cuenta bCuenta = modelo.Cuentas.FirstOrDefault(x => x.Numero == numero);

                bCuenta.Saldo = nuevoSaldo;

                modelo.SaveChanges();
                result = true;
            }

            catch
            {

            }

            return result;
        }
    }
}
