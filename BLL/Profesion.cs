using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Profesion
    {
        Mp_Profesion mapper = new Mp_Profesion();


        public int AgregarProfesion(BE.Profesion profesion)
        {
            int fa = 0;
            fa = mapper.Agregar(profesion);

            return fa;
        }

        public int EditarProfesion(BE.Profesion profesion)
        {
            int fa = 0;
            fa = mapper.Editar(profesion);

            return fa;
        }

        public int EliminarProfesion(BE.Profesion profesion)
        {
            int fa = 0;
            fa = mapper.Eliminar(profesion);

            return fa;
        }

        public List<BE.Profesion> ListarProfesion()
        {
            List<BE.Profesion> profesiones = mapper.Listar();
            return profesiones;
        }
    }
}
