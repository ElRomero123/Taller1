/* 

Documentación código

eCliente (entidades): entidad persona simplificada instanciada para un cliente.
bCliente (broker):    entidad persona instanciada para un cliente.
cCliente (broker):    controladora persona instanciada para un cliente.

*/

using System.Linq;
using E = Entidades;
using B = Broker;

namespace Controladora
{
    public class Persona
    {
        private B.DBSimulateBankEntities modelo = new B.DBSimulateBankEntities();
        public bool AgregarCliente(E.Persona eCliente)
        {
            bool result = true;

            try
            {
                #pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                AutoMapper.Mapper.CreateMap<E.Persona, B.Persona>();
                #pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                B.Persona bCliente = AutoMapper.Mapper.Map<B.Persona>(eCliente);

                modelo.Personas.Add(bCliente);
                modelo.SaveChanges();

                result = true;
            }

            catch
            {
  
            }

            return result;
        }

        public E.Persona ObtenerCliente(long id)
        {
            E.Persona eCliente = new E.Persona();

            var listaRegistros = from P in modelo.Personas
                                 where (P.ID == id)
                                 select new { P.Password, P.Nombre, P.Apellido, P.NDocumento, P.Direccion, P.Telefono, P.Email, P.Rol };

            try
            {
                var registro = listaRegistros.ToArray()[0];

                if (registro != null)
                {
                    eCliente.Password   = registro.Password;
                    eCliente.Nombre     = registro.Nombre;
                    eCliente.Apellido   = registro.Apellido;
                    eCliente.NDocumento = registro.NDocumento;
                    eCliente.Direccion  = registro.Direccion;
                    eCliente.Telefono   = registro.Telefono;
                    eCliente.Email      = registro.Email;
                    eCliente.Rol        = registro.Rol;
                }
            }

            catch
            {
                
            }
            
            return eCliente;
        }

        public bool ActualizarCliente(long id, E.Persona eCliente)
        {
            bool result = false;
            try
            {
                B.Persona bCliente = modelo.Personas.FirstOrDefault(x => x.ID == id);

                bCliente.Nombre     = eCliente.Nombre;
                bCliente.Apellido   = eCliente.Apellido;
                bCliente.NDocumento = eCliente.NDocumento;
                bCliente.Direccion  = eCliente.Direccion;
                bCliente.Telefono   = eCliente.Telefono;
                bCliente.Email      = eCliente.Email;

                modelo.SaveChanges();
                result = true;
            }

            catch
            {

            }
            
            return result;
        }

        public bool EliminarCliente(long id)
        {
            bool result = false;
            try
            {
                B.Persona bCliente = modelo.Personas.FirstOrDefault(x => x.ID == id);
                modelo.Personas.Remove(bCliente);
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
