using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Persona
    {
        Mp_Persona mapper = new Mp_Persona();


        public int AgregarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Agregar(persona);

            BE.Nacionalidad nacBe = persona.Nacionalidad;
            BLL.Nacionalidad nacBll = new BLL.Nacionalidad();

            if (nacBe != null)
            {
                nacBe.PersonasNac.Add(persona);
            }
            
            
            nacBll.calcularPromyCant(nacBe);

            nacBll.EditarNacionalidad(nacBe);

            MessageBox.Show(nacBe.CantPersonas.ToString());
            MessageBox.Show(nacBe.PromEdad.ToString());
            return fa;
        }



        public int EditarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Editar(persona);

            return fa;
        }

        public int EliminarPersona(BE.Persona persona)
        {
            int fa = 0;
            fa = mapper.Eliminar(persona);

            return fa;
        }

        public List<BE.Persona> ListarPersona()
        {
            List<BE.Persona> personas = mapper.Listar();
            return personas;
        }

        public int Contar()
        {
            int fa = 0;

            fa = mapper.Contar();

            return fa;
        }

        public double Promedio()
        {
            double fa = 0.0;

            fa = mapper.CalcularProm();

            return fa;
        }

        public int Min()
        {
            int fa = 0;

            fa = mapper.CalcularMin();

            return fa;
        }

        public int MAX()
        {
            int fa = 0;

            fa = mapper.CalcularMAX();

            return fa;
        }

        BLL.Profesion profesionBll = new BLL.Profesion();

        public void listarProfesiones(ComboBox cmb)
        {

            List<BE.Profesion> profesiones = profesionBll.ListarProfesion();

            cmb.DataSource = profesiones;

            cmb.DisplayMember = "Nombre_Profesion";

            cmb.SelectedIndex = -1;
        }

        BLL.Nacionalidad nacionalidadBll = new BLL.Nacionalidad();


        public void listarNacionalidades(ComboBox cmb)
        {

            List<BE.Nacionalidad> nacionalidades = nacionalidadBll.ListarNacionalidad();

            cmb.DataSource = nacionalidades;

            cmb.DisplayMember = "Nombre_Nacionalidad";

            cmb.SelectedIndex = -1;
        }

    }
}
