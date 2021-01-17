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
    public partial class Categoria : Form
    {

        CategoriaL categorial = new CategoriaL();
        string ID_CATEGORIA=null;
        bool editar=false;

        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            Mostrar_Categoria();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedCells.Count > 0 && txtNombre.Text !="")
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    categorial.Eliminar_Categoria(ID_CATEGORIA);
                    Limpiar_Categoria();
                    Mostrar_Categoria();

                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void button1_Click(object sender, EventArgs e)
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

        public void Mostrar_Categoria()
        {
            CategoriaL categoriala = new CategoriaL();
            dgvCategoria.DataSource = categoriala.Mostrar_Categoria();
            dgvCategoria.Columns[0].Width = 30;
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            txtNombre.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
             ID_CATEGORIA = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
            Deshabilitar_Categoria();
            Habilitar_Botones();
            btnGuardar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            Limpiar_Categoria();
            Habilitar_Categoria();
            Habilitar_Botones();
            btnGuardar.Enabled = true;
            txtNombre.Focus();
            
        }

        public void Habilitar_Categoria()
        {
            txtNombre.Enabled = true;
        }
        public void Deshabilitar_Categoria()
        {
            txtNombre.Enabled = false;
        }

        public void Limpiar_Categoria()
        {
            txtNombre.Text = "";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if ( txtNombre.Text == "" )
                {
                    MessageBox.Show("Faltan Ingresar Datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    categorial.Insertar_Categoria( txtNombre.Text);
                    MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                    Mostrar_Categoria();
                    Limpiar_Categoria();
                    Deshabilitar_Botones();
                    Deshabilitar_Categoria();


                }
            }



            if (editar == true)
            {

                categorial.Editar_Categoria( txtNombre.Text,ID_CATEGORIA);
                MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Categoria();
                Limpiar_Categoria();
                editar = false;
                btnEditar.Enabled = false;
                btnGuardar.Enabled = false;
                Deshabilitar_Categoria();
            }


        
    }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Categoria();
            if (dgvCategoria.SelectedCells.Count > 0)
            {
                txtNombre.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
                ID_CATEGORIA = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
                editar = true;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
