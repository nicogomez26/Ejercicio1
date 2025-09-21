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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void personaBtn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Show();
            this.Hide();
        }

        private void nacionalidadBtn_Click(object sender, EventArgs e)
        {
            Nacionalidad nacionalidad = new Nacionalidad();
            nacionalidad.Show();
            this.Hide();
        }

        private void profesionBtn_Click(object sender, EventArgs e)
        {
            Profesion profesion = new Profesion();
            profesion.Show();
            this.Hide();
        }
    }
}
