using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class ComputadoraDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_COMPUTADORA()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_COMPUTADORA";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void INSERTAR_COMPUTADORA(int NUMERO, string ESTADO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_COMPUTADORA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NUMERO", NUMERO);
            comando.Parameters.AddWithValue("@ESTADO", ESTADO);
             comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EDITAR_COMPUTADORA(int NUMERO, string ESTADO, int ID_COMP)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_COMPUTADORA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NUMERO", NUMERO);
            comando.Parameters.AddWithValue("@ESTADO", ESTADO);
            comando.Parameters.AddWithValue("@ID_COMP", ID_COMP);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void ELIMINAR_COMPUTADORA(int ID_COMP)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_COMPUTADORA";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_COMP", ID_COMP);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
