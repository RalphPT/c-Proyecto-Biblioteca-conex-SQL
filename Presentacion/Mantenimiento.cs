using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBibliotecario_Click(object sender, EventArgs e)
        {
            Bibliotecario irbibliotecario = new Bibliotecario();
            irbibliotecario.Show();
            this.Visible = false;
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


        private void btnSalir_Click(object sender, EventArgs e)
        {

            Menu irmenu = new Menu();
            irmenu.Show();
            this.Hide();
           
        }

        private void btnComputadora_Click(object sender, EventArgs e)
        {
            Computadora ircomputadora = new Computadora();
            ircomputadora.Show();
            this.Visible = false;
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidad irespecialidad = new Especialidad();
            irespecialidad.Show();
            this.Visible = false;
        }



        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumno iralumno = new Alumno();
            iralumno.Show();
            this.Visible = false;
        }
    }
}
