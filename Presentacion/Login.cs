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
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Conectar()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE BIBLIOTECARIO SET ESTADO = '1' WHERE DNI='"+txtUsuario.Text+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }
        string USUARIO = null;
        string CONTRASEÑA = null;
        public void Buscar_Usuario()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            SqlDataReader leer;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT * FROM BIBLIOTECARIO WHERE DNI='" + txtUsuario.Text + "'";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                USUARIO = tabla.Rows[0][1].ToString();
                CONTRASEÑA = tabla.Rows[0][2].ToString();
                comando.Connection = conexion.CerrarConexion();
            }
            catch (Exception)
            {
                MessageBox.Show("Inicie como Administrador para Añadir Usuario", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "admin" )
            {
                    Buscar_Usuario();

                if (txtUsuario.Text == USUARIO && (txtContraseñaOculta.Text == CONTRASEÑA || txtContraseñaVista.Text == CONTRASEÑA))
                { 
                    Conectar();
                    Menu_2 irmenu = new Menu_2();
                    irmenu.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("Usuario no identificado!", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            

            else if(txtUsuario.Text == "admin" && (txtContraseñaOculta.Text == "admin" || txtContraseñaVista.Text =="admin"))
            {
                Menu irmenu = new Menu();
                irmenu.Show();
                Hide();
            }
            else
            {

                MessageBox.Show("Usuario no identificado!", "No registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }


            
        }

        private void lblContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contraseña ircontraseña = new Contraseña();
            ircontraseña.Show();
            Hide();
        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            Desconectar();
        }

        public void Desconectar()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UPDATE BIBLIOTECARIO SET ESTADO = '0'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Connection = conexion.CerrarConexion();
        }


        private void btnOcultar_Click_1(object sender, EventArgs e)
        {

            btnMostrar.Visible = true;
            btnOcultar.Visible = false;
            txtContraseñaVista.Visible = false;
            txtContraseñaOculta.Visible = true;
            txtContraseñaOculta.Text = txtContraseñaVista.Text;
            txtContraseñaOculta.Focus();
       
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnMostrar.Visible = false;
            btnOcultar.Visible = true;
            txtContraseñaOculta.Visible = false;
            txtContraseñaVista.Visible = true;
            txtContraseñaVista.Text = txtContraseñaOculta.Text;
            txtContraseñaVista.Focus();

        }
  
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
