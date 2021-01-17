using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;

namespace Presentacion
{
    public partial class Mantenimiento_2 : Form
    {
        public Mantenimiento_2()
        {
            InitializeComponent();
        }


        private void btnCategoria_Click(object sender, EventArgs e)
        {

                Categoria ircategoria = new Categoria();
                ircategoria.Show();
                this.Visible = false;
     
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            Libro irlibro = new Libro();
            irlibro.Show();
            this.Visible = false;
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Computadora ircomputadora = new Computadora();
            ircomputadora.Show();
            this.Visible = false;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumno iralumno = new Alumno();
            iralumno.Show();
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

                Menu_2 irmenu = new Menu_2();
                irmenu.Show();
                this.Hide();
     
        }
    }
}
