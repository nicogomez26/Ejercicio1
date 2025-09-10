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
    public partial class Form1 : Form
    {
        public Form1()
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

        public void VerGrillaNac()
        {
            grilla.DataSource = null;
            grilla.DataSource = nacionalidadBll.ListarNacionalidad();
        }

        public void VerGrillaPro()
        {
            grilla.DataSource = null;
            grilla.DataSource = profesionBll.ListarProfesion();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VerGrilla();
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
            persona.IdNacionalidad = int.Parse(nacionalidadCmb.Text);
            persona.IdProfesion = int.Parse(profesionCmb.Text);

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

            cantPersonaTxt.Text = personaBll.Contar().ToString();


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
            persona.IdNacionalidad = int.Parse(nacionalidadCmb.Text);
            persona.IdProfesion = int.Parse(profesionCmb.Text);


            fa = personaBll.EditarPersona(persona);

            if (fa != 0) {
                MessageBox.Show("Se modificó");
                VerGrilla();
            }
            else { MessageBox.Show("Error"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int fa = 0;
            persona = new BE.Persona();
            persona.NroPersona = int.Parse(nroPerTxt.Text);
            fa = personaBll.EliminarPersona(persona);

            if (fa != 0)
            {
                MessageBox.Show("Se Elimino");
                VerGrilla();
            }
            else
            {
                MessageBox.Show("Error");
            }
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
            nacionalidadCmb.Text = tmp.IdNacionalidad.ToString();
            profesionCmb.Text = tmp.IdProfesion.ToString();
        }

        private void agrNacBtn_Click(object sender, EventArgs e)
        {

            int fa = 0;

            nacionalidad = new BE.Nacionalidad();

            nacionalidad.IdNacionalidad = int.Parse(nroNacTxt.Text);
            nacionalidad.Nombre_nacionalidad = nomNacTxt.Text;
            nacionalidad.CantPersonas = 0;
            nacionalidad.PromEdad = 0.0;

            fa = nacionalidadBll.AgregarNacionalidad(nacionalidad);

            if (fa != 0)
            {
                MessageBox.Show("Se agregó");
                VerGrillaNac();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void editNacBtn_Click(object sender, EventArgs e)
        {
            VerGrillaNac();
        }
    }
}
