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
    public partial class Nacionalidad : Form
    {
        public Nacionalidad()
        {
            InitializeComponent();
        }

        BLL.Nacionalidad nacionalidadBll = new BLL.Nacionalidad();
        BE.Nacionalidad nacionalidad = new BE.Nacionalidad();
        private void volverBtn_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Show();
            this.Hide();
        }
        public void VerGrillaNac()
        {
            grillaNac.DataSource = null;
            grillaNac.DataSource = nacionalidadBll.ListarNacionalidad();
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


        private void Nacionalidad_Load(object sender, EventArgs e)
        {
            VerGrillaNac();
        }

        private void editNacBtn_Click_1(object sender, EventArgs e)
        {

            int fa = 0;

            nacionalidad = new BE.Nacionalidad();

            nacionalidad.IdNacionalidad = int.Parse(nroNacTxt.Text);
            nacionalidad.Nombre_nacionalidad = nomNacTxt.Text;


            fa = nacionalidadBll.EditarNacionalidad(nacionalidad);

            if (fa != 0)
            {
                MessageBox.Show("Se editó");
                VerGrillaNac();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
