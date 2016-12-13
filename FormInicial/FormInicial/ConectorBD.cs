using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormInicial
{
    public class ConectorBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=sicej; Uid=root; pwd=my-admin32;");
            conectar.Open();
            return conectar;
        }
        public static MySqlConnection CerrarConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bdvt; Uid=root; pwd=20601;");
            conectar.Close();
            return conectar;
        }
    }
}
