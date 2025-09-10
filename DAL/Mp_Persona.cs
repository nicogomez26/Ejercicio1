using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Alumno
    {
        Acceso acc=new Acceso();

        public int Agregar(BE.Alumno alum)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[3];
            parametro[0] = new SqlParameter("@legajo", alum.Legajo);
            parametro[1]=new SqlParameter("@nombre",alum.Nombre);
            parametro[2] = new SqlParameter("@edad", alum.Edad);
            fa = acc.Escribir("AgregarAlumno",parametro);
            
            return fa;
        }

        public int Editar(BE.Alumno alum)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[3];
            parametro[0] = new SqlParameter("@legajo", alum.Legajo);
            parametro[1] = new SqlParameter("@nombre", alum.Nombre);
            parametro[2] = new SqlParameter("@edad", alum.Edad);
            fa = acc.Escribir("EditarAlumno", parametro);

            return fa;
        }

        public int Eliminar(BE.Alumno alum)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@legajo", alum.Legajo);
            fa = acc.Escribir("EliminarAlumno", parametro);

            return fa;
        }

        public List<BE.Alumno> Listar()
        {
            List<BE.Alumno> ls = new List<BE.Alumno>();
            DataTable tabla = acc.Leer("ListarAlumno",null);
            foreach (DataRow dr in tabla.Rows) 
            {
                BE.Alumno alum=new BE.Alumno();
                alum.Legajo = int.Parse(dr["Legajo"].ToString());
                alum.Nombre = dr["Nombre"].ToString();
                alum.Edad = int.Parse(dr["Edad"].ToString());
                ls.Add(alum);
            
            }
            return ls;
        }


    }
}
