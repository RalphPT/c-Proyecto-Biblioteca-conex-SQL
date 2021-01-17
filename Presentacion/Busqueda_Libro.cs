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
using Logica;
using Datos;

namespace Presentacion
{
    public partial class Busqueda_Libro : Form
    {

        Conexion conexion = new Conexion();
        
        string ID_CATEGORIA = null;
        public Busqueda_Libro()
        {
            InitializeComponent();
        }


        private void txtLibro_KeyUp(object sender, KeyEventArgs e)
        {
            FILTRAR_BUSQUEDA_LIBRO(dgvCatalogo,txtLibro.Text);
        }

        private void Mostrar_Busqueda_Libros()
        {
            LibroL librol = new LibroL();
            dgvCatalogo.DataSource = librol.Mostrar_Busqueda_Libro();
            dgvCatalogo.Columns[0].Width = 50;
        }
        private void Busqueda_Libro_Load(object sender, EventArgs e)
        {
            Mostrar_Busqueda_Libros();


        }


        public void FILTRAR_BUSQUEDA_LIBRO(DataGridView dgvCatalogo,string nombre)
        {
            SqlCommand comando2 = new SqlCommand();
            comando2.Connection = conexion.AbrirConexion();
            comando2.CommandText="FILTRAR_BUSQUEDA_LIBRO";
            comando2.CommandType = CommandType.StoredProcedure;
            comando2.Parameters.Add("@NOMBRE",SqlDbType.VarChar,20).Value=txtLibro.Text;
            comando2.ExecuteNonQuery();
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando2);
            da.Fill(tabla);
            dgvCatalogo.DataSource = tabla;
            comando2.Connection = conexion.CerrarConexion();
        }



        bool encontrado = false;
        int sesion;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Verificar_Sesion();
            if (encontrado == true)
            {
                Menu_2 irmenu = new Menu_2();
                irmenu.Show();
                this.Hide();
            }
            if (encontrado == false)
            {
                Menu irmenu = new Menu();
                irmenu.Show();
                this.Hide();
            }
        }
    }
}
