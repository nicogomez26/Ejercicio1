using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Profesion
    {
		private int idProfesion;

		public int IdProfesion
		{
			get { return idProfesion; }
			set { idProfesion = value; }
		}

		private string nombre_profesion;

		public string Nombre_profesion
		{
			get { return nombre_profesion; }
			set { nombre_profesion = value; }
		}

		private List<BE.Persona> personasProf;

		public List<BE.Persona> PersonasProf
		{
			get { return personasProf; }
			set { personasProf = value; }
		}


		public override string ToString()
        {
            return IdProfesion.ToString();
        }
    }
}
