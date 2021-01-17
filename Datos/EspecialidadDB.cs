using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class EspecialidadDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_ESPECIALIDAD()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_ESPECIALIDAD";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void INSERTAR_ESPECIALIDAD(string NOMBRE_ESP)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_ESPECIALIDAD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_ESP", NOMBRE_ESP);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EDITAR_ESPECIALIDAD(string NOMBRE_ESP, int ID_ESPECIALIDAD)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_ESPECIALIDAD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_ESP", NOMBRE_ESP);
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", ID_ESPECIALIDAD);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ELIMINAR_ESPECIALIDAD(string ID_ESPECIALIDAD)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_ESPECIALIDAD";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", ID_ESPECIALIDAD);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
