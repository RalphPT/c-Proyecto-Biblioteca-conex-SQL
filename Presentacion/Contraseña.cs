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
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void Contraseña_Load(object sender, EventArgs e)
        {
  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login irlogin = new Login();
            irlogin.Show();
            Hide();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "" && txtNombres.Text == "" && txtApellidos.Text == "")
            {
                MessageBox.Show("Campos Vacíos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                try
                {
                    Buscar_Usuario();
                    if (txtDni.Text == DNI && txtNombres.Text == NOMBRES && txtApellidos.Text == APELLIDOS)
                    {
                        txtContraNueva.Enabled = true;
                        txtContraNueva2.Enabled = true;
                        btnRestablecer.Enabled = true;
                        txtDni.Enabled = false;
                        txtNombres.Enabled = false;
                        txtApellidos.Enabled = false;

                    }

                    else
                    {
                        MessageBox.Show("No encontrado!, Asegúrese de haber insertado sus datos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtApellidos.Clear();
                        txtDni.Clear();
                        txtNombres.Clear();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("No encontrado!, Asegúrese de haber insertado sus datos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellidos.Clear();
                    txtDni.Clear();
                    txtNombres.Clear();
                } 
       
            }                  
        }

        string DNI = null, NOMBRES = null, APELLIDOS = null;

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            if (txtContraNueva.Text==txtContraNueva2.Text)
            {
                Reestablecer_Usuario();
                MessageBox.Show("Actualizado Correctamente", "Satisfactorio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login irlogin = new Login();
                irlogin.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        Validación validacion = new Validación();
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.solonumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.sololetras(e);
        }

        public void Buscar_Usuario()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader leer;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM BIBLIOTECARIO WHERE DNI='" + txtDni.Text + "'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            DNI = tabla.Rows[0][1].ToString();
            NOMBRES = tabla.Rows[0][3].ToString();
            APELLIDOS = tabla.Rows[0][4].ToString();
            comando.Connection = conexion.CerrarConexion();
        }

        public void Reestablecer_Usuario()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE BIBLIOTECARIO SET CONTRASEÑA ='"+txtContraNueva.Text+"'"+"  WHERE DNI='" + txtDni.Text + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
    }
}
