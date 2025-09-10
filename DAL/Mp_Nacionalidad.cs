using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Nacionalidad
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@nroNacionalidad", nacionalidad.IdNacionalidad);
            parametro[1] = new SqlParameter("@nombre", nacionalidad.Nombre_nacionalidad);
            parametro[2] = new SqlParameter("@cantidadPer", nacionalidad.CantPersonas);
            parametro[3] = new SqlParameter("@promEdad", nacionalidad.PromEdad);
            fa = acc.Escribir("AgregarNacionalidad", parametro);

            return fa;
        }

        public int Editar(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[4];
            parametro[0] = new SqlParameter("@nroNacionalidad", nacionalidad.IdNacionalidad);
            parametro[1] = new SqlParameter("@nombre", nacionalidad.Nombre_nacionalidad);
            parametro[2] = new SqlParameter("@cantidadPer", nacionalidad.CantPersonas);
            parametro[3] = new SqlParameter("@promEdad", nacionalidad.PromEdad);
            fa = acc.Escribir("EditarNacionalidad", parametro);

            return fa;
        }

        public int Eliminar(BE.Nacionalidad nacionalidad)
        {
            int fa = 0;
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@nroNacionalidad", nacionalidad.IdNacionalidad);
            fa = acc.Escribir("EliminarNacionalidad", parametro);

            return fa;
        }

        public List<BE.Nacionalidad> Listar()
        {
            List<BE.Nacionalidad> nacionalidades = new List<BE.Nacionalidad>();
            DataTable tabla = acc.Leer("ListarNacionalidad", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Nacionalidad nacionalidad = new BE.Nacionalidad();
                nacionalidad.IdNacionalidad = int.Parse(dr["IdNacionalidad"].ToString());
                nacionalidad.Nombre_nacionalidad = dr["nombre_Nacionalidad"].ToString();
                nacionalidad.CantPersonas = int.Parse(dr["cant_Personas"].ToString());
                nacionalidad.PromEdad = double.Parse(dr["prom_Edad"].ToString());

                nacionalidades.Add(nacionalidad);

            }
            return nacionalidades;
        }
    }
}
