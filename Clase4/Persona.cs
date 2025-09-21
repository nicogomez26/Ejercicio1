using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase4
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }
        
        BE.Persona persona;

        BLL.Persona personaBll = new BLL.Persona();

        BE.Nacionalidad nacionalidad;

        BLL.Nacionalidad nacionalidadBll = new BLL.Nacionalidad();

        BE.Profesion profesion;

        BLL.Profesion profesionBll = new BLL.Profesion();


        public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = personaBll.ListarPersona();
            
        }

        public void mostrarRegistradas()
        {
            cantPersonaTxt.Text = personaBll.Contar().ToString();
        }

        public void mostrarPromedio()
        {
            promEdadTxt.Text = personaBll.Promedio().ToString("F2");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            personaBll.listarProfesiones(profesionCmb);
            personaBll.listarNacionalidades(nacionalidadCmb);
            VerGrilla();
            mostrarRegistradas();
            mostrarPromedio();
            MostrarMinYMax();
        }

        public void MostrarMinYMax()
        {
            edadMinTxt.Text = personaBll.Min().ToString();
            edadMaxTxt.Text = personaBll.MAX().ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int fa = 0;

            persona = new BE.Persona();

            persona.NroPersona = int.Parse(nroPerTxt.Text);
            persona.Nombre = nombreTxt.Text;
            persona.Apellido = apellidoTxt.Text;
            persona.Edad = int.Parse(edadTxt.Text);
            persona.Sexo = sexoCmb.Text;
            persona.Nacionalidad = nacionalidadCmb.SelectedItem as BE.Nacionalidad;
            persona.Profesion = profesionCmb.SelectedItem as BE.Profesion;

            fa = personaBll.AgregarPersona(persona);

            if (fa!= 0)
            {
                MessageBox.Show("Se agregó");
                VerGrilla();
            }
            else
            {
                MessageBox.Show("Error");
            }

            mostrarRegistradas();
            mostrarPromedio();
            MostrarMinYMax();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int fa = 0;

            persona = new BE.Persona();

            persona.NroPersona = int.Parse(nroPerTxt.Text);
            persona.Nombre = nombreTxt.Text;
            persona.Apellido = apellidoTxt.Text;
            persona.Edad = int.Parse(edadTxt.Text);
            persona.Sexo = sexoCmb.Text;
            persona.Nacionalidad = nacionalidadCmb.SelectedItem as BE.Nacionalidad;
            persona.Profesion = profesionCmb.SelectedItem as BE.Profesion;


            fa = personaBll.EditarPersona(persona);

            if (fa != 0) {
                MessageBox.Show("Se modificó");
                VerGrilla();
            }
            else { MessageBox.Show("Error"); }


            mostrarRegistradas();
            mostrarPromedio();
            MostrarMinYMax();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fa = 0;
            persona = new BE.Persona();
            persona.NroPersona = int.Parse(nroPerTxt.Text);
            fa = personaBll.EliminarPersona(persona);

            if (fa != 0)
            {
                MessageBox.Show("Se eliminó");
                VerGrilla();
            }
            else
            {
                MessageBox.Show("Error");
            }

            mostrarRegistradas();
            mostrarPromedio();
            MostrarMinYMax();
        }

        BE.Persona tmp;

        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tmp = (BE.Persona)grilla.Rows[e.RowIndex].DataBoundItem;
            nroPerTxt.Text = tmp.NroPersona.ToString();
            nombreTxt.Text = tmp.Nombre.ToString();
            apellidoTxt.Text = tmp.Apellido.ToString();
            edadTxt.Text = tmp.Edad.ToString();
            sexoCmb.Text = tmp.Sexo.ToString();
            nacionalidadCmb.Text = tmp.Nacionalidad.IdNacionalidad.ToString();
            profesionCmb.Text = tmp.Profesion.IdProfesion.ToString();
        }

       

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Show();
            this.Hide();

        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
