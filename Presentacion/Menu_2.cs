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
    public partial class Menu_2 : Form
    {
        public Menu_2()
        {
            InitializeComponent();
        }

        bool sesion = false;

        Conexion conexion = new Conexion();
        public void Verificar_Sesion()
        {

            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from bibliotecario where ESTADO = '1'";
            comando.CommandType = CommandType.Text;
            int filasafectadas = comando.ExecuteNonQuery();
            if (filasafectadas > 1)
            {
                sesion = true;
            }
            else
            {
                sesion = false;
            }
            comando.Connection = conexion.CerrarConexion();
        }

        private void btnBusqueda_Libros_Click(object sender, EventArgs e)
        {
            Busqueda_Libro irbusqueda_libro = new Busqueda_Libro();
            irbusqueda_libro.Show();
            this.Hide();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos irprestamos = new Prestamos();
            irprestamos.Show();
            this.Hide();
        }

        private void btnMantenimiento__Click(object sender, EventArgs e)
        {
            Mantenimiento_2 irmantenimiento2 = new Mantenimiento_2();
            irmantenimiento2.Show();
            this.Hide();
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

        private void Menu_2_Load(object sender, EventArgs e)
        {

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
    }
}
