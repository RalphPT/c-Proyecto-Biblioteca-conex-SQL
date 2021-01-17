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
    public partial class Prestamos_Computadora : Form
    {

        PrestamosL prestamosl = new PrestamosL();
        AlumnoL alumnol = new AlumnoL();
        SqlCommand comando = new SqlCommand();
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        string ID_ALUMNO = null;
        string ID_ESPECIALIDAD = null;
        string ID_COMPUTADORA = null;
        bool SALIDA = false;




        public Prestamos_Computadora()
        {
            InitializeComponent();
            Hora.Start();
            Mostrar_Prestamos_Computadora();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha2.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Prestamos irprestamos = new Prestamos();
            irprestamos.Show();
            this.Hide();
        }

        public void Mostrar_Prestamos_Computadora()
        {
            PrestamosL prestamosla = new PrestamosL();
            dgvPrestamosComputadora.DataSource = prestamosla.Mostrar_Prestamos_Computadora();
 


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

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            DataTable tabla2 = new DataTable(txtNumero.Text);

            if (txtNumero.TextLength < 0 && txtNumero.TextLength >2)
            {
                MessageBox.Show("Número de Computadora inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Focus();
            }
            else
            {


                comando.Connection = conexion.AbrirConexion();
                try
                {
                    comando.CommandText = "SELECT * FROM COMPUTADORA WHERE NUMERO ='" + txtNumero.Text + "'";
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    tabla2.Load(leer);
                    lblNombreComputadora.Visible = true;
                    lblNombreComputadora.Text = tabla2.Rows[0][1].ToString();
                    ID_COMPUTADORA = tabla2.Rows[0][0].ToString();
                 

                }
                catch (Exception)
                {
                    txtNumero.Text = "";
                    lblNombreComputadora.Text = "NO ENCONTRADO!!!";
                    txtNumero.Focus();
                }

                conexion.CerrarConexion();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DataTable tablas = new DataTable(txtNumero.Text);
            DialogResult confirmar = MessageBox.Show("¿Desea confirmar el Préstamo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (confirmar == DialogResult.Yes)
                {
                    if (lblNombreAlumno.Text == "NO ENCONTRADO!!!" && lblNombreComputadora.Text != "NO ENCONTRADO!!!" )
                    {
                        MessageBox.Show("Faltan ingresar datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string HORA_ENTRADA = lblHora.Text;
                        prestamosl.Insertar_Prestamos_Computadora(ID_ALUMNO,ID_COMPUTADORA, ID_ESPECIALIDAD, txtId_Bib.Text, HORA_ENTRADA,"", lblFecha2.Text, "OCUPADO");
                        MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar_Prestamos_Computadora();
                        Limpiar_Prestamos_Computadora();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No cumple los parámetros de ingreso!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Prestamos_Computadora_Load(object sender, EventArgs e)
        {
            dgvPrestamosComputadora.Columns[0].Width = 30;
            dgvPrestamosComputadora.Columns[1].Width = 180;
            dgvPrestamosComputadora.Columns[2].Width = 40;
            dgvPrestamosComputadora.Columns[3].Width = 180;
            dgvPrestamosComputadora.Columns[4].Width = 190;
            dgvPrestamosComputadora.Columns[5].Width = 70;
            dgvPrestamosComputadora.Columns[6].Width = 70;
            dgvPrestamosComputadora.Columns[7].Width = 70;
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
                txtId_Bib.Text = "999999999";
                txtDni.Enabled = false;
                txtNumero.Enabled = false;
                cboEspecialidad.Enabled = false;
                btnConfirmar.Enabled = false;
                btnMarcarSalida.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Limpiar_Prestamos_Computadora()
        {
            txtDni.Clear();
            cboEspecialidad.Items.Clear();
            txtNumero.Clear();
            lblApellidosAlumno.Visible = false;
            lblNombreAlumno.Visible = false;
            lblNombreComputadora.Visible = false;
            lblNombreAlumno.Text = "NO ENCONTRADO!!!";
            lblApellidosAlumno.Text = "NO ENCONTRADO!!!";
            lblNombreComputadora.Text = "NO ENCONTRADO!!!";
        }

        private void dgvPrestamosComputadora_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ID_COMPUTADORA = dgvPrestamosComputadora.CurrentRow.Cells[0].Value.ToString();
            SALIDA = true;
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            if (SALIDA == true)
            {

                if (dgvPrestamosComputadora.CurrentRow.Cells[6].Value.ToString() == "00:00:00")
                {

                    comando.Connection = conexion.AbrirConexion();
                    comando.CommandText = "UPDATE PRESTAMOS_COMPUTADORA SET HORA_SALIDA='" + lblHora.Text + "' WHERE ID_PRESTAMO_C ='" + ID_COMPUTADORA + "'";
                    comando.CommandType = CommandType.Text;
                    leer = comando.ExecuteReader();
                    MessageBox.Show("Salida Marcada!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SALIDA = false;
                    Mostrar_Prestamos_Computadora();
                    conexion.CerrarConexion();
                    
                }
                else 
                {
                    MessageBox.Show("Ya ha salido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado préstamo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
