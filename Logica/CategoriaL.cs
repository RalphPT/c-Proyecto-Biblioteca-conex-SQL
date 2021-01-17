using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Logica
{
     public class CategoriaL
    {

        private CategoriaDB categoriadb = new CategoriaDB();

        public DataTable Mostrar_Categoria()
        {
            DataTable tabla = new DataTable();
            tabla = categoriadb.MOSTRAR_CATEGORIA();
            return tabla;
        }

        public void Insertar_Categoria( string NOMBRE_CAT)
        {
            categoriadb.INSERTAR_CATEGORIA(NOMBRE_CAT);
        }

        public void Editar_Categoria(string NOMBRE_CAT, string ID_CATEGORIA)
        {
            categoriadb.EDITAR_CATEGORIA(NOMBRE_CAT, int.Parse(ID_CATEGORIA));
        }

        public void Eliminar_Categoria(string ID_CATEGORIA)
        {
            categoriadb.ELIMINAR_CATEGORIA(ID_CATEGORIA);
        }


    }
}
