using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class BibliotecarioDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_BIBLIOTECARIO()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_BIBLIOTECARIO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void INSERTAR_BIBLIOTECARIO(string DNI,string CONTRASEÑA,string NOMBRES,string APELLIDOS,string TURNO,string ESTADO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSETAR_BIBLIOTECARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DNI",DNI);
            comando.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA);
            comando.Parameters.AddWithValue("@NOMBRES", NOMBRES);
            comando.Parameters.AddWithValue("@APELLIDOS", APELLIDOS);
            comando.Parameters.AddWithValue("@TURNO", TURNO);
            comando.Parameters.AddWithValue("@ESTADO", ESTADO);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        
        public void EDITAR_BIBLIOTECARIO(string DNI,string CONTRASEÑA, string NOMBRES, string APELLIDOS, string TURNO, int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_BIBLIOTECARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DNI", DNI);
            comando.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA);
            comando.Parameters.AddWithValue("@NOMBRES", NOMBRES);
            comando.Parameters.AddWithValue("@APELLIDOS", APELLIDOS);
            comando.Parameters.AddWithValue("@TURNO", TURNO);
            comando.Parameters.AddWithValue("@ID", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ELIMINAR_BIBLIOTECARIO(string DNI)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_BIBLIOTECARIO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DNI", DNI);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}
