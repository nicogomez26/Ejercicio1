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

        public override string ToString()
        {
            return IdProfesion.ToString();
        }
    }
}
