using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        Mp_Persona mapper = new Mp_Persona();


        public int AgregarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Agregar(persona);

            return fa;
        }

        public int EditarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Editar(persona);

            return fa;
        }

        public int EliminarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Eliminar(persona);

            return fa;
        }

        public List<BE.Persona> ListarPersona()
        {
            List<BE.Persona> personas = mapper.Listar();
            return personas;
        }

        public int Contar()
        {
            int fa = 0;

            fa = mapper.Contar();

            return fa;
        }

    }
}
