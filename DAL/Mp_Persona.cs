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
        Acceso acc=new Acceso();

        public int Agregar(BE.Persona persona)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@nroPersona", persona.NroPersona);
            parametro[1]=new SqlParameter("@nombre", persona.Nombre);
            parametro[2]=new SqlParameter("@apellido", persona.Apellido);
            parametro[3] = new SqlParameter("@edad", persona.Edad);
            parametro[4] = new SqlParameter("@sexo", persona.Sexo);
            parametro[5] = new SqlParameter("@idNacionalidad", persona.IdNacionalidad);
            parametro[6] = new SqlParameter("@idProfesion", persona.IdProfesion);
            fa = acc.Escribir("AgregarPersona",parametro);
            
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
            parametro[5] = new SqlParameter("@idNacionalidad", persona.IdNacionalidad);
            parametro[6] = new SqlParameter("@idProfesion", persona.IdProfesion);
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
            DataTable tabla = acc.Leer("ListarPersona",null);
            foreach (DataRow dr in tabla.Rows) 
            {
                BE.Persona persona =new BE.Persona();
                persona.NroPersona = int.Parse(dr["NroPersona"].ToString());
                persona.Nombre = dr["Nombre"].ToString();
                persona.Apellido= dr["Apellido"].ToString();
                persona.Edad = int.Parse(dr["Edad"].ToString());
                persona.Sexo = dr["Sexo"].ToString();
                persona.IdNacionalidad = int.Parse(dr["IdNacionalidad"].ToString());
                persona.IdProfesion = int.Parse(dr["IdProfesion"].ToString());

                personas.Add(persona);
            
            }
            return personas;
        }

    }
}
