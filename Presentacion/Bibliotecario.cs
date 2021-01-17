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
    public partial class Bibliotecario : Form
    {
        BibliotecarioL objbibliotecario = new BibliotecarioL();
        private bool editar = false;
        private string id_bibliotecario=null;



        public Bibliotecario()
        {
            InitializeComponent();
        }

        private void Bibliotecario_Load(object sender, EventArgs e)
        {
            Mostrar_Bibliotecario();
     

        }

        private void Mostrar_Bibliotecario()
        {
            BibliotecarioL bibliotecario = new BibliotecarioL();
            dgvBibliotecario.DataSource = bibliotecario.Mostrar_Bibliotecario();
            dgvBibliotecario.Columns[0].Width = 30;
            dgvBibliotecario.Columns[1].Width = 70;
            dgvBibliotecario.Columns[3].Width = 150;
            dgvBibliotecario.Columns[4].Width = 150;
            dgvBibliotecario.Columns[5].Width = 80;

        }
        
        string TURNO = null;
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
                    if (txtDni.Text == "" || txtApellidos.Text == "" || txtContraseña.Text == "" || txtNombres.Text == "")
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

                        objbibliotecario.Insertar_Bibliotecario(txtDni.Text, txtContraseña.Text, txtNombres.Text, txtApellidos.Text, TURNO,"0");
                        MessageBox.Show("Grabado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                        Mostrar_Bibliotecario();
                        Limpiar_Bibliotecario();
                        DeshabilitarBotones();
                        Deshabilitar_Bibliotecario();


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

                    objbibliotecario.Editar_Bibliotecario(txtDni.Text, txtContraseña.Text, txtNombres.Text, txtApellidos.Text, TURNO, id_bibliotecario);
                    MessageBox.Show("Editado Correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar_Bibliotecario();
                    Limpiar_Bibliotecario();
                    btnGuardar.Enabled = false;
                    DeshabilitarBotones();
                    Deshabilitar_Bibliotecario();
                    editar = false;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar_Bibliotecario();
            if (dgvBibliotecario.SelectedCells.Count > 0)
            {
                txtDni.Text = dgvBibliotecario.CurrentRow.Cells[1].Value.ToString();
                txtContraseña.Text = dgvBibliotecario.CurrentRow.Cells[2].Value.ToString();
                txtNombres.Text = dgvBibliotecario.CurrentRow.Cells[3].Value.ToString();
                txtApellidos.Text = dgvBibliotecario.CurrentRow.Cells[4].Value.ToString();
                id_bibliotecario = dgvBibliotecario.CurrentRow.Cells[0].Value.ToString();
                if (TURNO == "DIURNO")
                {
                    rbDiurno.Checked = true;
                }
                if (TURNO == "NOCTURNO")
                {
                    rbNocturno.Checked = true;
                }
                TURNO = dgvBibliotecario.CurrentRow.Cells[5].Value.ToString();              
                editar = true;
                btnGuardar.Enabled = true;

            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvBibliotecario.SelectedCells.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está Seguro que desea Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.Yes)
                {
                    objbibliotecario.Eliminar_Bibliotecario(txtDni.Text);
                    Limpiar_Bibliotecario();
                    Mostrar_Bibliotecario();
                }
            }

            else
            {
                MessageBox.Show("No se ha Seleccionado Bibliotecario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvBibliotecario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            txtDni.Text = dgvBibliotecario.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvBibliotecario.CurrentRow.Cells[2].Value.ToString();
            txtNombres.Text = dgvBibliotecario.CurrentRow.Cells[3].Value.ToString();
            txtApellidos.Text = dgvBibliotecario.CurrentRow.Cells[4].Value.ToString();
            if (TURNO == "DIURNO")
            {
                rbDiurno.Checked = true;
            }
            if (TURNO == "NOCTURNO")
            {
                rbNocturno.Checked = true;
            }
            TURNO = dgvBibliotecario.CurrentRow.Cells[5].Value.ToString();
            id_bibliotecario = dgvBibliotecario.CurrentRow.Cells[0].Value.ToString();
            Deshabilitar_Bibliotecario();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
        }
        public void Limpiar_Bibliotecario()
        {
            txtDni.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtContraseña.Text = "";
            rbDiurno.Checked = true;
        }

        public void Deshabilitar_Bibliotecario()
        {
            txtDni.Enabled = false;
            txtContraseña.Enabled = false;
            txtApellidos.Enabled = false;
            txtNombres.Enabled = false;
            rbDiurno.Enabled = false;
            rbNocturno.Enabled = false;
        }

        public void Habilitar_Bibliotecario()
        {
            txtNombres.Enabled = true;
            txtDni.Enabled = true;
            txtApellidos.Enabled = true;
            txtContraseña.Enabled = true;
            rbDiurno.Enabled = true;
            rbNocturno.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editar = false;
            Habilitar_Bibliotecario();
            Limpiar_Bibliotecario();
            HabilitarBotones();
            txtDni.Focus();
            
        }

        private void DeshabilitarBotones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void HabilitarBotones()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Mantenimiento irmenu = new Mantenimiento();
            irmenu.Show();
            this.Visible = false;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validación v = new Validación();
            v.solonumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validación v = new Validación();
            v.sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validación v = new Validación();
            v.sololetras(e);
        }

        private void Bibliotecario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
