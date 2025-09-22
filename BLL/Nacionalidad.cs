using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Nacionalidad
    {
        Mp_Nacionalidad mapper = new Mp_Nacionalidad();


        public int AgregarNacionalidad(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            fa = mapper.Agregar(nacionalidad);

            return fa;
        }

        public int EditarNacionalidad(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            fa = mapper.Editar(nacionalidad);

            return fa;
        }

        public int EliminarNacionalidad(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            fa = mapper.Eliminar(nacionalidad);

            return fa;
        }

        public List<BE.Nacionalidad> ListarNacionalidad()
        {
            List<BE.Nacionalidad> nacionalidades = mapper.Listar();
            return nacionalidades;
        }

        public void calcularPromyCant(BE.Nacionalidad nacionalidad)
        {
            nacionalidad.CantPersonas = nacionalidad.PersonasNac.Count();

            double total = 0.0;
            foreach (var p in nacionalidad.PersonasNac)
            {
                total += p.Edad;
            }

            nacionalidad.PromEdad = (double)total / nacionalidad.CantPersonas;
        }
    }
}
