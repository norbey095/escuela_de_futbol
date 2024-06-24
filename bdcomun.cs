using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace trabajo_final
{
    internal class bdcomun
    {
        public static MySqlConnection
            obtenerconexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=escuela;user=root;password=root;");
            conectar.Open();
            return conectar;
        }
    }
}
