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
    public partial class Alumno : Form
    {

        AlumnoL alumnol = new AlumnoL();
        Validación v = new Validación();
        bool editar = false;
        string ID_ALUMNO = null;
        string ID_ESPECIALIDAD = null;
        string TURNO = null;
        public Alumno()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Mantenimiento irmenu = new Mantenimiento();
            irmenu.Show();
            this.Visible = false;
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            LISTAR_ESPECIALIDAD();
            Mostrar_Alumno();
            cboEspecialidad.SelectedIndex = 0;
            cboSemestre.SelectedIndex = 0;
        }

        private void LISTAR_ESPECIALIDAD()
        {
            AlumnoL alumnola = new AlumnoL();
            cboEspecialidad.DataSource = alumnola.Listar_Especialidad();
            cboEspecialidad.DisplayMember = "NOMBRE_ESP";
            cboEspecialidad.ValueMember = "ID_ESPECIALIDAD";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            Limpiar_Alumno();
            Habilitar_Alumno();
            Habilitar_Botones();
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            txtDni.Focus();
        }

        private void Limpiar_Alumno()
        {
            txtDni.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cboEspecialidad.SelectedIndex = 0;
            cboSemestre.SelectedIndex= 0;
            rbDiurno.Checked = true;

        }

        private void Deshabilitar_Alumno()
        {
            txtDni.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cboEspecialidad.Enabled = false;
            cboSemestre.Enabled = false;
            rbDiurno.Enabled = false;
            rbNocturno.Enabled = false;
        }

        private void Habilitar_Alumno()
        {
            txtDni.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            cboEspecialidad.Enabled = true;
            cboSemestre.Enabled = true;
            rbDiurno.Enabled = true;
            rbNocturno.Enabled = true;
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
        Conexion conexion = new Conexion();
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

        public void Mostrar_Alumno()
        {
            AlumnoL alumnolasa = new AlumnoL();
            dgvAlumno.DataSource = alumnolasa.Mostrar_Alumno();
            dgvAlumno.Columns[0].Width = 40;
            dgvAlumno.Columns[1].Width = 180;
            dgvAlumno.Columns[2].Width = 180;
            dgvAlumno.Columns[3].Width = 70;
            dgvAlumno.Columns[4].Width = 100;
            dgvAlumno.Columns[5].Width = 200;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumno.SelectedCells.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    alumnol.Eliminar_Alumno(ID_ALUMNO);
                    Limpiar_Alumno();
                    Mostrar_Alumno();
                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Alumno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }


            txtNombres.Text = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgvAlumno.CurrentRow.Cells[3].Value.ToString();
            cboSemestre.Text = dgvAlumno.CurrentRow.Cells[4].Value.ToString();
            cboEspecialidad.Text = dgvAlumno.CurrentRow.Cells[5].Value.ToString();

            if (rbDiurno.Checked == true)
            {
                TURNO = "DIURNO";
            }
            if (rbNocturno.Checked == true)
            {
                TURNO = "NOCTURNO";
            }


            TURNO = dgvAlumno.CurrentRow.Cells[6].Value.ToString();
            ID_ALUMNO = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
            ID_ESPECIALIDAD = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
            Deshabilitar_Alumno();
            Habilitar_Botones();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Alumno();
            if (dgvAlumno.SelectedCells.Count > 0)
            {
                txtNombres.Text = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
                txtDni.Text = dgvAlumno.CurrentRow.Cells[3].Value.ToString();
                cboSemestre.Text = dgvAlumno.CurrentRow.Cells[4].Value.ToString();
                cboEspecialidad.SelectedItem = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
                if (dgvAlumno.CurrentRow.Cells[6].Value.ToString()== "DIURNO")
                {
                    rbDiurno.Checked = true;
                }
                if (dgvAlumno.CurrentRow.Cells[6].Value.ToString() == "NOCTURNO")
                {
                    rbNocturno.Checked = true;
                }
                ID_ALUMNO = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
                ID_ESPECIALIDAD = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
                ID_ALUMNO = dgvAlumno.CurrentRow.Cells[0].Value.ToString();

                editar = true;
                btnGuardar.Enabled = true;

            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Alumno!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtDni.TextLength < 8)
            {
                MessageBox.Show("Número de DNI inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (editar == false)
                {
                    if (txtApellidos.Text == "" || txtNombres.Text == "" || txtDni.Text == "" || cboEspecialidad.Text == "" || cboSemestre.Text == "")
                    {
                        MessageBox.Show("Faltan Ingresar Datos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        if (rbDiurno.Checked == true)
                        {
                            TURNO = "DIURNO";
                        }
                        if (rbNocturno.Checked == true)
                        {
                            TURNO = "NOCTURNO";
                        }

                        alumnol.Insertar_Alumno(txtNombres.Text, txtApellidos.Text, txtDni.Text, cboSemestre.SelectedItem.ToString(), cboEspecialidad.SelectedValue.ToString(), TURNO);
                        MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                        Mostrar_Alumno();
                        Limpiar_Alumno();
                        Deshabilitar_Botones();
                        Deshabilitar_Alumno();
                        btnEditar.Enabled = false;
                        btnGuardar.Enabled = false;

                    }
                }



                if (editar == true)
                {
                    if (rbDiurno.Checked == true)
                    {
                        TURNO = "DIURNO";
                    }
                    if (rbNocturno.Checked == true)
                    {
                        TURNO = "NOCTURNO";
                    }

                    alumnol.Editar_Alumno(txtNombres.Text, txtApellidos.Text, txtDni.Text, cboSemestre.SelectedItem.ToString(), cboEspecialidad.SelectedValue.ToString(), TURNO, ID_ALUMNO);
                    MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Alumno();
                    Limpiar_Alumno();
                    editar = false;
                    Deshabilitar_Alumno();
                    btnEditar.Enabled = false;
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.sololetras(e);
        }

        private void Alumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.solonumeros(e);
        }

        private void dgvAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
