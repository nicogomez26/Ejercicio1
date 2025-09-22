using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
	public class Persona
	{
		private int nroPersona;

		public int NroPersona
		{
			get { return nroPersona; }
			set { nroPersona = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		private string sexo;

		public string Sexo
		{
			get { return sexo; }
			set { sexo = value; }
		}

		private BE.Nacionalidad nacionalidad;

		public BE.Nacionalidad Nacionalidad
		{
			get { return nacionalidad; }
			set { nacionalidad = value; }
		}

		private BE.Profesion profesion;

		public BE.Profesion Profesion
		{
			get { return profesion; }
			set { profesion = value; }
		}

	}
}
