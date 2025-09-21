using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Profesion
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Profesion profesion)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@nroProfesion", profesion.IdProfesion);
            parametro[1] = new SqlParameter("@nombre", profesion.Nombre_profesion);
            fa = acc.Escribir("AgregarProfesion", parametro);

            return fa;
        }

        public int Editar(BE.Profesion profesion)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@nroProfesion", profesion.IdProfesion);
            parametro[1] = new SqlParameter("@nombre", profesion.Nombre_profesion);
            fa = acc.Escribir("EditarProfesion", parametro);

            return fa;
        }

        public int Eliminar(BE.Profesion profesion)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nroProfesion", profesion.IdProfesion);
            fa = acc.Escribir("EliminarProfesion", parametro);

            return fa;
        }

        public List<BE.Profesion> Listar()
        {
            List<BE.Profesion> profesiones = new List<BE.Profesion>();
            DataTable tabla = acc.Leer("ListarProfesion", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Profesion profesion = new BE.Profesion();
                profesion.IdProfesion = int.Parse(dr["idProfesion"].ToString());
                profesion.Nombre_profesion = dr["nombre_Profesion"].ToString();

                profesiones.Add(profesion);

            }
            return profesiones;
        }


    }
}
