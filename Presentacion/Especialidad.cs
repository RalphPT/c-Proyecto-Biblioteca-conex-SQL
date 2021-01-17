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

namespace Presentacion
{
    public partial class Especialidad : Form
    {
        EspecialidadL especialidadl = new EspecialidadL();
        
        string ID_ESPECIALIDAD = null;
        bool editar = false;
        public Especialidad()
        {
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Mantenimiento irmenu = new Mantenimiento();
            irmenu.Show();
            this.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            Limpiar_Especialidad();
            Habilitar_Especialidad();
            Habilitar_Botones();
            btnGuardar.Enabled = true;
            txtNombre.Focus();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            Mostrar_Especialidad();
        }

        public void Mostrar_Especialidad()
        {
            EspecialidadL especialidadla = new EspecialidadL();
            dgvEspecialidad.DataSource = especialidadla.Mostrar_Especialidad();
            dgvEspecialidad.Columns[0].Width = 40;
        }

        public void Habilitar_Especialidad()
        {

            txtNombre.Enabled = true;
        }
        public void Deshabilitar_Especialidad()
        {

            txtNombre.Enabled = false;
        }

        public void Limpiar_Especialidad()
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Especialidad();
            if (dgvEspecialidad.SelectedCells.Count > 0)
            {
                txtNombre.Text = dgvEspecialidad.CurrentRow.Cells[1].Value.ToString();
                ID_ESPECIALIDAD = dgvEspecialidad.CurrentRow.Cells[0].Value.ToString();
                editar = true;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Especialidad!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidad.SelectedCells.Count > 0  && txtNombre.Text != "")
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    especialidadl.Eliminar_Especialidad(ID_ESPECIALIDAD);
                    Limpiar_Especialidad();
                    Mostrar_Especialidad();

                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Especialidad!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                if ( txtNombre.Text == "")
                {
                    MessageBox.Show("Faltan Ingresar Datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    especialidadl.Insertar_Especialidad(txtNombre.Text);
                    MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                    Mostrar_Especialidad();
                    Limpiar_Especialidad();
                    Deshabilitar_Botones();
                    Deshabilitar_Especialidad();


                }
            }



            if (editar == true)
            {

                especialidadl.Editar_Especialidad(txtNombre.Text, ID_ESPECIALIDAD);
                MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar_Especialidad();
                Limpiar_Especialidad();
                editar = false;
            }

        }

        private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


            txtNombre.Text = dgvEspecialidad.CurrentRow.Cells[1].Value.ToString();
            ID_ESPECIALIDAD = dgvEspecialidad.CurrentRow.Cells[0].Value.ToString();
            Deshabilitar_Especialidad();
            Habilitar_Botones();
            btnGuardar.Enabled = false;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validación v = new Validación();
            v.sololetras(e);
        }

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
