using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CategoriaDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_CATEGORIA()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void INSERTAR_CATEGORIA(string NOMBRE_CAT)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_CAT", NOMBRE_CAT);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EDITAR_CATEGORIA(string NOMBRE_CAT, int ID_CATEGORIA)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_CAT", NOMBRE_CAT);
            comando.Parameters.AddWithValue("@ID_CATEGORIA", ID_CATEGORIA);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ELIMINAR_CATEGORIA(string ID_CATEGORIA)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_CATEGORIA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_CATEGORIA", ID_CATEGORIA);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
