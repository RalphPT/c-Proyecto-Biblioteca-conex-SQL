using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Prestamos_Libro : Form
    {

        PrestamosL prestamosl = new PrestamosL();
        AlumnoL alumnol = new AlumnoL();
        SqlCommand comando = new SqlCommand();
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        string ID_ALUMNO = null;
        string ID_ESPECIALIDAD = null;
        string ID_LIBRO = null;
        bool CAMBIO = false;
        string ID_PRESTAMO=null;



        public Prestamos_Libro()
        {
            InitializeComponent();
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            fecha.Start();
            Mostrar_Prestamos();
            txtDni.Focus();
            Mostrar_Bibliotecario();

        }

        public void Mostrar_Bibliotecario()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM BIBLIOTECARIO WHERE ESTADO='1'";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                txtBibliotecario.Text = tabla.Rows[0][3].ToString() + " " + tabla.Rows[0][4].ToString();
                txtId_Bib.Text = tabla.Rows[0][0].ToString();

                comando.Connection = conexion.CerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingreso en modo Administrador, Los préstamos serán inhabilitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBibliotecario.Text = "Administrador";
                txtCodLibro.Enabled = false;
                txtDni.Enabled = false;
                cboEspecialidad.Enabled = false;
                btnConfirmar.Enabled = false;
                btnEstado.Enabled = false;
                
            }
       }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Prestamos irprestamos = new Prestamos();
            irprestamos.Show();
            this.Hide();
        }

        public void Mostrar_Prestamos()
        {
            PrestamosL prestamosla = new PrestamosL();
            dgvPrestamos.DataSource = prestamosla.Mostrar_Prestamos();
            dgvPrestamos.Columns[0].Width = 30;
            dgvPrestamos.Columns[1].Width = 150;
            dgvPrestamos.Columns[2].Width = 150;
            dgvPrestamos.Columns[3].Width = 150;
            dgvPrestamos.Columns[4].Width = 150;
            dgvPrestamos.Columns[5].Width = 100;
            dgvPrestamos.Columns[6].Width = 100;
             
        }


        private void txtDni_Leave(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable(txtDni.Text);
            DataTable tabla1 = new DataTable();

            if (txtDni.TextLength < 8)
            {
                MessageBox.Show("Número de DNI inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
            }
            else
            {
                comando.Connection = conexion.AbrirConexion();
                try
                {
                    comando.CommandText = "SELECT * FROM ALUMNO WHERE DNI_ALUM ='" + txtDni.Text + "'";
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    tabla.Load(leer);
                    lblNombreAlumno.Visible = true;
                    lblApellidosAlumno.Visible = true;
                    lblNombreAlumno.Text = tabla.Rows[0][1].ToString();
                    lblApellidosAlumno.Text = tabla.Rows[0][2].ToString();
                    ID_ALUMNO = tabla.Rows[0][0].ToString();
                    string Especialidad = tabla.Rows[0][5].ToString();
                    cboEspecialidad.Items.Add(Especialidad);
                    comando.CommandText = "SELECT ID_ESPECIALIDAD,NOMBRE_ESP FROM ESPECIALIDAD WHERE ID_ESPECIALIDAD = '" + Especialidad + "'";
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    tabla1.Load(leer);
                    cboEspecialidad.Items.Clear();
                    ID_ESPECIALIDAD = tabla1.Rows[0][0].ToString();
                    cboEspecialidad.Items.Add(tabla1.Rows[0][1].ToString());
                    cboEspecialidad.SelectedIndex = 0;
                    comando.Parameters.Clear();

                }
                catch (Exception)
                {

                    lblNombreAlumno.Text = "NO ENCONTRADO!!!";
                    txtDni.Text = "";
                    txtDni.Focus();
                    lblApellidosAlumno.Visible = false;
                }
                conexion.CerrarConexion();
            }
        }

        private void txtCodLibro_Leave(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable(txtCodLibro.Text);

            if (txtCodLibro.TextLength < 5)
            {
                MessageBox.Show("Código de Libro inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodLibro.Focus();
            }
            else
            {


                comando.Connection = conexion.AbrirConexion();
                try
                {
                    comando.CommandText = "SELECT * FROM LIBRO WHERE COD_LIBRO ='" + txtCodLibro.Text + "'";
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    tabla2.Load(leer);
                    lblNombreLibro.Visible = true;
                    lblNombreLibro.Text = tabla2.Rows[0][2].ToString();
                    ID_LIBRO = tabla2.Rows[0][0].ToString();


                }
                catch (Exception)
                {
                    txtCodLibro.Text = "";
                    lblNombreLibro.Text = "NO ENCONTRADO!!!";
                    txtCodLibro.Focus();
                }

                conexion.CerrarConexion();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable tablas = new DataTable(txtCodLibro.Text);
            DialogResult confirmar = MessageBox.Show("¿Desea confirmar la Entrega?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (confirmar == DialogResult.Yes)
                {
                    if (lblNombreAlumno.Text == "NO ENCONTRADO!!!" && lblNombreLibro.Text != "NO ENCONTRADO!!!")
                    {
                        MessageBox.Show("Faltan ingresar datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        prestamosl.Insertar_Prestamos( ID_ALUMNO, ID_LIBRO, ID_ESPECIALIDAD, txtId_Bib.Text, lblFecha.Text, "PRESTADO");
                        MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar_Prestamos();
                        Limpiar_Prestamos();

                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("No cumple requisitos de ingreso!" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Limpiar_Prestamos()
        {
            txtDni.Clear();
            txtCodLibro.Clear();
            cboEspecialidad.Items.Clear();
            lblApellidosAlumno.Text = "NO ENCONTRADO!!!";
            lblNombreAlumno.Text = "NO ENCONTRADO!!!";
            lblNombreLibro.Text = "NO ENCONTRADO!!!";
            lblApellidosAlumno.Visible = false;
            lblNombreAlumno.Visible = false;
            lblNombreLibro.Visible = false;
            ID_ALUMNO = null;
            ID_ESPECIALIDAD = null;
            ID_LIBRO = null;
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ID_PRESTAMO = dgvPrestamos.CurrentRow.Cells[0].Value.ToString();
            CAMBIO = true;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

            if (CAMBIO == true)
            {

                if (dgvPrestamos.CurrentRow.Cells[6].Value.ToString() == "DEVUELTO")
                {
                    MessageBox.Show("Ya ha sido devuelto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (dgvPrestamos.CurrentRow.Cells[6].Value.ToString() == "PRESTADO")
                {
                    comando.Connection = conexion.AbrirConexion();
                    //REEMPLAZAR POR ID_PRESTAMO_L 
                    comando.CommandText = "UPDATE PRESTAMOS_LIBRO SET ESTADO='DEVUELTO' WHERE ID_PRESTAMO_L ='" + ID_PRESTAMO + "'"; 
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    MessageBox.Show("Modificado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CAMBIO = false;
                    Mostrar_Prestamos();
                    conexion.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado préstamo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

    } 
}
