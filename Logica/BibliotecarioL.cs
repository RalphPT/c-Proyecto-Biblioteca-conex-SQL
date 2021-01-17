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
    public class BibliotecarioL
    {
        private BibliotecarioDB bibliotecariodb = new BibliotecarioDB();

        public DataTable Mostrar_Bibliotecario()
        {
            DataTable tabla = new DataTable();
            tabla = bibliotecariodb.MOSTRAR_BIBLIOTECARIO();
            return tabla;
        }

        public void Insertar_Bibliotecario(string DNI,string CONTRASEÑA,string NOMBRES,string APELLIDOS,string TURNO,string ESTADO)
        {
            bibliotecariodb.INSERTAR_BIBLIOTECARIO(DNI,CONTRASEÑA,NOMBRES,APELLIDOS,TURNO,ESTADO);
        }

        public void Editar_Bibliotecario(string CONTRASEÑA, string NOMBRES, string APELLIDOS, string TURNO, string DNI,string ID)
        {
            bibliotecariodb.EDITAR_BIBLIOTECARIO(CONTRASEÑA, NOMBRES, APELLIDOS, TURNO, DNI, int.Parse(ID));
        }

        public void Eliminar_Bibliotecario(string DNI)
        {
            bibliotecariodb.ELIMINAR_BIBLIOTECARIO(DNI);
        }
    }
}
