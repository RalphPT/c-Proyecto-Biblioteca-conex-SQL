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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void Desconectar()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE BIBLIOTECARIO SET ESTADO = '0'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Salir del Programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                Desconectar();
                Login irlogin = new Login();
                irlogin.Show();
                Hide();
            }
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Prestamos irprestamos = new Prestamos();
            irprestamos.Show();
            this.Hide();
        }

        private void btnMantenimiento__Click(object sender, EventArgs e)
        {
            Mantenimiento irmantenimiento = new Mantenimiento();
            irmantenimiento.Show();
            this.Hide();
        }

        private void btnBusqueda_Libros_Click(object sender, EventArgs e)
        {
            Busqueda_Libro irbusqueda_libro = new Busqueda_Libro();
            irbusqueda_libro.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
