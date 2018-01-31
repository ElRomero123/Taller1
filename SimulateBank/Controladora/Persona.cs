using System.Linq;
using E = Entidades;
using B = Broker;

namespace Controladora
{
    public class Persona
    {
        private B.DBSimulateBankEntities modelo = new B.DBSimulateBankEntities();
        public bool AgregarCliente(E.Persona personaCliente)
        {
            bool resultado = true;

            try
            {

                #pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                AutoMapper.Mapper.CreateMap<E.Persona, B.Persona>();
                #pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                B.Persona objetoPersona = AutoMapper.Mapper.Map<B.Persona>(personaCliente);

                modelo.Personas.Add(objetoPersona);

                modelo.SaveChanges();

                resultado = true;
            }


            catch(System.Exception ex)
            {
                throw ex;
            }

            return resultado;
        }

        public E.Persona ObtenerCliente(long id)
        {
            E.Persona persona = new E.Persona();

            var listaRegistros = from Persona in modelo.Personas
                                 where (Persona.ID == id)
                                 select new { Persona.Password, Persona.Nombre, Persona.Apellido, Persona.NDocumento, Persona.Direccion, Persona.Telefono, Persona.Email, Persona.Rol };

            try
            {
                var registro = listaRegistros.ToArray()[0];

                if (registro != null)
                {
                    persona.Password   = registro.Password;
                    persona.Nombre     = registro.Nombre;
                    persona.Apellido   = registro.Apellido;
                    persona.NDocumento = registro.NDocumento;
                    persona.Direccion  = registro.Direccion;
                    persona.Telefono   = registro.Telefono;
                    persona.Email      = registro.Email;
                    persona.Rol        = registro.Rol;
                }
            }

            catch
            {
                
            }
            
            return persona;
        }

        public bool EliminarCliente(long id)
        { 
            B.Persona personaCliente = modelo.Personas.FirstOrDefault(x => x.ID == id);
            modelo.Personas.Remove(personaCliente);
            modelo.SaveChanges();

            return true;
        }
    }
}
