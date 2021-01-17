using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Logica
{
    public class AlumnoL
    {
        AlumnoDB alumnodb = new AlumnoDB();

        public DataTable Mostrar_Alumno()
        {
            DataTable tabla = new DataTable();
            tabla = alumnodb.MOSTRAR_ALUMNO();
            return tabla;
        }

        public DataTable Listar_Especialidad()
        {
            DataTable tabla_cat = new DataTable();
            tabla_cat = alumnodb.LISTAR_ESPECIALIDAD();
            return tabla_cat;
        }

        public void Insertar_Alumno(string NOMBRE_ALUM, string APELLIDOS_ALUM, string DNI_ALUM, string SEMESTRE, string ID_ESPECIALIDAD, string TURNO_ALUM)
        {
            alumnodb.INSERTAR_ALUMNO(NOMBRE_ALUM, APELLIDOS_ALUM, DNI_ALUM, SEMESTRE, int.Parse(ID_ESPECIALIDAD), TURNO_ALUM);
        }

        public void Editar_Alumno(string NOMBRE_ALUM, string APELLIDOS_ALUM, string DNI_ALUM, string SEMESTRE, string ID_ESPECIALIDAD, string TURNO_ALUM, string ID_ALUMNO)
        {
            alumnodb.EDITAR_ALUMNO(NOMBRE_ALUM, APELLIDOS_ALUM, DNI_ALUM, SEMESTRE, int.Parse(ID_ESPECIALIDAD), TURNO_ALUM, int.Parse(ID_ALUMNO));
        }

        public void Eliminar_Alumno(string ID_ALUMNO)
        {
            alumnodb.ELIMINAR_ALUMNO(ID_ALUMNO);
        }

    }
}
