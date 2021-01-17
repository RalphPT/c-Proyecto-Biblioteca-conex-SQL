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
    public class LibroL
    {
        LibroDB librodb = new  LibroDB();

        public DataTable Mostrar_Libro()
        {
            DataTable tabla = new DataTable();
            tabla = librodb.MOSTRAR_LIBRO();
            return tabla;
        }

        public DataTable Mostrar_Busqueda_Libro()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = librodb.MOSTRAR_BUSQUEDA_LIBRO();
            return tabla2;
        }

        public DataTable Listar_Categoria()
        {
            DataTable tabla_cat = new DataTable();
            tabla_cat = librodb.LISTAR_CATEGORIA();
            return tabla_cat;
        }

        public void Insertar_Libro(string COD_LIBRO, string TITULO, string AUTOR, string EDITORIAL, string ID_CATEGORIA, string DISPONIBILIDAD, string DESCRIPCION)
        {
            librodb.INSERTAR_LIBRO(COD_LIBRO, TITULO, AUTOR, EDITORIAL,int.Parse(ID_CATEGORIA), DISPONIBILIDAD, DESCRIPCION);
        }

        public void Editar_Libro(string COD_LIBRO, string TITULO, string AUTOR, string EDITORIAL, string ID_CATEGORIA, string DISPONIBILIDAD, string DESCRIPCION,string ID_LIBRO)
        {
            librodb.EDITAR_LIBRO(COD_LIBRO, TITULO, AUTOR, EDITORIAL, int.Parse(ID_CATEGORIA), DISPONIBILIDAD, DESCRIPCION,int.Parse(ID_LIBRO));
        }

        public void Eliminar_Libro(string COD_LIBRO)
        {
            librodb.ELIMINAR_LIBRO(COD_LIBRO);
        }

    }
}
