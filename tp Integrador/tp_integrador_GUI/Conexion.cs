using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_integrador_GUI
{
    internal class Conexion
    {
        public static MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string db = "datos.db";
            string usuario = "root";
            string password = "Fran2901";

            string cadena_conexion = "Database=" + db  + ";Data Source= " + servidor + ";User Id= " + usuario + ";Password= " + password+"";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadena_conexion);
                return conexionDB;
            }
            catch(MySqlException x)
            {
                Console.WriteLine("error= " + x.Message);
                return null;
            }
        }
    }
}
