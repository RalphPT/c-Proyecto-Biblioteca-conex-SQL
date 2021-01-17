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
    public class EspecialidadL
    {
        private EspecialidadDB especialidaddb = new EspecialidadDB();

        public DataTable Mostrar_Especialidad()
        {
            DataTable tabla = new DataTable();
            tabla = especialidaddb.MOSTRAR_ESPECIALIDAD();
            return tabla;
        }

        public void Insertar_Especialidad(string NOMBRE_ESP)
        {
            especialidaddb.INSERTAR_ESPECIALIDAD( NOMBRE_ESP);
        }

        public void Editar_Especialidad(string NOMBRE_ESP, string ID_ESPECIALIDAD)
        {
            especialidaddb.EDITAR_ESPECIALIDAD(NOMBRE_ESP, int.Parse(ID_ESPECIALIDAD));
        }

        public void Eliminar_Especialidad(string ID_ESPECIALIDAD)
        {
            especialidaddb.ELIMINAR_ESPECIALIDAD(ID_ESPECIALIDAD);
        }

    }
}
