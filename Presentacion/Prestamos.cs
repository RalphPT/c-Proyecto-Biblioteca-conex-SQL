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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

            Prestamos_Libro irprestamoslibro = new Prestamos_Libro();
            irprestamoslibro.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Verificar_Sesion();
            if (encontrado == true)
            {
                Menu_2 irmenu = new Menu_2();
                irmenu.Show();
                this.Hide();
            }
            if (encontrado==false)
            {
                Menu irmenu = new Menu();
                irmenu.Show();
                this.Hide();
            }
            
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {
            Prestamos_Computadora irprestamoscomputadora = new Prestamos_Computadora();
            irprestamoscomputadora.Show();
            this.Hide();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        bool encontrado = false;
        int sesion;
        Conexion conexion = new Conexion();
        public void Verificar_Sesion()
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                DataTable tabla = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select * from bibliotecario where ESTADO = '1'";
                comando.CommandType = CommandType.Text;
                sesion = (int)comando.ExecuteScalar();

                if (sesion == 0)
                {
                    encontrado = false;
                }
                else if (sesion == 1)
                {
                    encontrado = true;
                }
                else
                {
                    encontrado = true;
                }
                comando.Connection = conexion.CerrarConexion();
            }
            catch (Exception)
            {

                encontrado = false;
            } 
        }
    }
}
