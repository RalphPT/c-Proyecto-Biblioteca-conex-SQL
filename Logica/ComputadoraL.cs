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
    public class ComputadoraL
    {
        ComputadoraDB computadoradb = new ComputadoraDB();

        public DataTable Mostrar_Computadora()
        {
            DataTable tabla = new DataTable();
            tabla = computadoradb.MOSTRAR_COMPUTADORA();
            return tabla;
        }

        public void Insertar_Computadora(string NUMERO, string ESTADO)
        {
            computadoradb.INSERTAR_COMPUTADORA(int.Parse(NUMERO),ESTADO);
        }

        public void Editar_Computadora(string NUM,string ESTADO,string ID_COMP)
        {
            computadoradb.EDITAR_COMPUTADORA(int.Parse(NUM),ESTADO,int.Parse(ID_COMP));
        }

        public void Eliminar_Computadora(string ID_COMP)
        {
            computadoradb.ELIMINAR_COMPUTADORA(int.Parse(ID_COMP));
        }

    }
}
