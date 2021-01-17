using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class LibroDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_LIBRO()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_LIBRO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MOSTRAR_BUSQUEDA_LIBRO()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_BUSQUEDA_LIBRO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable LISTAR_CATEGORIA()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LISTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void INSERTAR_LIBRO(string COD_LIBRO, string TITULO, string AUTOR, string EDITORIAL, int ID_CATEGORIA, string DISPONIBILIDAD, string DESCRIPCION)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_LIBRO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@COD_LIBRO", COD_LIBRO);
            comando.Parameters.AddWithValue("@TITULO", TITULO);
            comando.Parameters.AddWithValue("@AUTOR", AUTOR);
            comando.Parameters.AddWithValue("@EDITORIAL", EDITORIAL);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", ID_CATEGORIA);
            comando.Parameters.AddWithValue("@DISPONIBILIDAD", DISPONIBILIDAD);
            comando.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EDITAR_LIBRO(string COD_LIBRO, string TITULO, string AUTOR, string EDITORIAL, int ID_CATEGORIA, string DISPONIBILIDAD, string DESCRIPCION, int ID_LIBRO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_LIBRO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@COD_LIBRO", COD_LIBRO);
            comando.Parameters.AddWithValue("@TITULO", TITULO);
            comando.Parameters.AddWithValue("@AUTOR", AUTOR);
            comando.Parameters.AddWithValue("@EDITORIAL", EDITORIAL);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", ID_CATEGORIA);
            comando.Parameters.AddWithValue("@DISPONIBILIDAD", DISPONIBILIDAD);
            comando.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);
            comando.Parameters.AddWithValue("@ID_LIBRO", ID_LIBRO);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ELIMINAR_LIBRO(string COD_LIBRO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_LIBRO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@COD_LIBRO", COD_LIBRO);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

  

    }
}
