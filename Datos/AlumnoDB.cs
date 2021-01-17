using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AlumnoDB
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MOSTRAR_ALUMNO()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MOSTRAR_ALUMNO";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable LISTAR_ESPECIALIDAD()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LISTAR_ESPECIALIDAD";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            Tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void INSERTAR_ALUMNO(string NOMBRE_ALUM, string APELLIDOS_ALUM, string DNI_ALUM, string SEMESTRE, int ID_ESPECIALIDAD, string TURNO_ALUM)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_ALUMNO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_ALUM", NOMBRE_ALUM);
            comando.Parameters.AddWithValue("@APELLIDOS_ALUM", APELLIDOS_ALUM);
            comando.Parameters.AddWithValue("@DNI_ALUM", DNI_ALUM);
            comando.Parameters.AddWithValue("@SEMESTRE", SEMESTRE);
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", ID_ESPECIALIDAD);
            comando.Parameters.AddWithValue("@TURNO_ALUM", TURNO_ALUM);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EDITAR_ALUMNO(string NOMBRE_ALUM, string APELLIDOS_ALUM, string DNI_ALUM, string SEMESTRE, int ID_ESPECIALIDAD, string TURNO_ALUM, int ID_ALUMNO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EDITAR_ALUMNO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE_ALUM", NOMBRE_ALUM);
            comando.Parameters.AddWithValue("@APELLIDOS_ALUM", APELLIDOS_ALUM);
            comando.Parameters.AddWithValue("@DNI_ALUM", DNI_ALUM);
            comando.Parameters.AddWithValue("@SEMESTRE", SEMESTRE);
            comando.Parameters.AddWithValue("@ID_ESPECIALIDAD", ID_ESPECIALIDAD);
            comando.Parameters.AddWithValue("@TURNO_ALUM", TURNO_ALUM);
            comando.Parameters.AddWithValue("@ID_ALUMNO", ID_ALUMNO);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ELIMINAR_ALUMNO(string ID_ALUMNO)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ELIMINAR_ALUMNO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID_ALUMNO", ID_ALUMNO);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}
