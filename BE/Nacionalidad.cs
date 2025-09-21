using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nacionalidad
    {
		private int idnacionalidad;

		public int IdNacionalidad
		{
			get { return idnacionalidad; }
			set { idnacionalidad = value; }
		}

		private string nombre_nacionalidad;

		public string Nombre_nacionalidad
		{
			get { return nombre_nacionalidad; }
			set { nombre_nacionalidad = value; }
		}

		private int cantPersonas;

		public int CantPersonas
		{
			get { return cantPersonas; }
			set { cantPersonas = value; }
		}

		private double promEdad;

		public double PromEdad
		{
			get { return promEdad; }
			set { promEdad = value; }
		}

        public override string ToString()
        {
            return IdNacionalidad.ToString();
        }
	}
}
