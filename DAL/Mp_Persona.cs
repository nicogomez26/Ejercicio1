using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Persona
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Persona persona)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@nroPersona", persona.NroPersona);
            parametro[1] = new SqlParameter("@nombre", persona.Nombre);
            parametro[2] = new SqlParameter("@apellido", persona.Apellido);
            parametro[3] = new SqlParameter("@edad", persona.Edad);
            parametro[4] = new SqlParameter("@sexo", persona.Sexo);
            parametro[5] = new SqlParameter("@idNacionalidad", persona.Nacionalidad.IdNacionalidad);
            parametro[6] = new SqlParameter("@idProfesion", persona.Profesion.IdProfesion);
            fa = acc.Escribir("AgregarPersona", parametro);

            return fa;
        }

        public int Editar(BE.Persona persona)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@nroPersona", persona.NroPersona);
            parametro[1] = new SqlParameter("@nombre", persona.Nombre);
            parametro[2] = new SqlParameter("@apellido", persona.Apellido);
            parametro[3] = new SqlParameter("@edad", persona.Edad);
            parametro[4] = new SqlParameter("@sexo", persona.Sexo);
            parametro[5] = new SqlParameter("@idNacionalidad", persona.Nacionalidad.Nombre_nacionalidad);
            parametro[6] = new SqlParameter("@idProfesion", persona.Profesion.Nombre_profesion);
            fa = acc.Escribir("EditarPersona", parametro);

            return fa;
        }

        public int Eliminar(BE.Persona persona)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nroPersona", persona.NroPersona);
            fa = acc.Escribir("EliminarPersona", parametro);

            return fa;
        }

        public List<BE.Persona> Listar()
        {
            List<BE.Persona> personas = new List<BE.Persona>();
            DataTable tabla = acc.Leer("ListarPersona", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Persona persona = new BE.Persona();
                persona.NroPersona = int.Parse(dr["NroPersona"].ToString());
                persona.Nombre = dr["Nombre"].ToString();
                persona.Apellido = dr["Apellido"].ToString();
                persona.Edad = int.Parse(dr["Edad"].ToString());
                persona.Sexo = dr["Sexo"].ToString();
                persona.Nacionalidad = new BE.Nacionalidad();
                persona.Nacionalidad.IdNacionalidad = int.Parse(dr["idNacionalidad"].ToString());
                persona.Profesion = new BE.Profesion();
                persona.Profesion.IdProfesion = int.Parse(dr["idProfesion"].ToString());

                personas.Add(persona);

            }
            return personas;
        }

        public int Contar()
        {
            int totalPersonas = 0;

            DataTable tabla = acc.Leer("PersonasRegistradas", null);

            if (tabla.Rows.Count > 0)
            {
                totalPersonas = Convert.ToInt32(tabla.Rows[0][0]);
                
            }

            return totalPersonas;


        }

        public double CalcularProm()
        {
            double promedio = 0.0;

            DataTable tabla = acc.Leer("CalcularPromRegistradas", null);

            if (tabla.Rows.Count > 0 && tabla.Rows[0][0] != DBNull.Value)
            {
                promedio = Convert.ToDouble(tabla.Rows[0][0]);

            }

            return promedio;

        }

        public int CalcularMin()
        {
            int Min = 0;

            DataTable tabla = acc.Leer("CalcularEdadMinima", null);

            if (tabla.Rows.Count > 0 && tabla.Rows[0][0] != DBNull.Value)
            {
                Min = Convert.ToInt32(tabla.Rows[0][0]);

            }

            return Min;
        }

        public int CalcularMAX()
        {
            int MAX = 0;

            DataTable tabla = acc.Leer("CalcularEdadMaxima", null);

            if (tabla.Rows.Count > 0 && tabla.Rows[0][0] != DBNull.Value)
            {
                MAX = Convert.ToInt32(tabla.Rows[0][0]);

            }

            return MAX;
        }

    }
}
