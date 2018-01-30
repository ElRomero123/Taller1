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

        public E.Persona ObtenerCliente(long ID)
        {
            E.Persona persona = new E.Persona();

            var listaRegistros = from Persona in modelo.Personas
                                 where (Persona.ID == ID)
                                 select new { Persona.Nombre, Persona.Apellido, Persona.Password, Persona.Email, Persona.Rol };

            var registro = listaRegistros.ToArray()[0];

            persona.Nombre = registro.Nombre;
            persona.Apellido = registro.Apellido;
            persona.Password = registro.Password;
            persona.Email = registro.Email;
            persona.Rol = registro.Rol;

            return persona;
        }
    }
}
