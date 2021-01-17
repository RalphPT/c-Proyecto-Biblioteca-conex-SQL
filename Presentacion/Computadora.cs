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
    public partial class Computadora : Form
    {
        ComputadoraL computadoral = new ComputadoraL();
        string ID_COMP = null;
        bool editar = false;

        public Computadora()
        {
            InitializeComponent();
            
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

        private void Mostrar_Computadora()
        {
            ComputadoraL computadorala = new ComputadoraL();
            dgvComputadora.DataSource = computadorala.Mostrar_Computadora();
            dgvComputadora.Columns[0].Width = 40;
            dgvComputadora.Columns[1].Width = 40;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComputadora.SelectedCells.Count > 0 && txtNumero.Text != "" && cboEstado.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    computadoral.Eliminar_Computadora(ID_COMP);
                    Limpiar_Computadora();
                    Mostrar_Computadora();

                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Computadora!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Habilitar_Computadora()
        {
            txtNumero.Enabled = true;
            cboEstado.Enabled = true;
        }
        public void Deshabilitar_Computadora()
        {
            txtNumero.Enabled = false;
            cboEstado.Enabled = false;
        }

        public void Limpiar_Computadora()
        {
            txtNumero.Text = "";
            cboEstado.SelectedIndex = 0;
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

        private void dgvComputadora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            txtNumero.Text = dgvComputadora.CurrentRow.Cells[1].Value.ToString();
            cboEstado.Text = dgvComputadora.CurrentRow.Cells[2].Value.ToString();
            ID_COMP = dgvComputadora.CurrentRow.Cells[0].Value.ToString();
            Deshabilitar_Computadora();
            Habilitar_Botones();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            cboEstado.SelectedIndex = 0;
            Limpiar_Computadora();
            Habilitar_Computadora();
            Habilitar_Botones();
            btnGuardar.Enabled = true;
            txtNumero.Focus();
 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if (txtNumero.Text == "" || cboEstado.Text == "")
                {
                    MessageBox.Show("Faltan Ingresar Datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    computadoral.Insertar_Computadora(txtNumero.Text, cboEstado.Text);
                    MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                    Mostrar_Computadora();
                    Limpiar_Computadora();
                    Deshabilitar_Botones();
                    Deshabilitar_Computadora();


                }
            }



            if (editar == true)
            {

                computadoral.Editar_Computadora(txtNumero.Text, cboEstado.Text, ID_COMP);
                MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Computadora();
                Limpiar_Computadora();
                editar = false;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Computadora();
            if (dgvComputadora.SelectedCells.Count > 0)
            {
                txtNumero.Text = dgvComputadora.CurrentRow.Cells[1].Value.ToString();
                cboEstado.Text = dgvComputadora.CurrentRow.Cells[2].Value.ToString();
                ID_COMP = dgvComputadora.CurrentRow.Cells[0].Value.ToString();
                editar = true;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Computadora!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Computadora_Load(object sender, EventArgs e)
        {
            Mostrar_Computadora();
            cboEstado.SelectedIndex = 0;
            Deshabilitar_Computadora();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validación v = new Validación();
            v.solonumeros(e);
        }

        private void Computadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
