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
    public partial class Profesion : Form
    {
        public Profesion()
        {
            InitializeComponent();
        }

        BE.Profesion profesion;

        BLL.Profesion profesionBll = new BLL.Profesion();

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();

            empresa.Show();
            this.Hide();
        }
        public void VerGrillaPro()
        {
            grillaProf.DataSource = null;
            grillaProf.DataSource = profesionBll.ListarProfesion();
        }
        private void agrProBtn_Click(object sender, EventArgs e)
        {

            int fa = 0;

            profesion = new BE.Profesion();

            profesion.IdProfesion = int.Parse(nroProTxt.Text);
            profesion.Nombre_profesion = nomProTxt.Text;

            fa = profesionBll.AgregarProfesion(profesion);

            if (fa != 0)
            {
                MessageBox.Show("Se agregó");
                VerGrillaPro();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Profesion_Load(object sender, EventArgs e)
        {
            VerGrillaPro();
        }

        BE.Profesion tmp;

        private void grillaProf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tmp = (BE.Profesion)grillaProf.Rows[e.RowIndex].DataBoundItem;
            nroProTxt.Text = tmp.IdProfesion.ToString();
            nomProTxt.Text = tmp.Nombre_profesion.ToString();
        }

        private void editProBtn_Click(object sender, EventArgs e)
        {
            int fa = 0;

            profesion = new BE.Profesion();

            profesion.IdProfesion = int.Parse(nroProTxt.Text);
            profesion.Nombre_profesion = nomProTxt.Text;

            fa = profesionBll.EditarProfesion(profesion);

            if (fa != 0)
            {
                MessageBox.Show("Se modificó");
                VerGrillaPro();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void elimProBtn_Click(object sender, EventArgs e)
        {
            int fa = 0;
            profesion = new BE.Profesion();
            profesion.IdProfesion = int.Parse(nroProTxt.Text);
            fa = profesionBll.EliminarProfesion(profesion);

            if (fa != 0)
            {
                MessageBox.Show("Se eliminó");
                VerGrillaPro();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
