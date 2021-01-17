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
    public partial class Libro : Form
    {
        bool editar = false;
        string ID_LIBRO = null;
        string ID_CATEGORIA = null;
        LibroL librol = new LibroL();

        public Libro()
        {
            InitializeComponent();
        }

        private void Libro_Load(object sender, EventArgs e)
        {
            Mostrar_Libro();
            cboDisponibilidad.Text = "DISPONIBLE";
            LISTAR_CATEGORIA();
        }


        public void Mostrar_Libro()
        {
            LibroL librola = new LibroL();
            dgvLibro.DataSource = librola.Mostrar_Libro();
            dgvLibro.Columns[0].Width = 40;
            dgvLibro.Columns[1].Width = 60;
            dgvLibro.Columns[2].Width = 200;
            dgvLibro.Columns[3].Width = 150;
            dgvLibro.Columns[4].Width = 150;
            dgvLibro.Columns[5].Width = 160;
            dgvLibro.Columns[6].Width = 100;
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
        private void btnSalir_Click(object sender, EventArgs e)
        {

            Verificar_Sesion();
            if (encontrado == true)
            {
                Mantenimiento_2 irmenu = new Mantenimiento_2();
                irmenu.Show();
                this.Visible = false;
            }
            if (encontrado == false)
            {
                Mantenimiento irmenu = new Mantenimiento();
                irmenu.Show();
                this.Visible = false;
            }
        }


        private void LISTAR_CATEGORIA()
        {
            LibroL librolas = new LibroL();
            cboCategoria.DataSource = librolas.Listar_Categoria();
            cboCategoria.DisplayMember = "NOMBRE_CAT";
            cboCategoria.ValueMember = "ID_CATEGORIA";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
            editar = false;
            Limpiar_Libro();
            Habilitar_Libro();
            Habilitar_Botones();
            btnGuardar.Enabled = true;
            txtCodigo.Focus();
        }

        private void Limpiar_Libro()
        {
            txtCodigo.Text = "";
            txtAutor.Text = "";
            txtDescripcion.Text = "";
            txtEditorial.Text = "";
            txtTitulo.Text = "";
            cboCategoria.SelectedItem = "";
            cboDisponibilidad.SelectedItem = "DISPONIBLE";

        }

        private void Deshabilitar_Libro()
        {
            txtAutor.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtEditorial.Enabled = false;
            txtTitulo.Enabled = false;
            cboCategoria.Enabled = false;
            cboDisponibilidad.Enabled = false;
        }

        private void Habilitar_Libro()
        {
            txtAutor.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtEditorial.Enabled = true;
            txtTitulo.Enabled = true;
            cboCategoria.Enabled = true;
            cboDisponibilidad.Enabled = true;
        }

        public void Habilitar_Botones()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        public void Deshabilitar_Botones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedCells.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    librol.Eliminar_Libro(txtCodigo.Text);
                    Limpiar_Libro();
                    Mostrar_Libro();
                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


            txtCodigo.Text = dgvLibro.CurrentRow.Cells[1].Value.ToString();
            txtTitulo.Text = dgvLibro.CurrentRow.Cells[2].Value.ToString();
            txtAutor.Text = dgvLibro.CurrentRow.Cells[3].Value.ToString();
            txtEditorial.Text = dgvLibro.CurrentRow.Cells[4].Value.ToString();
            cboCategoria.Text=dgvLibro.CurrentRow.Cells[5].Value.ToString();
            cboDisponibilidad.SelectedItem = dgvLibro.CurrentRow.Cells[6].Value.ToString();
            txtDescripcion.Text = dgvLibro.CurrentRow.Cells[7].Value.ToString();
            ID_LIBRO = dgvLibro.CurrentRow.Cells[0].Value.ToString();
            ID_CATEGORIA = dgvLibro.CurrentRow.Cells[5].Value.ToString();
            Deshabilitar_Libro();
            Habilitar_Botones();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Libro();
            if (dgvLibro.SelectedCells.Count > 0)
            {
                txtCodigo.Text = dgvLibro.CurrentRow.Cells[1].Value.ToString();
                txtTitulo.Text = dgvLibro.CurrentRow.Cells[2].Value.ToString();
                txtAutor.Text = dgvLibro.CurrentRow.Cells[3].Value.ToString();
                txtEditorial.Text = dgvLibro.CurrentRow.Cells[4].Value.ToString();
                cboCategoria.Text = dgvLibro.CurrentRow.Cells[5].Value.ToString();
                cboDisponibilidad.SelectedItem = dgvLibro.CurrentRow.Cells[6].Value.ToString();
                txtDescripcion.Text = dgvLibro.CurrentRow.Cells[7].Value.ToString();
                ID_LIBRO = dgvLibro.CurrentRow.Cells[0].Value.ToString();
                ID_CATEGORIA = dgvLibro.CurrentRow.Cells[5].Value.ToString();

                editar = true;
                btnGuardar.Enabled = true;

            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (txtCodigo.Text == "" || txtAutor.Text == "" || txtTitulo.Text=="" || cboCategoria.Text=="" || cboDisponibilidad.Text=="")
                {
                    MessageBox.Show("Faltan Ingresar Datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    librol.Insertar_Libro(txtCodigo.Text, txtTitulo.Text,txtAutor.Text,txtEditorial.Text, cboCategoria.SelectedValue.ToString(), cboDisponibilidad.SelectedItem.ToString(),txtDescripcion.Text);
                    MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                    Mostrar_Libro();
                    Limpiar_Libro();
                    Deshabilitar_Botones();
                    Deshabilitar_Libro();


                }
            }



            if (editar == true)
            {

                librol.Editar_Libro(txtCodigo.Text, txtTitulo.Text, txtAutor.Text, txtEditorial.Text, cboCategoria.SelectedValue.ToString(), cboDisponibilidad.SelectedItem.ToString(), txtDescripcion.Text, ID_LIBRO);
                MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Libro();
                Limpiar_Libro();
                editar = false;
            }

        }

        private void dgvLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Libro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
